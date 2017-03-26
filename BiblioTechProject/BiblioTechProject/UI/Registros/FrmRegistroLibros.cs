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
    public partial class FrmRegistroLibros : Form
    {
        private static FrmRegistroLibros formulario = null;

        private Entidades.Libro libro = null;
        private List<Entidades.AutorLibro> listaRelaciones = null;
        private List<Entidades.Autor> listaAutores = null;
        private Entidades.Autor autor = null;
        private Entidades.Editorial editorial = null;

        private FrmRegistroLibros()
        {
            InitializeComponent();
        }

        public static FrmRegistroLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroLibros();
            }
            return formulario;
        }

        private void FrmRegistroLibros_Load(object sender, EventArgs e)
        {
            listaRelaciones = new List<Entidades.AutorLibro>();
            listaAutores = new List<Entidades.Autor>();
            RefrescarDataViewGrid();
            estadoComboBox.Text = "Disponible";
        }

        private void Limpiar()
        {
            libro = null;
            listaRelaciones = new List<Entidades.AutorLibro>();
            listaAutores = new List<Entidades.Autor>();
            libroIdTextBox.Clear();
            tituloTextBox.Clear();
            edicionTextBox.Clear();
            LimpiarEditorial();
            LimpiarAutor();
            RefrescarDataViewGrid();
        }

        private void LimpiarAutor()
        {
            autor = null;
            autorIdTextBox.Clear();
            autorNombreTextBox.Clear();
        }

        private void LimpiarEditorial()
        {
            autor = null;
            editorialIdTextBox.Clear();
            editorialNombreTextBox.Clear();
        }

        private void RefrescarDataViewGrid()
        {
            autoresDataGridView.DataSource = null;
            autoresDataGridView.DataSource = listaAutores;
            //autoresDataGridView.Columns["UsuarioId"].Visible = false;
            //autoresDataGridView.Columns["UltimoUsuarioEnModificar"].Visible = false;
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(tituloTextBox.Text))
            {
                tituloErrorProvider.SetError(tituloTextBox, "Digite el título");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(edicionTextBox.Text))
            {
                edicionErrorProvider.SetError(edicionTextBox, "Digite la edición");
                flag = false;
            }
            if (editorial == null)
            {
                editorialErrorProvider.SetError(editorialNombreTextBox, "Seleccione una editorial");
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (libro != null)
            {
                id = libro.LibroId;
            }
            libro = new Entidades.Libro(id, tituloTextBox.Text, Utilidad.ToInt(edicionTextBox.Text), estadoComboBox.Text, editorial.EditorialId);
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
            if (!string.IsNullOrWhiteSpace(libroIdTextBox.Text))
            {
                int id = Utilidad.ToInt(libroIdTextBox.Text);
                Limpiar();
                libro = BLL.LibroBLL.Buscar(L => L.LibroId == id);
                if (libro != null)
                {
                    libroIdTextBox.Text = libro.LibroId.ToString();
                    tituloTextBox.Text = libro.Titulo;
                    edicionTextBox.Text = libro.Edicion.ToString();
                    estadoComboBox.Text = libro.Estado;
                    editorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId);
                    editorialIdTextBox.Text = editorial.EditorialId.ToString();
                    editorialNombreTextBox.Text = editorial.Nombre;
                    listaRelaciones = AutorLibroBLL.GetList(A => A.LibroId == libro.LibroId);
                    foreach (var relacion in listaRelaciones)
                    {
                        listaAutores.Add(BLL.AutorBLL.Buscar(A => A.AutorId == relacion.AutorId));
                    }
                    RefrescarDataViewGrid();
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
                libroIdTextBox.Focus();
            }
        }

        private void BuscarAutor()
        {
            if (!string.IsNullOrWhiteSpace(autorIdTextBox.Text))
            {
                int id = Utilidad.ToInt(autorIdTextBox.Text);
                LimpiarAutor();
                autorIdTextBox.Focus();
                autor = BLL.AutorBLL.Buscar(A => A.AutorId == id);
                if (autor != null)
                {
                    autorIdTextBox.Text = autor.AutorId.ToString();
                    autorNombreTextBox.Text = autor.Nombre;
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void BuscarEditorial()
        {
            if (!string.IsNullOrWhiteSpace(editorialIdTextBox.Text))
            {
                int id = Utilidad.ToInt(editorialIdTextBox.Text);
                LimpiarEditorial();
                editorialIdTextBox.Focus();
                editorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == id);
                if (editorial != null)
                {
                    editorialIdTextBox.Text = editorial.EditorialId.ToString();
                    editorialNombreTextBox.Text = editorial.Nombre;
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
            tituloTextBox.Focus();
            PonerEstadosInvisibles();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (Validar())
            {
                LlenarCamposInstancia();
                libro = BLL.LibroBLL.Guardar(libro); //lo igualo por si retorna null, aunque la instancia cuando vuelve de guardarse viene con su id incluido
                bool relacionesGuardadas = false;
                if (libro != null)
                {
                    relacionesGuardadas = true;
                    foreach (var relacion in listaRelaciones)
                    {
                        relacion.LibroId = libro.LibroId;
                        if (AutorLibroBLL.Guardar(relacion) == null)
                        {
                            relacionesGuardadas = false;
                        }
                    }
                }
                if (relacionesGuardadas)
                {
                    libroIdTextBox.Text = libro.LibroId.ToString();
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
            if (libro != null)
            {
                DialogResult respuestaEliminar = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaEliminar == DialogResult.Yes)
                {
                    if (BLL.LibroBLL.Eliminar(libro))
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

        private void buscarAutorButton_Click(object sender, EventArgs e)
        {
            BuscarAutor();
        }

        private void buscarEditorialButton_Click(object sender, EventArgs e)
        {
            BuscarEditorial();
        }

        private void anadirAutorButton_Click(object sender, EventArgs e)
        {
            if (autor != null)
            {
                if (!listaAutores.Contains(autor))
                {
                    listaAutores.Add(autor);
                    listaRelaciones.Add(new Entidades.AutorLibro(0, autor.AutorId, 0));
                    RefrescarDataViewGrid();
                }
            }
            else
            {
                autorErrorProvider.SetError(autorNombreLabel, "Ningún autor seleccionado");
            }
        }

        private void libroIdTextBox_TextChanged_1(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void tituloTextBox_TextChanged(object sender, EventArgs e)
        {
            tituloErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void edicionTextBox_TextChanged(object sender, EventArgs e)
        {
            edicionErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void editorialIdTextBox_TextChanged(object sender, EventArgs e)
        {
            editorialErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void libroTituloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void libroIdTextBox_TextChanged(object sender, EventArgs e)
        {
            autorErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void edicionTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void libroIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void editorialIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarEditorial();
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

        private void autorIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarAutor();
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

        private void autorNombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void autorIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void editorialIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editorialIdLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void estadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistroLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
