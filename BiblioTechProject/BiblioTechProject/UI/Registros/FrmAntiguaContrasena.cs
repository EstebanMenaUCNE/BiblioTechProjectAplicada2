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
    public partial class FrmAntiguaContrasena : Form
    {
        private static FrmAntiguaContrasena formulario = null;
        public Entidades.Usuario Usuario { get; set; }
        public bool ContrasenaAcertada { get; set; }

        private FrmAntiguaContrasena(Entidades.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            ContrasenaAcertada = false;
        }

        public static FrmAntiguaContrasena GetInstance(Entidades.Usuario usuario)
        {
            if (formulario == null)
            {
                formulario = new FrmAntiguaContrasena(usuario);
            }
            return formulario;
        }

        public static void CloseForm()
        {
            formulario = null;
        } 

        private void FrmAntiguaContrasena_Load(object sender, EventArgs e)
        {

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(contrasenaTextBox.Text))
            {
                if (contrasenaTextBox.Text == Usuario.Contrasena)
                {
                    ContrasenaAcertada = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta...");
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            ContrasenaAcertada = false;
            this.Hide();
        }

        private void FrmAntiguaContrasena_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
