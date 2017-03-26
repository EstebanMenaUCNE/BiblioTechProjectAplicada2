using BLL;
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
    public partial class FrmConsultaLibros : Form
    {
        private static FrmConsultaLibros formulario = null;
        public List<Entidades.Libro> Lista { get; set; }

        private FrmConsultaLibros()
        {
            InitializeComponent();
        }

        public static FrmConsultaLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaLibros();
            }
            return formulario;
        }

        private void FrmConsultaLibros_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
            estadosComboBox.Text = "Disponible";
            Lista = new List<Entidades.Libro>();
        }

        private void Filtrar()
        {
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                Lista = BLL.LibroBLL.GetList(U => U.LibroId == id);
            }
            else if (filtrarComboBox.Text == "Título")
            {
                Lista = BLL.LibroBLL.GetList(U => U.Titulo == filtrarTextBox.Text);
            }
            else if (filtrarComboBox.Text == "Estado")
            {
                Lista = BLL.LibroBLL.GetList(U => U.Estado == estadosComboBox.Text);
            }
            else if (filtrarComboBox.Text == "Editorial (Id)")
            {
                Lista = new List<Entidades.Libro>();
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                Entidades.Editorial editorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == id);
                if (editorial != null)
                {
                    Lista = BLL.LibroBLL.GetList(L => L.EditorialId == editorial.EditorialId);
                }
            }
            else if (filtrarComboBox.Text == "Editorial (Nombre)")
            {
                Lista = new List<Entidades.Libro>();
                Entidades.Editorial editorial = BLL.EditorialBLL.Buscar(E => E.Nombre == filtrarTextBox.Text);
                if (editorial != null)
                {
                    Lista = BLL.LibroBLL.GetList(L => L.EditorialId == editorial.EditorialId);
                }
            }
            else if (filtrarComboBox.Text == "Autor (Id)")
            {
                Lista = new List<Entidades.Libro>();
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                Entidades.Autor autor = BLL.AutorBLL.Buscar(A => A.AutorId == id);
                if (autor != null)
                {
                    List<Entidades.AutorLibro> listaRelaciones = AutorLibroBLL.GetList(R => R.AutorId == autor.AutorId);
                    foreach (var relacion in listaRelaciones)
                    {
                        Lista.Add(BLL.LibroBLL.Buscar(L => L.LibroId == relacion.LibroId));
                    }
                }
            }
            else if (filtrarComboBox.Text == "Autor (Nombre)")
            {
                Lista = new List<Entidades.Libro>();
                Entidades.Autor autor = BLL.AutorBLL.Buscar(A => A.Nombre == filtrarTextBox.Text);
                if (autor != null)
                {
                    List<Entidades.AutorLibro> listaRelaciones = AutorLibroBLL.GetList(R => R.AutorId == autor.AutorId);
                    foreach (var relacion in listaRelaciones)
                    {
                        Lista.Add(BLL.LibroBLL.Buscar(L => L.LibroId == relacion.LibroId));
                    }
                }
            }
            else
            {
                Lista = BLL.LibroBLL.GetList(U => U.LibroId > 0);
            }
            foreach (var libro in Lista)
            {
                //libro.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == libro.UsuarioId).Nombre;
                libro.NombreEditorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId).Nombre;
            }
            autoresDataGridView.DataSource = Lista;
            //autoresDataGridView.Columns["UsuarioId"].Visible = false;
            //autoresDataGridView.Columns["EditorialId"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteLibros.GetInstance().Show();
            Reportes.FrmReporteLibros.GetInstance().Activate();
        }

        private void filtrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrarComboBox.Text == "Estado")
            {
                estadosComboBox.Visible = true;
                filtrarTextBox.Visible = false;
            }
            else
            {
                estadosComboBox.Visible = false;
                filtrarTextBox.Visible = true;
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

        private void filtrarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filtrarComboBox.Text == "Id" || filtrarComboBox.Text == "Cliente (Id)" || filtrarComboBox.Text == "Autor (Id)")
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

        private void FrmConsultaLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        
    }
}
