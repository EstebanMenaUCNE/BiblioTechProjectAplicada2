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
    public partial class FrmRegistroPrestamos : Form
    {
        private static FrmRegistroPrestamos formulario = null;

        private Entidades.Prestamo prestamo = null;
        private List<Entidades.PrestamoLibro> listaRelaciones = null;
        private List<Entidades.Libro> listaLibros = null;
        private Entidades.Libro libro = null;
        private Entidades.Cliente cliente = null;

        private FrmRegistroPrestamos()
        {
            InitializeComponent();
        }

        public static FrmRegistroPrestamos GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroPrestamos();
            }
            return formulario;
        }

        private void FrmRegistroPrestamos_Load(object sender, EventArgs e)
        {
            estadoComboBox.Text = "Pendiente";
            listaRelaciones = new List<Entidades.PrestamoLibro>();
            listaLibros = new List<Entidades.Libro>();
            RefrescarDataViewGrid();
        }

        private void Limpiar()
        {
            prestamo = null;
            listaRelaciones = new List<Entidades.PrestamoLibro>();
            listaLibros = new List<Entidades.Libro>();
            prestamoIdTextBox.Clear();
            fechaPrestamoDateTimePicker.Value = DateTime.Now;
            fechaEntregarAntesDateTimePicker.Value = DateTime.Now;
            LimpiarCliente();
            estadoComboBox.Text = "Pendiente";
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
            libroEstadoTextBox.Clear();
        }

        private void LimpiarCliente()
        {
            cliente = null;
            clienteIdTextBox.Clear();
            clienteNombreTextBox.Clear();
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
            bool flag = true;
            if (fechaPrestamoDateTimePicker.Value.Date > fechaEntregarAntesDateTimePicker.Value.Date)
            {
                fechasErrorProvider.SetError(fechaPrestamoDateTimePicker, "La fecha de prestamo no puede ser mayor a la fecha entregar antes");
                fechasErrorProvider.SetError(fechaEntregarAntesDateTimePicker, "La fecha entregar antes no puede ser menor a la fecha de prestamo");
                flag = false;
            }
            if (cliente == null)
            {
                clienteErrorProvider.SetError(clienteNombreTextBox, "Seleccione un cliente");
                flag = false;
            }
            if (listaLibros.Count == 0)
            {
                libroErrorProvider.SetError(libroTituloLabel, "Ningún libro seleccionado para el prestamo");
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            DateTime fechaPrestamo = DateTime.Now;
            DateTime fechaLibrosEntregados = DateTime.Now;
            string estado = estadoComboBox.Text;
            if (prestamo != null)
            {
                fechaPrestamo = prestamo.FechaPrestamo;
                id = prestamo.PrestamoId;
                if (prestamo.Estado == "Devuelto")
                {
                    estado = prestamo.Estado;
                    fechaLibrosEntregados = prestamo.FechaLibrosEntregados;
                }
            }
            prestamo = new Entidades.Prestamo(id, fechaPrestamo, fechaEntregarAntesDateTimePicker.Value, fechaLibrosEntregados, estado, cliente.ClienteId, FrmLogin.GetUsuarioLogueado().UsuarioId);
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
            if (!string.IsNullOrWhiteSpace(prestamoIdTextBox.Text))
            {
                int id = Utilidad.ToInt(prestamoIdTextBox.Text);
                Limpiar();
                prestamo = BLL.PrestamoBLL.Buscar(P => P.PrestamoId == id);
                if (prestamo != null)
                {
                    prestamoIdTextBox.Text = prestamo.PrestamoId.ToString();
                    fechaPrestamoDateTimePicker.Value = prestamo.FechaPrestamo;
                    fechaEntregarAntesDateTimePicker.Value = prestamo.FechaEntregarAntes;
                    estadoComboBox.Text = prestamo.Estado;
                    cliente = BLL.ClienteBLL.Buscar(C => C.ClienteId == prestamo.ClienteId);
                    clienteIdTextBox.Text = cliente.ClienteId.ToString();
                    clienteNombreTextBox.Text = cliente.Nombre;
                    listaRelaciones = PrestamoLibroBLL.GetList(R => R.PrestamoId == prestamo.PrestamoId);
                    foreach (var relacion in listaRelaciones)
                    {
                        listaLibros.Add(BLL.LibroBLL.Buscar(L => L.LibroId == relacion.LibroId));
                    }
                    foreach (var libro in listaLibros)
                    {
                        libro.NombreEditorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId).Nombre;
                    }
                    RefrescarDataViewGrid();
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
                prestamoIdTextBox.Focus();
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
                    libroEstadoTextBox.Text = libro.Estado;
                    libro.NombreEditorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId).Nombre;
                    libroEditorialTextBox.Text = libro.NombreEditorial;
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void BuscarCliente()
        {
            if (!string.IsNullOrWhiteSpace(clienteIdTextBox.Text))
            {
                int id = Utilidad.ToInt(clienteIdTextBox.Text);
                LimpiarCliente();
                clienteIdTextBox.Focus();
                cliente = BLL.ClienteBLL.Buscar(C => C.ClienteId == id);
                if (cliente != null)
                {
                    clienteIdTextBox.Text = cliente.ClienteId.ToString();
                    clienteNombreTextBox.Text = cliente.Nombre;
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
            fechaPrestamoDateTimePicker.Focus();
            PonerEstadosInvisibles();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (Validar())
            {
                string estadoAntesModificar = "";
                if (prestamo != null)
                {
                    estadoAntesModificar = prestamo.Estado;
                }
                LlenarCamposInstancia();
                prestamo = BLL.PrestamoBLL.Guardar(prestamo); //lo igualo por si retorna null, aunque la instancia cuando vuelve de guardarse viene con su id incluido
                bool relacionesGuardadas = false;
                if (prestamo != null)
                {
                    relacionesGuardadas = true;                    
                    foreach (var relacion in listaRelaciones)
                    {
                        relacion.PrestamoId = prestamo.PrestamoId;
                        if (PrestamoLibroBLL.Guardar(relacion) == null)
                        {
                            relacionesGuardadas = false;
                        }
                    }
                    //Poner estados de los libros como "Prestado" o "Disponible"
                    if (estadoAntesModificar == "Devuelto")
                    {
                        estadoComboBox.Text = "Devuelto";
                    }
                    else if (estadoAntesModificar == "Pendiente" && prestamo.Estado == "Devuelto")
                    {
                        foreach (var libro in listaLibros)
                        {
                            libro.Estado = "Disponible";
                            BLL.LibroBLL.Guardar(libro);
                        }
                    }
                    else
                    {
                        foreach (var libro in listaLibros)
                        {
                            libro.Estado = "Prestado";
                            BLL.LibroBLL.Guardar(libro);
                        }
                    }
                    RefrescarDataViewGrid();
                }
                if (relacionesGuardadas)
                {
                    prestamoIdTextBox.Text = prestamo.PrestamoId.ToString();
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
            if (prestamo != null)
            {
                DialogResult respuestaEliminar = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaEliminar == DialogResult.Yes)
                {
                    bool relacionesEliminadas = true;
                    bool prestamoEliminado = false;
                    foreach (var relacion in listaRelaciones)
                    {
                        if (!PrestamoLibroBLL.Eliminar(relacion))
                        {
                            relacionesEliminadas = false;
                        }
                    }
                    if (relacionesEliminadas)
                    {
                        prestamoEliminado = BLL.PrestamoBLL.Eliminar(prestamo);
                    }
                    if (prestamoEliminado)
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

        private void buscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void anadirLibroButton_Click(object sender, EventArgs e)
        {
            if (libro != null)
            {
                if (libro.Estado == "Disponible")
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
                        listaRelaciones.Add(new Entidades.PrestamoLibro(0, 0, libro.LibroId));
                        RefrescarDataViewGrid();
                    }
                }
                else
                {
                    libroErrorProvider.SetError(libroTituloLabel, "El libro está " + libro.Estado);
                }
            }
            else
            {
                libroErrorProvider.SetError(libroTituloLabel, "Ningún libro seleccionado");
            }
        }

        private void prestamoIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void fechaPrestamoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fechasErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void fechaEntregarAntesDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fechasErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void clienteIdTextBox_TextChanged(object sender, EventArgs e)
        {
            clienteErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void libroIdTextBox_TextChanged(object sender, EventArgs e)
        {
            libroErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void librosGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void prestamoIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void clienteIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarCliente();
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

        private void FrmRegistroPrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }

        
    }
}
