using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI.Consultas
{
    public partial class FrmConsultaUsuarios : Form
    {
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            if (filtrarComboBox.Text == "Id")
            {
                List<Entidades.Usuario> lista = BLL.UsuarioBLL.GetListId(Utilidad.ToInt(filtrarTextBox.Text));
                foreach(Entidades.Usuario usuario in lista)
                {
                    usuario.Contrasena = "";
                }
                usuariosDataGridView.DataSource = lista;
            }
            else if (filtrarComboBox.Text == "Nombre")
            {
                List<Entidades.Usuario> lista = BLL.UsuarioBLL.GetListNombre(filtrarTextBox.Text);
                foreach (Entidades.Usuario usuario in lista)
                {
                    usuario.Contrasena = "";
                }
                usuariosDataGridView.DataSource = lista;
            }
            else
            {
                List<Entidades.Usuario> lista = BLL.UsuarioBLL.GetList();
                foreach (Entidades.Usuario usuario in lista)
                {
                    usuario.Contrasena = "";
                }
                usuariosDataGridView.DataSource = lista;
            }
        }
    }
}
