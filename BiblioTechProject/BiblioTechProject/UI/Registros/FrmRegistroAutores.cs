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
        public FrmRegistroAutores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            autorIdTextBox.Clear();
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

        private void PonerEstadosInvisibles()
        {
            guardadoToolStripStatusLabel.Visible = false;
            ErrorToolStripStatusLabel.Visible = false;
            noEncontradoToolStripStatusLabel.Visible = false;
            eliminadoToolStripStatusLabel.Visible = false;
        }

        /* Entidades.Autor GetAutorCampos()
        {
            //return new Entidades.Autor(Utilidad.ToInt(autorIdTextBox.Text), nombreTextBox);
            //Hay que hacer uno global
        }*/

        private void FrmRegistroAutores_Load(object sender, EventArgs e)
        {
            
        }
    }
}
