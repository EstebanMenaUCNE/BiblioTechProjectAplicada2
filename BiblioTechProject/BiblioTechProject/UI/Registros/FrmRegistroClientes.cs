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
        private Entidades.Cliente cliente = null;

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
        }

        private bool Validar()
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
            int id = 0;
            if (cliente != null)
            {
                id = cliente.ClienteId;
            }
            cliente = new Entidades.Cliente(id, nombreTextBox.Text, cedulaMaskedTextBox.Text, sexoComboBox.Text, telefonoMaskedTextBox.Text, direccionTextBox.Text, fechaNacimientoDateTimePicker.Value, emailTextBox.Text, FrmLogin.GetUsuarioLogueado().UsuarioId);
        }

        private void PonerEstadosInvisibles()
        {
            guardadoToolStripStatusLabel.Visible = false;
            ErrorToolStripStatusLabel.Visible = false;
            noEncontradoToolStripStatusLabel.Visible = false;
            eliminadoToolStripStatusLabel.Visible = false;
        }
        
        private void Buscar()
        {
            PonerEstadosInvisibles();
            if (!string.IsNullOrWhiteSpace(clienteIdTextBox.Text))
            {
                int id = Utilidad.ToInt(clienteIdTextBox.Text);
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
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
                clienteIdTextBox.Focus();
            }
                
        }

        private void nuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            nombreTextBox.Focus();
            PonerEstadosInvisibles();
        }

        private void guardarButton_Click_1(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            //if (FrmLogin.GetUsuarioLogueado().UsuarioId > 0)
            //{
                if (Validar())
                {
                    LlenarCamposInstancia();
                    cliente = BLL.ClienteBLL.Guardar(cliente); //lo igualo por si retorna null, aunque la instancia cuando vuelve de guardarse viene con su id incluido
                    if (cliente != null)
                    {
                        clienteIdTextBox.Text = cliente.ClienteId.ToString();
                        guardadoToolStripStatusLabel.Visible = true;
                        nuevoButton.Focus();
                    }
                    else
                    {
                        ErrorToolStripStatusLabel.Visible = true;
                    }
                }                    
            /*}
            else
            {
                MessageBox.Show("Este usuario no puede guardar registros.\nCree otro usuario para realizar esta operación.", "¡Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/       
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (cliente != null)
            {
                DialogResult respuestaEliminar = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaEliminar == DialogResult.Yes)
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
            Buscar();
        }

        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void cedulaMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cedulaMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            cedulaErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void telefonoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void telefonoMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            telefonoErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {
            direccionErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void fechaNacimientoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void clienteIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys) e.KeyChar == Keys.Enter)
            {
                Buscar();
            }
        }

        private void FrmRegistroClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
                
    }
}
