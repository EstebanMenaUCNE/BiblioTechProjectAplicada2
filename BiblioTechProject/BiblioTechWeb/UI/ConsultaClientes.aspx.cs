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
            else if (FiltrarDropDownList.Text == "Cédula")
            {
                Lista = BiblioTechProject.BLL.ClienteBLL.GetList(U => U.Cedula == FiltrarTextBox.Text);
            }
            else if (FiltrarDropDownList.Text == "Masculinos")
            {
                Lista = BiblioTechProject.BLL.ClienteBLL.GetList(U => U.Sexo == "Masculino");
            }
            else if (FiltrarDropDownList.Text == "Femeninos")
            {
                Lista = BiblioTechProject.BLL.ClienteBLL.GetList(U => U.Sexo == "Femenino");
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
            if (BiblioTechProject.BLL.PrestamoBLL.Buscar(R => R.ClienteId == ClienteSeleccionado.ClienteId) != null)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Este cliente no puede ser eliminado porque está registrado en un préstamo');", addScriptTags: true);
            }
            else
            {
                if (BiblioTechProject.BLL.ClienteBLL.Eliminar(ClienteSeleccionado))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Cliente eliminado con éxito');", addScriptTags: true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Error al intentar eliminar cliente');", addScriptTags: true);
                }
                ClienteSeleccionado = null;
            }
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