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
    public partial class FrmConsultaUsuarios : Form
    {
        private static FrmConsultaUsuarios formulario = null;
        public List<Entidades.Usuario> Lista { get; set; }

        private FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        public static FrmConsultaUsuarios GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaUsuarios();
            }
            return formulario;
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
            Lista = new List<Entidades.Usuario>();
        }

        private void Filtrar()
        {
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                Lista = BLL.UsuarioBLL.GetList(U => U.UsuarioId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                Lista = BLL.UsuarioBLL.GetList(U => U.Nombre == filtrarTextBox.Text);
            }
            else
            {
                Lista = BLL.UsuarioBLL.GetList(U => U.UsuarioId > 0);
            }
            
            usuariosDataGridView.DataSource = Lista;
            usuariosDataGridView.Columns["Contrasena"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteUsuarios.GetInstance().Show();
            Reportes.FrmReporteUsuarios.GetInstance().Activate();
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

        private void FrmConsultaUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        
    }
}
