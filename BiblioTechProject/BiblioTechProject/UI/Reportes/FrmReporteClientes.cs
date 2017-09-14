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
    public partial class FrmReporteClientes : Form
    {
        private static FrmReporteClientes formulario = null;

        private FrmReporteClientes()
        {
            InitializeComponent();
        }

        public static FrmReporteClientes GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteClientes();
            }
            return formulario;
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmReporteClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
