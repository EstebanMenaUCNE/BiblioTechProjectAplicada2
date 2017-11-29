using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class RegistroLibros : System.Web.UI.Page
    {
        private Libro libro = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            if (!this.IsPostBack)
            {
                LlenarEditorialDropDownList();
                LlenarAutoresDropDownList();
                Session["ListaAutores"] = new List<Autor>();
                Session["ListaRelaciones"] = new List<AutorLibro>();
                Session["relacionesEliminadas"] = false;
                LlenarAutoresDataGrid();
                
            }

            if (PreviousPage != null && PreviousPage.LibroSeleccionado != null)
            {
                libro = PreviousPage.LibroSeleccionado;
                CargarDatos();
                NuevoOModificando();
            }
        }

        private void Limpiar()
        {
            libro = null;
            LibroIdTextBox.Text = "";
            TituloTextBox.Text = "";
            EdicionTextBox.Text = "";

            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            Session["ListaAutores"] = new List<Autor>();
            Session["ListaRelaciones"] = new List<AutorLibro>();
            Session["relacionesEliminadas"] = true;
            LlenarAutoresDataGrid();

            NuevoOModificando();
        }

        private void CargarDatos()
        {
            LibroIdTextBox.Text = libro.LibroId.ToString();
            TituloTextBox.Text = libro.Titulo;
            EdicionTextBox.Text = libro.Edicion.ToString();
            EstadoDropDownList.Text = libro.Estado;
            EditorialDropDownList.SelectedValue = libro.EditorialId.ToString();
            //Detalle
            Session["ListaRelaciones"] = BLL.AutorLibroBLL.GetList(R => R.LibroId == libro.LibroId);
            List<AutorLibro> listaRelaciones = (List<AutorLibro>)Session["ListaRelaciones"];
            List<Autor> listaAutores = new List<Autor>();
            foreach (var relacion in listaRelaciones)
            {
                listaAutores.Add(AutorBLL.Buscar(A => A.AutorId == relacion.AutorId));
            }
            Session["ListaAutores"] = listaAutores;
            LlenarAutoresDataGrid();
        }

        private void LlenarAutoresDataGrid()
        {
            List<Autor> Lista = (List<Autor>)Session["ListaAutores"];
            AutoresGridView.DataSource = Lista;
            AutoresGridView.DataBind();
        }

        private void LlenarEditorialDropDownList()
        {
            EditorialDropDownList.DataSource = EditorialBLL.GetList(E => E.EditorialId > 0);
            EditorialDropDownList.DataValueField = "EditorialId";
            EditorialDropDownList.DataTextField = "Nombre";
            EditorialDropDownList.DataBind();
        }

        private void LlenarAutoresDropDownList()
        {
            AutoresDropDownList.DataSource = AutorBLL.GetList(E => E.AutorId > 0);
            AutoresDropDownList.DataValueField = "AutorId";
            AutoresDropDownList.DataTextField = "Nombre";
            AutoresDropDownList.DataBind();
        }

        private void NuevoOModificando()
        {
            if (LibroIdTextBox.Text == "")
            {
                NuevoOModificandoLabel.Text = "Nuevo libro";
            }
            else
            {
                NuevoOModificandoLabel.Text = "Modificando el libro " + LibroIdTextBox.Text;
            }
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(TituloTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(EdicionTextBox.Text) && Utilidad.ToInt(EdicionTextBox.Text) == 0)
            {
                flag = false;
            }
            if (EditorialDropDownList.Text == "")
            {
                flag = false;
            }
            if (AutoresDropDownList.Text == "")
            {
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (LibroIdTextBox.Text != "")
            {
                id = Utilidad.ToInt(LibroIdTextBox.Text);
            }
            libro = new Libro(id, TituloTextBox.Text, Utilidad.ToInt(EdicionTextBox.Text), EstadoDropDownList.Text, Utilidad.ToInt(EditorialDropDownList.SelectedValue));
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                List<AutorLibro> listaRelaciones = (List<AutorLibro>) Session["ListaRelaciones"];
                bool relacionesEliminadas = (bool)Session["relacionesEliminadas"];
                if (LibroBLL.Guardar(libro, listaRelaciones, relacionesEliminadas))
                {
                    LibroIdTextBox.Text = libro.LibroId.ToString();
                    MensajeAlertaGuardadoExito.Text = "¡Guardado con éxito con el ID " + libro.LibroId + "!";
                    AlertaGuardadoExito.Visible = true;
                    NuevoOModificando();
                }
                else
                {
                    AlertaError.Visible = true;
                }
            }
            else
            {
                AlertaValidar.Visible = true;
            }
        }

        protected void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            List<Autor> listaAutores = (List<Autor>) Session["ListaAutores"];
            int id = Utilidad.ToInt(AutoresDropDownList.SelectedValue);
            bool insertar = true;
            foreach (var author in listaAutores)
            {
                if (author.AutorId == id)
                {
                    insertar = false;
                }
            }
            if (insertar)
            {
                Autor autor = AutorBLL.Buscar(A => A.AutorId == id);
                listaAutores.Add(autor);
                List<AutorLibro> listaRelaciones = (List<AutorLibro>)Session["ListaRelaciones"];
                listaRelaciones.Add(new AutorLibro(0, autor.AutorId, 0));
                LlenarAutoresDataGrid();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Este autor ya se encuentra agregado');", addScriptTags: true);
            }
            
        }

        protected void EliminarAutoresButton_Click(object sender, EventArgs e)
        {
            Session["ListaAutores"] = new List<Autor>();
            Session["ListaRelaciones"] = new List<AutorLibro>();
            Session["relacionesEliminadas"] = true;
            LlenarAutoresDataGrid();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Los cambios se guardarán cuando haga clic en Guardar');", addScriptTags: true);
        }
    }
}