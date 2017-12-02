using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class ConsultaPrestamos : System.Web.UI.Page
    {
        public List<Prestamo> Lista { get; set; }
        public Prestamo PrestamoSeleccionado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si le pongo esa condición me genera un excepción cuando le doy a "Salir de sesión"
            //if (!this.IsPostBack)
            //{
                Lista = new List<Prestamo>();
                PrestamoSeleccionado = null;
            //}
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
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.PrestamoId == id && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.PrestamoId == id);
                }
            }
            else if (FiltrarDropDownList.Text == "Cliente (ID)")
            {
                int id = Utilidad.ToInt(FiltrarTextBox.Text);
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.ClienteId == id && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.ClienteId == id);
                }

            }
            else if (FiltrarDropDownList.Text == "Cliente (Nombre)")
            {
                BiblioTechProject.Entidades.Cliente cliente = BiblioTechProject.BLL.ClienteBLL.Buscar(C => C.Nombre == FiltrarTextBox.Text);
                if (cliente != null)
                {
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.ClienteId == cliente.ClienteId && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                    }
                    else
                    {
                        Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.ClienteId == cliente.ClienteId);
                    }
                }
                else
                {
                    Lista = new List<Prestamo>();
                }
                

            }
            else if (FiltrarDropDownList.Text == "Pendientes")
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Pendiente" && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Pendiente");
                }

            }
            else if (FiltrarDropDownList.Text == "Devueltos")
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Devuelto" && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Devuelto");
                }

            }
            else if (FiltrarDropDownList.Text == "Retrasados devueltos")
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Devuelto" && U.FechaEntregarAntes < U.FechaLibrosEntregados && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Devuelto" && U.FechaEntregarAntes < U.FechaLibrosEntregados);
                }

            }
            else if (FiltrarDropDownList.Text == "Retrasados pendientes")
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Pendiente" && U.FechaEntregarAntes < DateTime.Now && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.Estado == "Pendiente" && U.FechaEntregarAntes < DateTime.Now);
                }

            }
            else
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.PrestamoId > 0 && U.FechaPrestamo >= fechaDesde.Date && U.FechaPrestamo <= fechaHasta.Date);
                }
                else
                {
                    Lista = BiblioTechProject.BLL.PrestamoBLL.GetListConNombresClientes(U => U.PrestamoId > 0);
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
            PrestamoSeleccionado = BiblioTechProject.BLL.PrestamoBLL.Buscar(U => U.PrestamoId == id);
            BiblioTechProject.BLL.PrestamoBLL.Eliminar(PrestamoSeleccionado);
            PrestamoSeleccionado = null;
            Filtrar();
        }

        protected void ModificarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidad.ToInt(FilaTextBox.Text);
            PrestamoSeleccionado = BiblioTechProject.BLL.PrestamoBLL.Buscar(U => U.PrestamoId == id);
            Server.Transfer("RegistroPrestamos.aspx");
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Filtrar();
            Server.Transfer("Reportes/ReportePrestamos.aspx");
        }

    }
}