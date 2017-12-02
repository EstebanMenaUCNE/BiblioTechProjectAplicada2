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
    public partial class RegistroPrestamos : System.Web.UI.Page
    {
        private Prestamo prestamo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            if (!this.IsPostBack)
            {
                LlenarLibrosDropDownList();
                LlenarClienteDropDownList();
                Session["ListaLibros"] = new List<Libro>();
                Session["ListaRelaciones"] = new List<PrestamoLibro>();
                Session["relacionesEliminadas"] = false;
                ViewState["EstadoAntesModificar"] = "";
                LlenarLibrosDataGrid();

            }

            if (PreviousPage != null && PreviousPage.PrestamoSeleccionado != null)
            {
                prestamo = PreviousPage.PrestamoSeleccionado;
                CargarDatos();
                NuevoOModificando();
            }
        }

        private void Limpiar()
        {
            prestamo = null;
            PrestamoIdTextBox.Text = "";
            FechaPrestamoTextBox.Text = "";
            FechaEntregarAntesTextBox.Text = "";
            FechaLibrosEntregadosTextBox.Text = "";

            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            Session["ListaLibros"] = new List<Libro>();
            Session["ListaRelaciones"] = new List<PrestamoLibro>();
            Session["relacionesEliminadas"] = true;
            ViewState["EstadoAntesModificar"] = "";
            LlenarLibrosDataGrid();

            NuevoOModificando();
        }

        private void CargarDatos()
        {
            PrestamoIdTextBox.Text = prestamo.PrestamoId.ToString();
            FechaPrestamoTextBox.Text = prestamo.FechaPrestamo.ToString("yyyy-MM-dd");
            FechaEntregarAntesTextBox.Text = prestamo.FechaEntregarAntes.ToString("yyyy-MM-dd");
            ClienteDropDownList.SelectedValue = prestamo.ClienteId.ToString();
            ViewState["EstadoAntesModificar"] = EstadoDropDownList.Text = prestamo.Estado;
            FechaLibrosEntregadosTextBox.Text = prestamo.FechaLibrosEntregados.ToString("yyyy-MM-dd");

            string estado = ViewState["EstadoAntesModificar"].ToString();

            //Detalle
            Session["ListaRelaciones"] = BLL.PrestamoLibroBLL.GetList(R => R.PrestamoId == prestamo.PrestamoId);
            List<PrestamoLibro> listaRelaciones = (List<PrestamoLibro>)Session["ListaRelaciones"];
            List<Libro> listaLibros = new List<Libro>();
            foreach (var relacion in listaRelaciones)
            {
                listaLibros.Add(LibroBLL.Buscar(A => A.LibroId == relacion.LibroId));
            }
            Session["ListaLibros"] = listaLibros;
            LlenarLibrosDataGrid();
        }

        private void LlenarLibrosDataGrid()
        {
            List<Libro> Lista = (List<Libro>)Session["ListaLibros"];
            LibrosGridView.DataSource = Lista;
            LibrosGridView.DataBind();
        }

        private void LlenarClienteDropDownList()
        {
            ClienteDropDownList.DataSource = ClienteBLL.GetList(E => E.ClienteId > 0);
            ClienteDropDownList.DataValueField = "ClienteId";
            ClienteDropDownList.DataTextField = "Nombre";
            ClienteDropDownList.DataBind();
        }

        private void LlenarLibrosDropDownList()
        {
            LibrosDropDownList.DataSource = LibroBLL.GetListConNombresEditoriales(E => E.Estado == "Disponible");
            LibrosDropDownList.DataValueField = "LibroId";
            LibrosDropDownList.DataTextField = "Titulo";
            LibrosDropDownList.DataBind();
        }

        private void NuevoOModificando()
        {
            if (PrestamoIdTextBox.Text == "")
            {
                NuevoOModificandoLabel.Text = "Nuevo préstamo";
                AgregarButton.Enabled = true;
                EliminarLibrosButton.Enabled = true;
            }
            else
            {
                NuevoOModificandoLabel.Text = "Modificando el préstamo " + PrestamoIdTextBox.Text;
                AgregarButton.Enabled = false;
                EliminarLibrosButton.Enabled = false;
            }
        }

        private bool Validar()
        {
            DateTime fechaPrestamo = Utilidad.ToDateTime(FechaPrestamoTextBox.Text);
            DateTime fechaEntregarAntes = Utilidad.ToDateTime(FechaEntregarAntesTextBox.Text);
            DateTime fechaLibrosEntregados = Utilidad.ToDateTime(FechaLibrosEntregadosTextBox.Text);
            List<Libro> listaLibros = (List<Libro>)Session["ListaLibros"];

            if (fechaPrestamo == new DateTime(1, 1, 1))
            {
                return false;
            }
            if (fechaEntregarAntes == new DateTime(1, 1, 1))
            {
                return false;
            }
            if (fechaPrestamo > fechaEntregarAntes)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['warning']('La fecha del prestamo no puede ser mayor a la fecha a entregar antes');", addScriptTags: true);
                return false;
            }
            if (EstadoDropDownList.Text == "Devuelto" && fechaLibrosEntregados < fechaPrestamo)
            {
                if (fechaLibrosEntregados == new DateTime(1, 1, 1))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['warning']('Seleccione la fecha en que los libros fueron devueltos');", addScriptTags: true);
                    return false;
                }
                else if (fechaLibrosEntregados < fechaPrestamo)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['warning']('La fecha en que se entragaron los libros no puede ser mayor a la fecha del préstamo');", addScriptTags: true);
                    return false;
                }
            }
            if (ClienteDropDownList.Text == "")
            {
                return false;
            }
            if (listaLibros.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['warning']('Primero debe agregar algún libro');", addScriptTags: true);
                return false;
            }
            return true;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            DateTime fechaLibrosEntregados = Utilidad.ToDateTime(FechaLibrosEntregadosTextBox.Text);
            if (PrestamoIdTextBox.Text != "")
            {
                id = Utilidad.ToInt(PrestamoIdTextBox.Text);
                string estadoAntesModificar = ViewState["EstadoAntesModificar"].ToString();
                if (estadoAntesModificar == "Devuelto" && EstadoDropDownList.Text == "Pendiente")
                {
                    EstadoDropDownList.Text = "Devuelto";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Una vez que el estado de un préstamo es marcado como Devuelto, no se puede cambiar a Pendiente');", addScriptTags: true);
                }
            }
            if (EstadoDropDownList.Text == "Pendiente")
            {
                fechaLibrosEntregados = new DateTime(1753, 1, 1);
            }
            prestamo = new Prestamo(id, DateTime.Parse(FechaPrestamoTextBox.Text), DateTime.Parse(FechaEntregarAntesTextBox.Text), fechaLibrosEntregados, EstadoDropDownList.Text, Utilidad.ToInt(ClienteDropDownList.SelectedValue));
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                List<PrestamoLibro> listaRelaciones = (List<PrestamoLibro>)Session["ListaRelaciones"];
                bool relacionesEliminadas = (bool)Session["relacionesEliminadas"];
                if (PrestamoBLL.Guardar(prestamo, listaRelaciones, relacionesEliminadas))
                {
                    //Cambiar el estado de los libros
                    bool EstadoLibrosModificados = true;
                    List<Libro> listaLibros = (List<Libro>)Session["ListaLibros"];
                    if (ViewState["EstadoAntesModificar"].ToString() == "Pendiente" && EstadoDropDownList.Text == "Devuelto") //Si se esta modificando un préstamo, y se está cambiando de pendiente a devuelto
                    {
                        foreach (var libro in listaLibros)
                        {
                            libro.Estado = "Disponible";
                            if (!LibroBLL.Guardar(libro, null, false))
                            {
                                EstadoLibrosModificados = false;
                            }
                        }
                        Session["ListaLibros"] = listaLibros;
                    }
                    else if (ViewState["EstadoAntesModificar"].ToString() == "" && EstadoDropDownList.Text == "Pendiente") //Si se va a guardar un préstamo nuevo, y está pendiente
                    {
                        foreach (var libro in listaLibros)
                        {
                            libro.Estado = "Prestado";
                            if (!LibroBLL.Guardar(libro, null, false))
                            {
                                EstadoLibrosModificados = false;
                            }
                        }
                        Session["ListaLibros"] = listaLibros;
                    }
                    
                    if (EstadoLibrosModificados) //Si se guardaron bien los libros entonces se guardo bien el préstamo, es decir, todo se guardo bien
                    {
                        PrestamoIdTextBox.Text = prestamo.PrestamoId.ToString();
                        ViewState["EstadoAntesModificar"] = prestamo.Estado;
                        LlenarLibrosDropDownList();
                        LlenarLibrosDataGrid();
                        MensajeAlertaGuardadoExito.Text = "¡Guardado con éxito con el ID " + prestamo.PrestamoId + "!";
                        AlertaGuardadoExito.Visible = true;
                    }
                    else
                    {
                        AlertaError.Visible = true;
                        MensajeAlertaError.Text = "Ocurrió un error al actualizar los estados de los libros del préstamo";
                    }
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
            if (LibrosDropDownList.Text != "")
            {

                List<Libro> listaLibros = (List<Libro>)Session["ListaLibros"];
                int id = Utilidad.ToInt(LibrosDropDownList.SelectedValue);
                bool insertar = true;
                foreach (var librox in listaLibros)
                {
                    if (librox.LibroId == id)
                    {
                        insertar = false;
                    }
                }
                if (insertar)
                {
                    Libro librox = LibroBLL.Buscar(A => A.LibroId == id);
                    listaLibros.Add(librox);
                    List<PrestamoLibro> listaRelaciones = (List<PrestamoLibro>)Session["ListaRelaciones"];
                    listaRelaciones.Add(new PrestamoLibro(0, 0, librox.LibroId));
                    LlenarLibrosDataGrid();
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Este libro ya se encuentra agregado');", addScriptTags: true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['warning']('Ningún libro seleccionado para agregar');", addScriptTags: true);
            }

        }

        protected void EliminarLibrosButton_Click(object sender, EventArgs e)
        {
            Session["ListaLibros"] = new List<Libro>();
            Session["ListaRelaciones"] = new List<PrestamoLibro>();
            Session["relacionesEliminadas"] = true;
            LlenarLibrosDataGrid();
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Los cambios se guardarán cuando haga clic en Guardar');", addScriptTags: true);
        }
    }
}