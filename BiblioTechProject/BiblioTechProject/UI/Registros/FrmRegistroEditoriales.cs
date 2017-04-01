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
    public partial class FrmRegistroEditoriales : Form
    {
        private static FrmRegistroEditoriales formulario = null;
        private Entidades.Editorial editorial = null;

        private FrmRegistroEditoriales()
        {
            InitializeComponent();
        }

        public static FrmRegistroEditoriales GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroEditoriales();
            }
            return formulario;
        }

        private void FrmRegistroEditoriales_Load(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        {
            editorial = null;
            editorialIdTextBox.Clear();
            nombreTextBox.Clear();
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
            if (editorial != null)
            {
                id = editorial.EditorialId;
            }
            editorial = new Entidades.Editorial(id, nombreTextBox.Text);
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
            PonerEstadosInvisibles();
            if (!string.IsNullOrWhiteSpace(editorialIdTextBox.Text))
            {
                int id = Utilidad.ToInt(editorialIdTextBox.Text);
                Limpiar();
                editorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == id);
                if (editorial != null)
                {
                    editorialIdTextBox.Text = editorial.EditorialId.ToString();
                    nombreTextBox.Text = editorial.Nombre;
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
                editorialIdTextBox.Focus();
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
                if (BLL.EditorialBLL.Guardar(editorial))
                {
                    editorialIdTextBox.Text = editorial.EditorialId.ToString();
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
            if (editorial != null)
            {
                DialogResult respuestaEliminar = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado? \nNota: Si borra esta editorial también se borrarán\ntodos los libros de ésta.", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaEliminar == DialogResult.Yes)
                {
                    if (BLL.EditorialBLL.Eliminar(editorial))
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

        private void editorialIdTextBox_TextChanged_1(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void editorialIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void editorialsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void editorialesLibrosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistroEditoriales_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
