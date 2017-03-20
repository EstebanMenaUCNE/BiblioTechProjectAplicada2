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
    public partial class FrmConsultaEditoriales : Form
    {
        private static FrmConsultaEditoriales formulario = null;

        private FrmConsultaEditoriales()
        {
            InitializeComponent();
        }

        private void FrmConsultaEditoriales_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
        }

        public static FrmConsultaEditoriales GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaEditoriales();
            }
            return formulario;
        }

        private void Filtrar()
        {
            List<Entidades.Editorial> lista = null;
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                lista = BLL.EditorialBLL.GetList(U => U.EditorialId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                lista = BLL.EditorialBLL.GetList(U => U.Nombre == filtrarTextBox.Text);
            }
            else
            {
                lista = BLL.EditorialBLL.GetList(U => U.EditorialId > 0);
            }
            foreach (var editorial in lista)
            {
                editorial.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == editorial.UsuarioId).Nombre;
            }
            editorialesDataGridView.DataSource = lista;
            editorialesDataGridView.Columns["UsuarioId"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void filtrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrarComboBox.Text == "Todo")
            {
                filtrarTextBox.Clear();
                filtrarTextBox.Enabled = false;
            }
            else
            {
                filtrarTextBox.Enabled = true;
                filtrarTextBox.Focus();
            }
        }

        private void filtrarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filtrarComboBox.Text == "Id")
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

        private void FrmConsultaEditoriales_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        
    }
}
