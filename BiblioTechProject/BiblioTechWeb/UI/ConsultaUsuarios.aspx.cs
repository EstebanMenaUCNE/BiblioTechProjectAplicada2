using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class ConsultaUsuarios : System.Web.UI.Page
    {
        public List<Usuario> Lista { get; set; }
        public Usuario UsuarioSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Lista = new List<Usuario>();
                UsuarioSeleccionado = null;
            }
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

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            UsuarioSeleccionado = BiblioTechProject.BLL.UsuarioBLL.Buscar(U => U.UsuarioId == id);
            BiblioTechProject.BLL.UsuarioBLL.Eliminar(UsuarioSeleccionado);
            UsuarioSeleccionado = null;
            Filtrar();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            UsuarioSeleccionado = BiblioTechProject.BLL.UsuarioBLL.Buscar(U => U.UsuarioId == id);
            Server.Transfer("RegistroUsuarios.aspx");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/ReporteUsuarios.aspx");
        }

    }
}