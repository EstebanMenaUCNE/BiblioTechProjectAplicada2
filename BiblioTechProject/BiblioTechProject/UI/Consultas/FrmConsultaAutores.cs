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
        public List<Entidades.Autor> Lista { get; set; }

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
            Lista = new List<Entidades.Autor>();
        }

        private void Filtrar()
        {
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                Lista = BLL.AutorBLL.GetList(U => U.AutorId == id);
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                Lista = BLL.AutorBLL.GetList(U => U.Nombre == filtrarTextBox.Text);
            }
            else
            {
                Lista = BLL.AutorBLL.GetList(U => U.AutorId > 0);
            }
            /*foreach (var editorial in Lista)
            {
                editorial.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == editorial.UsuarioId).Nombre;
            }*/
            autoresDataGridView.DataSource = Lista;
            //autoresDataGridView.Columns["UsuarioId"].Visible = false;
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

        private void FrmConsultaAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        
    }
}
