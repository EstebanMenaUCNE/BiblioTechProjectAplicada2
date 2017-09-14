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
        public List<Entidades.Editorial> Lista { get; set; }

        private FrmConsultaEditoriales()
        {
            InitializeComponent();
        }

        private void FrmConsultaEditoriales_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
            Lista = new List<Entidades.Editorial>();
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
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                Lista = BLL.EditorialBLL.GetList(U => U.EditorialId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                Lista = BLL.EditorialBLL.GetList(U => U.Nombre == filtrarTextBox.Text);
            }
            else
            {
                Lista = BLL.EditorialBLL.GetList(U => U.EditorialId > 0);
            }
            /*foreach (var editorial in Lista)
            {
                editorial.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == editorial.UsuarioId).Nombre;
            }*/
            editorialesDataGridView.DataSource = Lista;
            //editorialesDataGridView.Columns["UsuarioId"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            
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
