using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI
{
    public partial class FrmLogin : Form
    {
        private static Entidades.Usuario UsuarioLogueado = null;
        private static FrmLogin formulario = null;

        private FrmLogin()
        {
            InitializeComponent();
        }

        public static FrmLogin GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmLogin();
            }
            return formulario;
        }

        public static Entidades.Usuario GetUsuarioLogueado()
        {
            return UsuarioLogueado;
        }

        private void Limpiar()
        {
            usuarioTextBox.Clear();
            contrasenaTextBox.Clear();
            usuarioTextBox.Focus();
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                usuarioErrorProvider.SetError(usuarioTextBox, "Digite el nombre de usuario");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(contrasenaTextBox.Text))
            {
                contrasenaErrorProvider.SetError(contrasenaTextBox, "Digite la contraseña");
                flag = false;
            }
            return flag;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            if (Validar())
            {
                Entidades.Usuario usuario = null;
                if (usuarioTextBox.Text == "root")
                {
                    usuario = new Entidades.Usuario(1, "Admin", "root", "1", "Administrador");
                    BLL.UsuarioBLL.Guardar(usuario);
                }
                else
                {
                    usuario = BLL.UsuarioBLL.Buscar(U => U.NombreUsuario == usuarioTextBox.Text);
                }
                if (usuario != null)
                {
                    if (contrasenaTextBox.Text == usuario.Contrasena)
                    {
                        Limpiar();
                        UsuarioLogueado = usuario;
                        this.Hide();
                        FrmMenu.GetInstance().Show();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta...");
                        contrasenaTextBox.Clear();
                        contrasenaTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe...");
                    contrasenaTextBox.Clear();
                    usuarioTextBox.Focus();
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void SalirButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            usuarioErrorProvider.Clear();
        }

        private void contrasenaTextBox_TextChanged(object sender, EventArgs e)
        {
            contrasenaErrorProvider.Clear();
        }

        private void usuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                contrasenaTextBox.Focus();
            }
        }

        private void contrasenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Login();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
