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
        private static Entidades.Cliente cliente = null;

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

        private void FrmRegistroClientes_Load(object sender, EventArgs e)
        {
            sexoComboBox.Text = "Masculino";
            DeshabilidarCamposMenosId();
        }

        private void Limpiar()
        {
            cliente = null;
            clienteIdTextBox.Clear();
            nombreTextBox.Clear();
            cedulaMaskedTextBox.Clear();
            telefonoMaskedTextBox.Clear();
            direccionTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Now;
            emailTextBox.Clear();
            DeshabilitarModificarBorrar();
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

        private void LlenarCamposInstancia()
        {
            cliente = new Entidades.Cliente(Utilidad.ToInt(clienteIdTextBox.Text), nombreTextBox.Text, cedulaMaskedTextBox.Text, sexoComboBox.Text, telefonoMaskedTextBox.Text, direccionTextBox.Text, fechaNacimientoDateTimePicker.Value, emailTextBox.Text, FrmLogin.GetUsuarioLogueado().UsuarioId);
        }

        private void PonerEstadosInvisibles()
        {
            guardadoToolStripStatusLabel.Visible = false;
            ErrorToolStripStatusLabel.Visible = false;
            noEncontradoToolStripStatusLabel.Visible = false;
            eliminadoToolStripStatusLabel.Visible = false;
        }

        private void GetClienteCampos()
        {
            cliente = new Entidades.Cliente(Utilidad.ToInt(clienteIdTextBox.Text), nombreTextBox.Text, cedulaMaskedTextBox.Text, sexoComboBox.Text, telefonoMaskedTextBox.Text, direccionTextBox.Text, fechaNacimientoDateTimePicker.Value, emailTextBox.Text, FrmLogin.GetUsuarioLogueado().UsuarioId);
        }

        private void HabilitarModificarBorrar()
        {
            eliminarButton.Enabled = true;
            modificarButton.Enabled = true;
        }

        private void DeshabilitarModificarBorrar()
        {
            eliminarButton.Enabled = false;
            modificarButton.Enabled = false;
        }

        private void HabDeshabBuscar()
        {
            if (string.IsNullOrWhiteSpace(clienteIdTextBox.Text))
            {
                buscarButton.Enabled = false;
            }
            else
            {
                buscarButton.Enabled = true;
            }
        }

        private void DeshabilidarCamposMenosId()
        {
            nombreTextBox.ReadOnly = true;
            cedulaMaskedTextBox.ReadOnly = true;
            sexoComboBox.Enabled = false;
            telefonoMaskedTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            fechaNacimientoDateTimePicker.Enabled = false;
            emailTextBox.ReadOnly = true;
        }

        private void HabilidarCamposMenosId()
        {
            nombreTextBox.ReadOnly = false;
            cedulaMaskedTextBox.ReadOnly = false;
            sexoComboBox.Enabled = true;
            telefonoMaskedTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            fechaNacimientoDateTimePicker.Enabled = true;
            emailTextBox.ReadOnly = false;
        }

        private void nuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            HabilidarCamposMenosId();
            nombreTextBox.Focus();
            PonerEstadosInvisibles();
        }

        private void guardarButton_Click_1(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (!nombreTextBox.ReadOnly)
            {
                if (validar())
                {
                    LlenarCamposInstancia();
                    cliente = BLL.ClienteBLL.Guardar(cliente); //lo igualo por si retorna null, aunque la instancia cuando vuelve de guardarse viene con su id incluido
                    if (cliente != null)
                    {
                        clienteIdTextBox.Text = cliente.ClienteId.ToString();
                        guardadoToolStripStatusLabel.Visible = true;
                        DeshabilidarCamposMenosId();
                        HabilitarModificarBorrar();
                    }
                    else
                    {
                        ErrorToolStripStatusLabel.Visible = true;
                    }
                }
            }            
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (cliente != null)
            {
                DialogResult opcionEliminar = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcionEliminar == DialogResult.Yes)
                {
                    if (BLL.ClienteBLL.Eliminar(cliente))
                    {
                        Limpiar();
                        eliminadoToolStripStatusLabel.Visible = true;
                    }
                    else
                    {
                        ErrorToolStripStatusLabel.Visible = true;
                    }
                }
            }
        }
        
        private void buscarButton_Click_1(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            int id = Utilidad.ToInt(clienteIdTextBox.Text);
            DeshabilidarCamposMenosId();
            Limpiar();
            cliente = BLL.ClienteBLL.Buscar(C => C.ClienteId == id);
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
                HabilitarModificarBorrar();
            }
            else
            {
                noEncontradoToolStripStatusLabel.Visible = true;
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            HabilidarCamposMenosId();
        }

        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            HabDeshabBuscar();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreErrorProvider.Clear();
        }

        private void cedulaMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cedulaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            cedulaErrorProvider.Clear();
        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void telefonoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void telefonoMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            telefonoErrorProvider.Clear();
        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {
            direccionErrorProvider.Clear();
        }

        private void fechaNacimientoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailErrorProvider.Clear();
        }

        private void FrmRegistroClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        
    }
}
