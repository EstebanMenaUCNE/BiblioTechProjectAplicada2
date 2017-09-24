using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI.Registros
{
    public partial class RegistroEditoriales : System.Web.UI.Page
    {
        private Editorial editorial = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            if (Consultas.ConsultaEditoriales.EditorialSeleccionada != null)
            {
                editorial = Consultas.ConsultaEditoriales.EditorialSeleccionada;
                CargarDatos();
                NuevoOModificando();
            }
        }

        private void DeshabilitarCampos()
        {
            NombreTextBox.Enabled = false;
        }

        private void Limpiar()
        {
            editorial = null;
            Consultas.ConsultaEditoriales.EditorialSeleccionada = null;
            EditorialIdTextBox.Text = "";
            NombreTextBox.Text = "";

            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            NuevoOModificando();
        }

        private void CargarDatos()
        {
            EditorialIdTextBox.Text = editorial.EditorialId.ToString();
            NombreTextBox.Text = editorial.Nombre;
        }

        private void NuevoOModificando()
        {
            if (EditorialIdTextBox.Text == "")
            {
                NuevoOModificandoLabel.Text = "Nueva editorial";
            }
            else
            {
                NuevoOModificandoLabel.Text = "Modificando la editorial " + EditorialIdTextBox.Text;
            }
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (EditorialIdTextBox.Text != "")
            {
                id = Utilidad.ToInt(EditorialIdTextBox.Text);
            }
            editorial = new Editorial(id, NombreTextBox.Text);
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (BiblioTechProject.BLL.EditorialBLL.Guardar(editorial))
                {
                    EditorialIdTextBox.Text = editorial.EditorialId.ToString();

                    if (Consultas.ConsultaEditoriales.EditorialSeleccionada == null)
                    {
                        MensajeAlertaGuardadoExito.Text = "¡Guardado con éxito con el ID " + editorial.EditorialId + "!";
                    }
                    else
                    {
                        MensajeAlertaGuardadoExito.Text = "Repita los cambios realizados para modificar. Esto por la seguridad de los datos.";
                    }
                    AlertaGuardadoExito.Visible = true;
                    NuevoOModificando();
                    Consultas.ConsultaEditoriales.EditorialSeleccionada = null;
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

        protected void EditorialIdTextBox_TextChanged(object sender, EventArgs e)
        {
            NuevoOModificando();
        }
    }
}