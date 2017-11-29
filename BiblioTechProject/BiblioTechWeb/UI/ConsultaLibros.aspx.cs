using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class ConsultaLibros : System.Web.UI.Page
    {
        public List<BiblioTechProject.Entidades.Libro> Lista { get; set; }
        public BiblioTechProject.Entidades.Libro LibroSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si le pongo esa condición me genera un excepción cuando le doy a "Salir de sesión"
            //if (!this.IsPostBack)
            //{
                Lista = new List<BiblioTechProject.Entidades.Libro>();
                LibroSeleccionado = null;
            //}
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.Text == "ID")
            {
                int id = Utilidad.ToInt(FiltrarTextBox.Text);
                Lista = BiblioTechProject.BLL.LibroBLL.GetListConNombresEditoriales(U => U.LibroId == id);
            }
            else if (FiltrarDropDownList.Text == "Título")
            {
                Lista = BiblioTechProject.BLL.LibroBLL.GetListConNombresEditoriales(U => U.Titulo == FiltrarTextBox.Text);
            }
            else
            {
                Lista = BiblioTechProject.BLL.LibroBLL.GetListConNombresEditoriales(U => U.LibroId > 0);
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            LibroSeleccionado = BiblioTechProject.BLL.LibroBLL.Buscar(U => U.LibroId == id);
            BiblioTechProject.BLL.LibroBLL.Eliminar(LibroSeleccionado);
            LibroSeleccionado = null;
            Filtrar();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            LibroSeleccionado = BiblioTechProject.BLL.LibroBLL.Buscar(U => U.LibroId == id);
            Server.Transfer("RegistroLibros.aspx");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            //Lista = new List<BiblioTechProject.Entidades.Libro>();
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No disponible');", addScriptTags: true);
            Filtrar();
            Server.Transfer("Reportes/ReporteLibros.aspx");
        }
    }
}