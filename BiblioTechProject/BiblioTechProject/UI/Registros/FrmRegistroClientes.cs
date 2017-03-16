using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI.Registros
{
    public partial class FrmRegistroClientes : Form
    {
        private static FrmRegistroClientes formulario = null;

        private FrmRegistroClientes()
        {
            InitializeComponent();
        }

        public static FrmRegistroClientes GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroClientes();
            }
            return formulario;
        }

        private void Limpiar()
        {
            clienteIdTextBox.Clear();
            nombreTextBox.Clear();
            cedulaMaskedTextBox.Clear();
            telefonoMaskedTextBox.Clear();
            direccionTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Now;
            emailTextBox.Clear();
        }

        private bool validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreErrorProvider.SetError(nombreTextBox, "Digite el nombre");
                flag = false;
            }
            if (cedulaMaskedTextBox.Text.Length < 13)
            {
                cedulaErrorProvider.SetError(cedulaMaskedTextBox, "Digite la cédula");
                flag = false;
            }
            if (telefonoMaskedTextBox.Text.Length < 14)
            {
                telefonoErrorProvider.SetError(telefonoMaskedTextBox, "Digite el teléfono");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                direccionErrorProvider.SetError(direccionTextBox, "Digite la dirección");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailErrorProvider.SetError(emailTextBox, "Digite el email");
                flag = false;
            }
            return flag;
        }

        private void PonerEstadosInvisibles()
        {
            guardadoToolStripStatusLabel.Visible = false;
            ErrorToolStripStatusLabel.Visible = false;
            noEncontradoToolStripStatusLabel.Visible = false;
            eliminadoToolStripStatusLabel.Visible = false;
        }

        private Entidades.Cliente GetClienteCampos()
        {
            return new Entidades.Cliente(Utilidad.ToInt(clienteIdTextBox.Text), nombreTextBox.Text, cedulaMaskedTextBox.Text, sexoComboBox.Text, telefonoMaskedTextBox.Text, direccionTextBox.Text, fechaNacimientoDateTimePicker.Value, emailTextBox.Text, FrmLogin.GetUsuarioLogueado().UsuarioId);
        }

        private void FrmRegistroClientes_Load(object sender, EventArgs e)
        {
            sexoComboBox.Text = "Masculino";
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            nombreTextBox.Focus();
            PonerEstadosInvisibles();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (!string.IsNullOrWhiteSpace(clienteIdTextBox.Text))
            {
                Entidades.Cliente cliente = BLL.ClienteBLL.Buscar(C => C.ClienteId == Utilidad.ToInt(clienteIdTextBox.Text));
                if (cliente != null)
                {
                    if (BLL.ClienteBLL.Eliminar(cliente))
                    {
                        eliminadoToolStripStatusLabel.Visible = true;
                    }
                    else
                    {
                        ErrorToolStripStatusLabel.Visible = true;
                    }
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (validar())
            {
                if (BLL.ClienteBLL.Guardar(GetClienteCampos()))
                {
                    guardadoToolStripStatusLabel.Visible = true;
                }
                else
                {
                    ErrorToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (!string.IsNullOrWhiteSpace(clienteIdTextBox.Text))
            {
                int id = Utilidad.ToInt(clienteIdTextBox.Text);
                Entidades.Cliente cliente = BLL.ClienteBLL.Buscar(C => C.ClienteId == id);
                Limpiar();
                if (cliente != null)
                {
                    clienteIdTextBox.Text = cliente.ClienteId.ToString();
                    nombreTextBox.Text = cliente.Nombre;
                    cedulaMaskedTextBox.Text = cliente.Cedula;
                    sexoComboBox.Text = cliente.Sexo;
                    telefonoMaskedTextBox.Text = cliente.Telefono;
                    direccionTextBox.Text = cliente.Direccion;
                    fechaNacimientoDateTimePicker.Value = cliente.FechaNacimiento;
                    emailTextBox.Text = cliente.Email;
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (string.IsNullOrWhiteSpace(clienteIdTextBox.Text))
            {
                eliminarButton.Enabled = false;
            }
            else
            {
                eliminarButton.Enabled = true;
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            nombreErrorProvider.Clear();
        }

        private void cedulaMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            PonerEstadosInvisibles();
            cedulaErrorProvider.Clear();
        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void telefonoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            PonerEstadosInvisibles();
            telefonoErrorProvider.Clear();
        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            direccionErrorProvider.Clear();
        }

        private void fechaNacimientoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            emailErrorProvider.Clear();
        }

        private void FrmRegistroClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
