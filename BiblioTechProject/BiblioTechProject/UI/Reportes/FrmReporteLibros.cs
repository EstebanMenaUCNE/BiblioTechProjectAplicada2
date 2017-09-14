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
    public partial class FrmReporteLibros : Form
    {
        private static FrmReporteLibros formulario = null;

        private FrmReporteLibros()
        {
            InitializeComponent();
        }

        public static FrmReporteLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteLibros();
            }
            return formulario;
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmReporteLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
