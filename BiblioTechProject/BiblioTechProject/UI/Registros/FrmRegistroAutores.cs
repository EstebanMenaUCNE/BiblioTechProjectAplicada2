using BLL;
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
    public partial class FrmRegistroAutores : Form
    {
        private static FrmRegistroAutores formulario = null;

        private Entidades.Autor autor = null;
        private List<Entidades.AutorLibro> listaRelaciones = null;
        private List<Entidades.Libro> listaLibros = null;
        private Entidades.Libro libro = null;

        private FrmRegistroAutores()
        {
            InitializeComponent();
        }

        public static FrmRegistroAutores GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroAutores();
            }
            return formulario;
        }

        private void FrmRegistroAutores_Load(object sender, EventArgs e)
        {
            listaRelaciones = new List<Entidades.AutorLibro>();
            listaLibros = new List<Entidades.Libro>();
        }

        private void Limpiar()
        {
            autor = null;
            listaRelaciones = new List<Entidades.AutorLibro>();
            listaLibros = new List<Entidades.Libro>();
            autorIdTextBox.Clear();
            nombreTextBox.Clear();
            LimpiarLibro();
            RefrescarDataViewGrid();
        }

        private void LimpiarLibro()
        {
            libro = null;
            libroIdTextBox.Clear();
            libroTituloTextBox.Clear();
            libroEdicionTextBox.Clear();
            libroEditorialTextBox.Clear();
        }

        private void RefrescarDataViewGrid()
        {
            foreach (var libro in listaLibros)
            {
                libro.NombreEditorial = BLL.EditorialBLL.Buscar(L => L.EditorialId == libro.EditorialId).Nombre;
            }
            librosDataGridView.DataSource = null;
            if (listaLibros.Count > 0)
            {
                librosDataGridView.DataSource = listaLibros;
            }
            //librosDataGridView.Columns["EditorialId"].Visible = false;
            //librosDataGridView.Columns["UsuarioId"].Visible = false;
            //librosDataGridView.Columns["UltimoUsuarioEnModificar"].Visible = false;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreErrorProvider.SetError(nombreTextBox, "Digite el nombre");
                return false;
            }
            return true;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (autor != null)
            {
                id = autor.AutorId;
            }
            autor = new Entidades.Autor(id, nombreTextBox.Text);
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
            if (!string.IsNullOrWhiteSpace(autorIdTextBox.Text))
            {
                int id = Utilidad.ToInt(autorIdTextBox.Text);
                Limpiar();
                autor = BLL.AutorBLL.Buscar(C => C.AutorId == id);
                if (autor != null)
                {
                    autorIdTextBox.Text = autor.AutorId.ToString();
                    nombreTextBox.Text = autor.Nombre;
                    listaRelaciones = AutorLibroBLL.GetList(A => A.AutorId == autor.AutorId);
                    foreach (var relacion in listaRelaciones)
                    {
                        listaLibros.Add(BLL.LibroBLL.Buscar(L => L.LibroId == relacion.LibroId));
                    }
                    RefrescarDataViewGrid();
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
                autorIdTextBox.Focus();
            }
        }

        private void BuscarLibro()
        {
            if (!string.IsNullOrWhiteSpace(libroIdTextBox.Text))
            {
                int id = Utilidad.ToInt(libroIdTextBox.Text);
                LimpiarLibro();
                libroIdTextBox.Focus();
                libro = BLL.LibroBLL.Buscar(L => L.LibroId == id);
                if (libro != null)
                {
                    libroIdTextBox.Text = libro.LibroId.ToString();
                    libroTituloTextBox.Text = libro.Titulo;
                    libroEdicionTextBox.Text = libro.Edicion.ToString();
                    libro.NombreEditorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId).Nombre;
                    libroEditorialTextBox.Text = libro.NombreEditorial;
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            nombreTextBox.Focus();
            PonerEstadosInvisibles();            
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (Validar())
            {
                LlenarCamposInstancia();                  
                if (BLL.AutorBLL.Guardar(autor, listaRelaciones))
                {
                    autorIdTextBox.Text = autor.AutorId.ToString();
                    guardadoToolStripStatusLabel.Visible = true;
                    nuevoButton.Focus();
                }
                else
                {
                    ErrorToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (autor != null)
            {
                DialogResult respuestaEliminar = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaEliminar == DialogResult.Yes)
                {
                    if (BLL.AutorBLL.Eliminar(autor))
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

        private void buscarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            Buscar();
        }

        private void buscarLibroButton_Click(object sender, EventArgs e)
        {
            BuscarLibro();
        }

        private void anadirLibroButton_Click(object sender, EventArgs e)
        {
            if (libro != null)
            {
                bool estaEnLista = false;
                foreach (var libroLista in listaLibros)
                {
                    if (libro.LibroId == libroLista.LibroId)
                    {
                        estaEnLista = true;
                        break;
                    }
                }
                if (!estaEnLista)
                {
                    listaLibros.Add(libro);
                    listaRelaciones.Add(new Entidades.AutorLibro(0, 0, libro.LibroId));
                    RefrescarDataViewGrid();
                }
            }
            else
            {
                libroErrorProvider.SetError(libroTituloLabel, "Ningún libro seleccionado");
            }

        }

        private void autorIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void libroIdTextBox_TextChanged(object sender, EventArgs e)
        {
            libroErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void autorIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Buscar();
            }
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void libroIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarLibro();
            }
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void FrmRegistroAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        private void libroIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void libroEditorialLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
