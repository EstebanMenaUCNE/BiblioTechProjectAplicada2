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
    public partial class FrmReporteUsuarios : Form
    {
        private static FrmReporteUsuarios formulario = null;

        private FrmReporteUsuarios()
        {
            InitializeComponent();
        }

        public static FrmReporteUsuarios GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteUsuarios();
            }
            return formulario;
        }

        private void FrmReporteUsuarios_Load(object sender, EventArgs e)
        {            
            
        }

        private void FrmReporteUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
