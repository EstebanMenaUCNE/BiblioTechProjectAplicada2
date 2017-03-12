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
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            usuarioIdTextBox.Clear();
            nombreTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            contrasenaTextBox.Clear();
            nombreTextBox.Focus();
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreErrorProvider.SetError(nombreTextBox, "Digite el nombre");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(nombreUsuarioTextBox.Text))
            {
                usuarioErrorProvider.SetError(nombreUsuarioTextBox, "Digite el nombre de usuario");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(contrasenaTextBox.Text))
            {
                contrasenaErrorProvider.SetError(contrasenaTextBox, "Digite la contraseña");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(cargoComboBox.ValueMember))
            {
                nombreErrorProvider.SetError(cargoComboBox, "Seleccione el cargo");
                flag = false;
            }
            return flag;
        }

        private Entidades.Usuario GetUsuarioCampos()
        {
            return new Entidades.Usuario(usuarioIdTextBox.Text);
        }

        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void cargoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(BLL.UsuarioBLL.Guardar(usuario))
                {

                }
            }
        }
    }
}
