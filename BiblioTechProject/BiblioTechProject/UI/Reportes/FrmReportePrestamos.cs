
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
    public partial class FrmReportePrestamos : Form
    {
        private static FrmReportePrestamos formulario = null;

        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        public static FrmReportePrestamos GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReportePrestamos();
            }
            return formulario;
        }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmReportePrestamos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
