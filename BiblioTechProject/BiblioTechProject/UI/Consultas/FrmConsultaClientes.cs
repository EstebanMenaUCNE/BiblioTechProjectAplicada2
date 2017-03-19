using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI.Consultas
{
    public partial class FrmConsultaClientes : Form
    {
        private static FrmConsultaClientes formulario = null;

        private FrmConsultaClientes()
        {
            InitializeComponent();
        }

        public static FrmConsultaClientes GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaClientes();
            }
            return formulario;
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {
            filtrarMaskedTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
            desdeDateTimePicker.Enabled = false;
            hastaDateTimePicker.Enabled = false;
        }

        private void Filtrar()
        {
            List<Entidades.Cliente> lista = null;
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarMaskedTextBox.Text);
                lista = BLL.ClienteBLL.GetList(C => C.ClienteId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Nombre == filtrarMaskedTextBox.Text && C.FechaNacimiento >= desdeDateTimePicker.Value.Date && C.FechaNacimiento <= hastaDateTimePicker.Value.Date);
                }
                else
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Nombre == filtrarMaskedTextBox.Text);
                }
            }
            else if (filtrarComboBox.Text == "Cédula")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Cedula == filtrarMaskedTextBox.Text && C.FechaNacimiento >= desdeDateTimePicker.Value.Date && C.FechaNacimiento <= hastaDateTimePicker.Value.Date);
                }
                else
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Cedula == filtrarMaskedTextBox.Text);
                }
            }
            else if (filtrarComboBox.Text == "Teléfono")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Telefono == filtrarMaskedTextBox.Text && C.FechaNacimiento >= desdeDateTimePicker.Value.Date && C.FechaNacimiento <= hastaDateTimePicker.Value.Date);
                }
                else
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Telefono == filtrarMaskedTextBox.Text);
                }
            }
            else if (filtrarComboBox.Text == "Email")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Email == filtrarMaskedTextBox.Text && C.FechaNacimiento >= desdeDateTimePicker.Value.Date && C.FechaNacimiento <= hastaDateTimePicker.Value.Date);
                }
                else
                {
                    lista = BLL.ClienteBLL.GetList(C => C.Email == filtrarMaskedTextBox.Text);
                }
                    
            }
            else
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.ClienteBLL.GetList(C => C.FechaNacimiento >= desdeDateTimePicker.Value.Date && C.FechaNacimiento <= hastaDateTimePicker.Value.Date);
                }
                else
                {
                    lista = BLL.ClienteBLL.GetList(C => C.ClienteId > 0);
                }
                    
            }
            foreach (Entidades.Cliente cliente in lista)
            {
                cliente.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == cliente.UsuarioId).Nombre;
            }
            clientesDataGridView.DataSource = lista;
            clientesDataGridView.Columns["UsuarioId"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void filtrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarMaskedTextBox.Clear();
            if (filtrarComboBox.Text == "Todo")
            {
                filtrarMaskedTextBox.Enabled = false;
                filtrarMaskedTextBox.Mask = "";
            }
            else
            {
                filtrarMaskedTextBox.Enabled = true;
                filtrarMaskedTextBox.Focus();
                if (filtrarComboBox.Text == "Cédula")
                {
                    filtrarMaskedTextBox.Mask = "999-9999999-9";
                }
                else if (filtrarComboBox.Text == "Teléfono")
                {
                    filtrarMaskedTextBox.Mask = "(999)-999-9999";
                }
                else
                {
                    filtrarMaskedTextBox.Mask = "";
                }
            }
        }
        
        private void filtrarFechasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filtrarFechasCheckBox.Checked)
            {
                desdeDateTimePicker.Enabled = true;
                hastaDateTimePicker.Enabled = true;
            }
            else
            {
                desdeDateTimePicker.Enabled = false;
                hastaDateTimePicker.Enabled = false;
            }
        }

        private void filtrarMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Filtrar();
            }
        }

        private void FrmConsultaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
                
    }
}
