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
        private static FrmMenu formulario = null;

        private FrmMenu()
        {
            InitializeComponent();
        }

        public static FrmMenu GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmMenu();
            }
            return formulario;
        }

        private void LlenarLabelsUsuario()
        {
            nombreUsuarioLabel.Text = FrmLogin.GetUsuarioLogueado().Nombre;
            cargoUsuarioLabel.Text = FrmLogin.GetUsuarioLogueado().Cargo;
        }

        private void DesabilitarNoAdmin()
        {
            if (FrmLogin.GetUsuarioLogueado().Cargo == "Consultor")
            {
                registrosToolStripMenuItem.Enabled = false;
            }
            else
            {
                registrosToolStripMenuItem.Enabled = true;
                if (FrmLogin.GetUsuarioLogueado().Cargo == "Bibliotecario")
                {
                    usuariosToolStripMenuItem.Enabled = false;
                }
                else
                {
                    usuariosToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
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
            Registros.FrmRegistroUsuarios.GetInstance().Show();
            Registros.FrmRegistroUsuarios.GetInstance().Activate();
        }

        private void FrmMenu_VisibleChanged(object sender, EventArgs e)
        {
            LlenarLabelsUsuario();
            DesabilitarNoAdmin();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaUsuarios.GetInstance().Show();
            Consultas.FrmConsultaUsuarios.GetInstance().Activate();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.FrmRegistroClientes.GetInstance().Show();
            Registros.FrmRegistroClientes.GetInstance().Activate();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaClientes.GetInstance().Show();
            Consultas.FrmConsultaClientes.GetInstance().Activate();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Registros.FrmRegistroAutores.GetInstance().Show();
            Registros.FrmRegistroAutores.GetInstance().Activate();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.FrmRegistroEditoriales.GetInstance().Show();
            Registros.FrmRegistroEditoriales.GetInstance().Activate();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaAutores.GetInstance().Show();
            Consultas.FrmConsultaAutores.GetInstance().Activate();
        }

        private void editorialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaEditoriales.GetInstance().Show();
            Consultas.FrmConsultaEditoriales.GetInstance().Activate();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.FrmRegistroLibros.GetInstance().Show();
            Registros.FrmRegistroLibros.GetInstance().Activate();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaLibros.GetInstance().Show();
            Consultas.FrmConsultaLibros.GetInstance().Activate();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.FrmRegistroPrestamos.GetInstance().Show();
            Registros.FrmRegistroPrestamos.GetInstance().Activate();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.FrmConsultaPrestamos.GetInstance().Show();
            Consultas.FrmConsultaPrestamos.GetInstance().Activate();
        }
    }
}
