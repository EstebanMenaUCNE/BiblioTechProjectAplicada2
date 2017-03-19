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
    public partial class FrmConsultaAutores : Form
    {
        private static FrmConsultaAutores formulario = null;

        private FrmConsultaAutores()
        {
            InitializeComponent();
        }

        public static FrmConsultaAutores GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaAutores();
            }
            return formulario;
        }

        private void FrmConsultaAutores_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
        }

        private void Filtrar()
        {
            List<Entidades.Autor> lista = null;
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                lista = BLL.AutorBLL.GetList(U => U.AutorId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                lista = BLL.AutorBLL.GetList(U => U.Nombre == filtrarTextBox.Text);
            }
            else
            {
                lista = BLL.AutorBLL.GetList(U => U.AutorId > 0);
            }
            foreach (var editorial in lista)
            {
                editorial.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == editorial.UsuarioId).Nombre;
            }
            autoresDataGridView.DataSource = lista;
            autoresDataGridView.Columns["UsuarioId"].Visible = false;
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
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Filtrar();
            }
        }

        private void FrmConsultaAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
