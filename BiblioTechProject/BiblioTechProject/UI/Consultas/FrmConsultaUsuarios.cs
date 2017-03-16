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

        private void Filtrar()
        {
            List<Entidades.Usuario> lista = null;
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                lista = BLL.UsuarioBLL.GetList(U => U.UsuarioId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                lista = BLL.UsuarioBLL.GetList(U => U.Nombre == filtrarTextBox.Text);
            }
            else
            {
                lista = BLL.UsuarioBLL.GetList(U => U.UsuarioId > 0);
            }
            
            usuariosDataGridView.DataSource = lista;
            usuariosDataGridView.Columns["Contrasena"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
        }

        private void FrmConsultaUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
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
    }
}
