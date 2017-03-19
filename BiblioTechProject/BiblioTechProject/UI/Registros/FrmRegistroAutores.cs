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

        public FrmRegistroAutores()
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
            LimpiarLibro();
            RefrescarDataViewGrid();
            autorIdTextBox.Clear();
            nombreTextBox.Clear();
            libroIdTextBox.Clear();
        }

        private void LimpiarLibro()
        {
            libro = null;
            //libroIdTextBox.Clear();
            libroTituloTextBox.Clear();
            libroEdicionTextBox.Clear();
            libroEditorialTextBox.Clear();
            libroIdTextBox.Focus();
        }

        private void RefrescarDataViewGrid()
        {
            librosDataGridView.DataSource = null;
            librosDataGridView.DataSource = listaLibros;
            librosDataGridView.Columns["EditorialId"].Visible = false;
            librosDataGridView.Columns["UsuarioId"].Visible = false;
            librosDataGridView.Columns["UltimoUsuarioEnModificar"].Visible = false;
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
            autor = new Entidades.Autor(id, nombreTextBox.Text, FrmLogin.GetUsuarioLogueado().UsuarioId);
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
                    //listaLibros = new List<Entidades.Libro>();
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
                libro = BLL.LibroBLL.Buscar(L => L.LibroId == id);
                if (libro != null)
                {
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
                autor = BLL.AutorBLL.Guardar(autor); //lo igualo por si retorna null, aunque la instancia cuando vuelve de guardarse viene con su id incluido
                bool relacionesGuardadas = false;
                if (autor != null)
                {
                    relacionesGuardadas = true;
                    foreach (var relacion in listaRelaciones)
                    {
                        relacion.AutorId = autor.AutorId;
                        if (AutorLibroBLL.Guardar(relacion) == null)
                        {
                            relacionesGuardadas = false;
                            break;
                        }
                    }
                }                    
                if (relacionesGuardadas)
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
                if (!listaLibros.Contains(libro))
                {
                    listaLibros.Add(libro);
                    listaRelaciones.Add(new Entidades.AutorLibro(0, 0, libro.LibroId));
                    RefrescarDataViewGrid();
                }
            }
            else
            {
                MessageBox.Show("Ningún libro seleccionado...");
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
            PonerEstadosInvisibles();
        }

        private void autorIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Buscar();
            }
        }

        private void FrmRegistroAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
