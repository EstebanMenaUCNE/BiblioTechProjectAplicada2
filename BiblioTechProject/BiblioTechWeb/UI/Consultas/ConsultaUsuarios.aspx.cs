using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI.Consultas
{
    public partial class ConsultaUsuarios : System.Web.UI.Page
    {
        public List<Usuario> Lista { get; set; }
        public static Usuario UsuarioSeleccionado = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = new List<Usuario>();
            UsuarioSeleccionado = null;
            Consola.Visible = false;
        }

        private void Filtrar()
        {
            DateTime fechaDesde = Utilidad.ToDateTime(FechaDesdeTextBox.Text);
            DateTime fechaHasta = Utilidad.ToDateTime(FechaHastaTextBox.Text);
            if (FiltrarDropDownList.Text == "ID")
            {
                int id = Utilidad.ToInt(FiltrarTextBox.Text);
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.UsuarioBLL.GetList(U => U.UsuarioId == id && U.FechaCreacion >= fechaDesde.Date && U.FechaCreacion <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.UsuarioBLL.GetList(U => U.UsuarioId == id);
                }                
            }
            else if (FiltrarDropDownList.Text == "Nombre")
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.UsuarioBLL.GetList(U => U.Nombre == FiltrarTextBox.Text && U.FechaCreacion >= fechaDesde.Date && U.FechaCreacion <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.UsuarioBLL.GetList(U => U.Nombre == FiltrarTextBox.Text);
                }
                
            }
            else
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.UsuarioBLL.GetList(U => U.UsuarioId > 0 && U.FechaCreacion >= fechaDesde.Date && U.FechaCreacion <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.UsuarioBLL.GetList(U => U.UsuarioId > 0);
                }                
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        protected void FiltrarFechaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            UsuarioSeleccionado = BiblioTechProject.BLL.UsuarioBLL.Buscar(U => U.UsuarioId == id);
            BiblioTechProject.BLL.UsuarioBLL.Eliminar(UsuarioSeleccionado);
            UsuarioSeleccionado = null;
        }

        protected void FilaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        protected void FilaTextBox_Unload(object sender, EventArgs e)
        {
            
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            UsuarioSeleccionado = BiblioTechProject.BLL.UsuarioBLL.Buscar(U => U.UsuarioId == id);
            Response.Redirect("../Registros/RegistroUsuarios.aspx");
        }
    }
}