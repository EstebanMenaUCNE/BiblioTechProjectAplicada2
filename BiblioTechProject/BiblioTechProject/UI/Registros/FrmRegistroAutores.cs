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

        //Falta detalle

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
            DeshabilidarCamposMenosId();
        }

        private void Limpiar()
        {
            autor = null;
            autorIdTextBox.Clear();
            nombreTextBox.Clear();
            DeshabilitarModificarBorrar();
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

        private void HabilitarModificarBorrar()
        {
            eliminarButton.Enabled = true;
            modificarButton.Enabled = true;
        }

        private void DeshabilitarModificarBorrar()
        {
            eliminarButton.Enabled = false;
            modificarButton.Enabled = false;
        }

        private void HabDeshabBuscar()
        {
            if (string.IsNullOrWhiteSpace(autorIdTextBox.Text))
            {
                buscarButton.Enabled = false;
            }
            else
            {
                buscarButton.Enabled = true;
            }
        }

        private void DeshabilidarCamposMenosId()
        {
            nombreTextBox.ReadOnly = true;
        }

        private void HabilidarCamposMenosId()
        {
            nombreTextBox.ReadOnly = false;
        }

        private void Buscar()
        {
            PonerEstadosInvisibles();
            int id = Utilidad.ToInt(autorIdTextBox.Text);
            DeshabilidarCamposMenosId();
            Limpiar();
            autor = BLL.AutorBLL.Buscar(C => C.AutorId == id);
            if (autor != null)
            {
                autorIdTextBox.Text = autor.AutorId.ToString();
                nombreTextBox.Text = autor.Nombre;
                HabilitarModificarBorrar();
            }
            else
            {
                noEncontradoToolStripStatusLabel.Visible = true;
            }
            autorIdTextBox.Focus();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilidarCamposMenosId();
            nombreTextBox.Focus();
            PonerEstadosInvisibles();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (!nombreTextBox.ReadOnly)
            {
                if (FrmLogin.GetUsuarioLogueado().UsuarioId > 0)
                {
                    if (Validar())
                    {
                        LlenarCamposInstancia();
                        autor = BLL.AutorBLL.Guardar(autor); //lo igualo por si retorna null, aunque la instancia cuando vuelve de guardarse viene con su id incluido
                        if (autor != null)
                        {
                            autorIdTextBox.Text = autor.AutorId.ToString();
                            guardadoToolStripStatusLabel.Visible = true;
                            DeshabilidarCamposMenosId();
                            HabilitarModificarBorrar();
                            nuevoButton.Focus();
                        }
                        else
                        {
                            ErrorToolStripStatusLabel.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario no puede guardar registros.\nCree otro usuario para realizar esta operación.", "¡Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Buscar();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            HabilidarCamposMenosId();
        }

        private void autorIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            HabDeshabBuscar();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreErrorProvider.Clear();
        }

        private void autorIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter && buscarButton.Enabled == true)
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
