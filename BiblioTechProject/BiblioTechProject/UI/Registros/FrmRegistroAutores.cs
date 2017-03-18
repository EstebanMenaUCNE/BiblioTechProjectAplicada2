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
        private static FrmRegistroAutores formulario = null;
        private static Entidades.Autor autor = null;

        public FrmRegistroAutores()
        {
            InitializeComponent();
        }

        public static FrmRegistroAutores GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmRegistroAutores();
            }
            return formulario;
        }

        private void FrmRegistroAutores_Load(object sender, EventArgs e)
        {
            DeshabilidarCamposMenosId();
        }

        private void Limpiar()
        {
            autor = null;
            autorIdTextBox.Clear();
            nombreTextBox.Clear();
            DeshabilitarModificarBorrar();
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

        private void LlenarCamposInstancia()
        {
            autor = new Entidades.Autor(Utilidad.ToInt(autorIdTextBox.Text), nombreTextBox.Text, FrmLogin.GetUsuarioLogueado().UsuarioId);
        }



    }
}
