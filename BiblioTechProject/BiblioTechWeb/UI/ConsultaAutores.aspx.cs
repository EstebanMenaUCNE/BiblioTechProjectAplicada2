using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class ConsultaAutores : System.Web.UI.Page
    {
        public List<BiblioTechProject.Entidades.Autor> Lista { get; set; }
        public BiblioTechProject.Entidades.Autor AutorSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si le pongo esa condición me genera un excepción cuando le doy a "Salir de sesión"
            //if (!this.IsPostBack)
            //{
            Lista = new List<BiblioTechProject.Entidades.Autor>();
            AutorSeleccionado = null;
            //}
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.Text == "ID")
            {
                int id = Utilidad.ToInt(FiltrarTextBox.Text);
                Lista = BiblioTechProject.BLL.AutorBLL.GetList(U => U.AutorId == id);
            }
            else if (FiltrarDropDownList.Text == "Nombre")
            {
                Lista = BiblioTechProject.BLL.AutorBLL.GetList(U => U.Nombre == FiltrarTextBox.Text);
            }
            else
            {
                Lista = BiblioTechProject.BLL.AutorBLL.GetList(U => U.AutorId > 0);
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            AutorSeleccionado = BiblioTechProject.BLL.AutorBLL.Buscar(U => U.AutorId == id);
            if (BLL.AutorLibroBLL.Buscar(R => R.AutorId == AutorSeleccionado.AutorId) != null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Este autor no puede ser eliminado porque está registrado en un libro');", addScriptTags: true);
            }
            else
            {
                if (BiblioTechProject.BLL.AutorBLL.Eliminar(AutorSeleccionado))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Autor eliminado con éxito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Error al intentar eliminar autor');", addScriptTags: true);
                }
                AutorSeleccionado = null;
            }
            Filtrar();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            AutorSeleccionado = BiblioTechProject.BLL.AutorBLL.Buscar(U => U.AutorId == id);
            Server.Transfer("RegistroAutores.aspx");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/ReporteAutores.aspx");
        }
    }
}