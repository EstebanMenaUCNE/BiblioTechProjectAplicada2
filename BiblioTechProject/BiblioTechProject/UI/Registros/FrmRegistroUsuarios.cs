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
    public partial class FrmRegistroUsuarios : Form
    {
        private static FrmRegistroUsuarios formulario = null;

        private FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        public static FrmRegistroUsuarios GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroUsuarios();
            }
            return formulario;
        }

        private void Limpiar()
        {
            usuarioIdTextBox.Clear();
            nombreTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            contrasenaTextBox.Clear();
            confirmarContrasenaTextBox.Clear();
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreErrorProvider.SetError(nombreTextBox, "Digite el nombre");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(nombreUsuarioTextBox.Text))
            {
                usuarioErrorProvider.SetError(nombreUsuarioTextBox, "Digite el nombre de usuario");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(contrasenaTextBox.Text))
            {
                contrasenaErrorProvider.SetError(contrasenaTextBox, "Digite la contraseña");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(confirmarContrasenaTextBox.Text))
            {
                confirmarContrasenaErrorProvider.SetError(confirmarContrasenaTextBox, "Confirme la contraseña");
                flag = false;
            }
            else if(confirmarContrasenaTextBox.Text != contrasenaTextBox.Text)
            {
                confirmarContrasenaErrorProvider.SetError(confirmarContrasenaTextBox, "Las contraseñas no coinciden");
                flag = false;
            }
            return flag;
        }

        private void PonerEstadosInvisibles()
        {
            guardadoToolStripStatusLabel.Visible = false;
            ErrorToolStripStatusLabel.Visible = false;
            noEncontradoToolStripStatusLabel.Visible = false;
            eliminadoToolStripStatusLabel.Visible = false;
        }

        private Entidades.Usuario GetUsuarioCampos()
        {
            return new Entidades.Usuario(Utilidad.ToInt(usuarioIdTextBox.Text), nombreTextBox.Text, nombreUsuarioTextBox.Text, contrasenaTextBox.Text, cargoComboBox.Text);
        }

        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            eliminarButton.Enabled = false;
            cargoComboBox.Text = "Bibliotecario";
        }

        private void cargoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            nombreTextBox.Focus();
            PonerEstadosInvisibles();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (!string.IsNullOrWhiteSpace(usuarioIdTextBox.Text))
            {
                Entidades.Usuario usuario = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == Utilidad.ToInt(usuarioIdTextBox.Text));
                if (usuario != null)
                {
                    if (BLL.UsuarioBLL.Eliminar(usuario))
                    {
                        eliminadoToolStripStatusLabel.Visible = true;
                    }
                    else
                    {
                        ErrorToolStripStatusLabel.Visible = true;
                    }
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (Validar())
            {
                if(BLL.UsuarioBLL.Guardar(GetUsuarioCampos()))
                {
                    guardadoToolStripStatusLabel.Visible = true;
                }
                else
                {
                    ErrorToolStripStatusLabel.Visible = true;
                }
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (!string.IsNullOrWhiteSpace(usuarioIdTextBox.Text))
            {
                int id = Utilidad.ToInt(usuarioIdTextBox.Text);
                Entidades.Usuario usuario = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == id);
                Limpiar();
                if (usuario != null)
                {
                    usuarioIdTextBox.Text = usuario.UsuarioId.ToString();
                    nombreTextBox.Text = usuario.Nombre;
                    nombreUsuarioTextBox.Text = usuario.NombreUsuario;
                    cargoComboBox.Text = usuario.Cargo;
                }
                else
                {
                    noEncontradoToolStripStatusLabel.Visible = true;
                }
            }
            
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void nombreUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            usuarioErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void contrasenaTextBox_TextChanged(object sender, EventArgs e)
        {
            contrasenaErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void confirmarContrasenaTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmarContrasenaErrorProvider.Clear();
            PonerEstadosInvisibles();
        }

        private void usuarioIdTextBox_TextChanged(object sender, EventArgs e)
        {
            PonerEstadosInvisibles();
            if (usuarioIdTextBox.Text == "")
            {
                eliminarButton.Enabled = false;
            }
            else
            {
                eliminarButton.Enabled = true;
            }
        }

        private void RegistroUsuariosStatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmRegistroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
