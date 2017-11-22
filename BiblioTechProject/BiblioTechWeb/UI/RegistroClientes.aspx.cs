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
    public partial class RegistroClientes : System.Web.UI.Page
    {
        private Cliente cliente = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            if (PreviousPage != null && PreviousPage.ClienteSeleccionado != null)
            {
                cliente = PreviousPage.ClienteSeleccionado;
                CargarDatos();
                NuevoOModificando();
            }
        }

        private void Limpiar()
        {
            cliente = null;
            ClienteIdTextBox.Text = "";
            NombreTextBox.Text = "";
            CedulaTextBox.Text = "";
            TelefonoTextBox.Text = "";
            DireccionTextBox.Text = "";
            FechaNacimientoTextBox.Text = "";
            EmailTextBox.Text = "";

            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            NuevoOModificando();
        }

        private void CargarDatos()
        {
            ClienteIdTextBox.Text = cliente.ClienteId.ToString();
            NombreTextBox.Text = cliente.Nombre;
            CedulaTextBox.Text = cliente.Cedula;
            TelefonoTextBox.Text = cliente.Telefono;
            DireccionTextBox.Text = cliente.Direccion;
            FechaNacimientoTextBox.Text = cliente.FechaNacimiento.GetDateTimeFormats()[80].ToString().Substring(0, 10); ;
            EmailTextBox.Text = cliente.Email;
        }

        private void NuevoOModificando()
        {
            if (ClienteIdTextBox.Text == "")
            {
                NuevoOModificandoLabel.Text = "Nuevo cliente";
            }
            else
            {
                NuevoOModificandoLabel.Text = "Modificando el cliente " + ClienteIdTextBox.Text;
            }
        }

        private bool Validar()
        {
            //Arreglar validaciones
            bool flag = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(CedulaTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonoTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(FechaNacimientoTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (ClienteIdTextBox.Text != "")
            {
                id = Utilidad.ToInt(ClienteIdTextBox.Text);
            }
            cliente = new Cliente(id, NombreTextBox.Text, CedulaTextBox.Text, SexoDropDownList.Text, TelefonoTextBox.Text, DireccionTextBox.Text, DateTime.Parse(FechaNacimientoTextBox.Text), EmailTextBox.Text);
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                LlenarCamposInstancia();
                if (ClienteBLL.Guardar(cliente))
                {
                    ClienteIdTextBox.Text = cliente.ClienteId.ToString();
                    MensajeAlertaGuardadoExito.Text = "¡Guardado con éxito con el ID " + cliente.ClienteId + "!";
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
        
    }
}