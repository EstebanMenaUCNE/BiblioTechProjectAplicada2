using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI.Reportes
{
    public partial class FrmReporteAutores : Form
    {
        private static FrmReporteAutores formulario = null;

        private FrmReporteAutores()
        {
            InitializeComponent();
        }

        public static FrmReporteAutores GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteAutores();
            }
            return formulario;
        }

        private void FrmReporteAutores_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmReporteAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
