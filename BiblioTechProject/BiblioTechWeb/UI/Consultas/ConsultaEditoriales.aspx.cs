using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI.Consultas
{
    public partial class ConsultaEditoriales : System.Web.UI.Page
    {
        public static List<BiblioTechProject.Entidades.Editorial> Lista { get; set; }
        public static BiblioTechProject.Entidades.Editorial EditorialSeleccionada = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = new List<BiblioTechProject.Entidades.Editorial>();
            EditorialSeleccionada = null;
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
            BiblioTechProject.BLL.EditorialBLL.Eliminar(EditorialSeleccionada);
            EditorialSeleccionada = null;
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            EditorialSeleccionada = BiblioTechProject.BLL.EditorialBLL.Buscar(U => U.EditorialId == id);
            Response.Redirect("../Registros/RegistroEditoriales.aspx");
        }
    }
}