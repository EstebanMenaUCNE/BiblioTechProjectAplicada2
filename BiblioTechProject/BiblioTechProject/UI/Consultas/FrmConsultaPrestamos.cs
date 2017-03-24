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
    public partial class FrmConsultaPrestamos : Form
    {
        private static FrmConsultaPrestamos formulario = null;

        private FrmConsultaPrestamos()
        {
            InitializeComponent();
        }

        public static FrmConsultaPrestamos GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaPrestamos();
            }
            return formulario;
        }

        private void FrmConsultaPrestamos_Load(object sender, EventArgs e)
        {
            filtrarMaskedTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
            desdeDateTimePicker.Enabled = false;
            hastaDateTimePicker.Enabled = false;
        }

        private void Filtrar()
        {
            List<Entidades.Prestamo> lista = null;
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarMaskedTextBox.Text);
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.PrestamoId == id && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                }
                else
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.PrestamoId == id);
                }
            }
            else if (filtrarComboBox.Text == "Cliente Id")
            {
                int clienteId = Utilidad.ToInt(filtrarMaskedTextBox.Text);
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.ClienteId == clienteId && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                }
                else
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.ClienteId == clienteId);
                }
            }
            else if (filtrarComboBox.Text == "Nombre cliente")
            {
                lista = new List<Entidades.Prestamo>();
                Entidades.Cliente cliente = BLL.ClienteBLL.Buscar(C => C.Nombre == filtrarMaskedTextBox.Text);
                if (cliente != null)
                {
                    if (filtrarFechasCheckBox.Checked)
                    {
                        lista = BLL.PrestamoBLL.GetList(P => P.ClienteId == cliente.ClienteId && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                    }
                    else
                    {
                        lista = BLL.PrestamoBLL.GetList(P => P.ClienteId == cliente.ClienteId);
                    }
                }
                
            }
            else if (filtrarComboBox.Text == "Pendientes")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.Estado == "Pendiente" && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                }
                else
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.Estado == "Pendiente");
                }
            }
            else if (filtrarComboBox.Text == "Devueltos")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.Estado == "Devuelto" && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                }
                else
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.Estado == "Devuelto");
                }
            }
            else if (filtrarComboBox.Text == "Retrasados")
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.Estado == "Pendiente" && P.FechaEntregarAntes < DateTime.Now && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                }
                else
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.Estado == "Pendiente" && P.FechaEntregarAntes < DateTime.Now);
                }
            }
            else
            {
                if (filtrarFechasCheckBox.Checked)
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.PrestamoId > 0 && P.FechaPrestamo >= desdeDateTimePicker.Value && P.FechaPrestamo <= hastaDateTimePicker.Value);
                }
                else
                {
                    lista = BLL.PrestamoBLL.GetList(P => P.PrestamoId > 0);
                }
            }
            foreach (Entidades.Prestamo prestamo in lista)
            {
                prestamo.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == prestamo.UsuarioId).Nombre;
            }
            clientesDataGridView.DataSource = lista;
            //clientesDataGridView.Columns["UsuarioId"].Visible = false;
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
            }
            else
            {
                filtrarMaskedTextBox.Enabled = true;
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
            if (filtrarComboBox.Text == "Id" || filtrarComboBox.Text == "Cliente Id")
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Filtrar();
            }
        }
        
        private void FrmConsultaPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        private void hastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
