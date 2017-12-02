using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class ConsultaEditoriales : System.Web.UI.Page
    {
        public List<BiblioTechProject.Entidades.Editorial> Lista { get; set; }
        public BiblioTechProject.Entidades.Editorial EditorialSeleccionada { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si le pongo esa condición me genera un excepción cuando le doy a "Salir de sesión"
            //if (!this.IsPostBack)
            //{
                Lista = new List<BiblioTechProject.Entidades.Editorial>();
                EditorialSeleccionada = null;
            //}
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.Text == "ID")
            {
                int id = Utilidad.ToInt(FiltrarTextBox.Text);
                Lista = BiblioTechProject.BLL.EditorialBLL.GetList(U => U.EditorialId == id);
            }
            else if (FiltrarDropDownList.Text == "Nombre")
            {
                Lista = BiblioTechProject.BLL.EditorialBLL.GetList(U => U.Nombre == FiltrarTextBox.Text);
            }
            else
            {
                Lista = BiblioTechProject.BLL.EditorialBLL.GetList(U => U.EditorialId > 0);
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            EditorialSeleccionada = BiblioTechProject.BLL.EditorialBLL.Buscar(U => U.EditorialId == id);
            List<BiblioTechProject.Entidades.Libro> libros = BiblioTechProject.BLL.LibroBLL.GetList(L => L.EditorialId == EditorialSeleccionada.EditorialId);
            if (libros != null && libros.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Esta editorial no puede ser eliminada porque está registrada en un libro');", addScriptTags: true);
            }
            else
            {
                if (BiblioTechProject.BLL.EditorialBLL.Eliminar(EditorialSeleccionada))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Editorial eliminada con éxito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Error al intentar eliminar editorial');", addScriptTags: true);
                }
                EditorialSeleccionada = null;
            }
            Filtrar();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            EditorialSeleccionada = BiblioTechProject.BLL.EditorialBLL.Buscar(U => U.EditorialId == id);
            Server.Transfer("RegistroEditoriales.aspx");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/ReporteEditoriales.aspx");
        }
    }
}