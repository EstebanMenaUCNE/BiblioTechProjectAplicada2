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
    public partial class FrmMenu : Form
    {
        private static FrmMenu formulario = new FrmMenu();

        private FrmMenu()
        {
            InitializeComponent();
        }

        public static FrmMenu GetInstance()
        {
            return formulario;
        }

        private void LlenarLabelsUsuario()
        {
            nombreUsuarioLabel.Text = FrmLogin.GetUsuarioLogueado().Nombre;
            cargoUsuarioLabel.Text = FrmLogin.GetUsuarioLogueado().Cargo;
        }

        private void DesabilitarNoAdmin()
        {
            if (FrmLogin.GetUsuarioLogueado().Cargo != "Administrador")
            {
                usuariosToolStripMenuItem.Enabled = false;
            }
            else
            {
                usuariosToolStripMenuItem.Enabled = true;
            }

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LlenarLabelsUsuario();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin.GetInstance().Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Registros.FrmRegistroUsuarios().Show();
        }
    }
}
