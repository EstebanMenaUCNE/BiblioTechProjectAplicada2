using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class ConsultaClientes : System.Web.UI.Page
    {
        public List<BiblioTechProject.Entidades.Cliente> Lista { get; set; }
        public BiblioTechProject.Entidades.Cliente ClienteSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si le pongo esa condición me genera un excepción cuando le doy a "Salir de sesión"
            //if (!this.IsPostBack)
            //{
                Lista = new List<BiblioTechProject.Entidades.Cliente>();
                ClienteSeleccionado = null;
            //}
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.Text == "ID")
            {
                int id = Utilidad.ToInt(FiltrarTextBox.Text);
                Lista = BiblioTechProject.BLL.ClienteBLL.GetList(U => U.ClienteId == id);
            }
            else if (FiltrarDropDownList.Text == "Nombre")
            {
                Lista = BiblioTechProject.BLL.ClienteBLL.GetList(U => U.Nombre == FiltrarTextBox.Text);
            }
            else
            {
                Lista = BiblioTechProject.BLL.ClienteBLL.GetList(U => U.ClienteId > 0);
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            ClienteSeleccionado = BiblioTechProject.BLL.ClienteBLL.Buscar(U => U.ClienteId == id);
            BiblioTechProject.BLL.ClienteBLL.Eliminar(ClienteSeleccionado);
            ClienteSeleccionado = null;
            Filtrar();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            ClienteSeleccionado = BiblioTechProject.BLL.ClienteBLL.Buscar(U => U.ClienteId == id);
            Server.Transfer("RegistroClientes.aspx");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/ReporteClientes.aspx");
        }
    }
}