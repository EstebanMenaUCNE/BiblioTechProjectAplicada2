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

        }

        private void FrmRegistroAutores_Load(object sender, EventArgs e)
        {
            
        }
    }
}
