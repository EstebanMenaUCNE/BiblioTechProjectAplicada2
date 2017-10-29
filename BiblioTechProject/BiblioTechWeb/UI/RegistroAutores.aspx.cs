﻿using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI
{
    public partial class RegistroAutores : System.Web.UI.Page
    {
        private Autor autor = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            if (PreviousPage != null && PreviousPage.AutorSeleccionado != null)
            {
                autor = PreviousPage.AutorSeleccionado;
                CargarDatos();
                NuevoOModificando();
            }
        }

        private void DeshabilitarCampos()
        {
            NombreTextBox.Enabled = false;
        }

        private void Limpiar()
        {
            autor = null;
            AutorIdTextBox.Text = "";
            NombreTextBox.Text = "";

            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;

            NuevoOModificando(); //Este es el que funciona, no el que se ejecuta supuestamente cuando cambia el text del textbox del id
        }

        private void CargarDatos()
        {
            AutorIdTextBox.Text = autor.AutorId.ToString();
            NombreTextBox.Text = autor.Nombre;
        }

        private void NuevoOModificando()
        {
            if (AutorIdTextBox.Text == "")
            {
                NuevoOModificandoLabel.Text = "Nuevo autor";
            }
            else
            {
                NuevoOModificandoLabel.Text = "Modificando el autor " + AutorIdTextBox.Text;
            }
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (AutorIdTextBox.Text != "")
            {
                id = Utilidad.ToInt(AutorIdTextBox.Text);
            }
            autor = new Autor(id, NombreTextBox.Text);
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (BiblioTechProject.BLL.AutorBLL.Guardar(autor, new List<AutorLibro>()))
                {
                    AutorIdTextBox.Text = autor.AutorId.ToString();MensajeAlertaGuardadoExito.Text = "¡Guardado con éxito con el ID " + autor.AutorId + "!";
                    AlertaGuardadoExito.Visible = true;
                    NuevoOModificando();
                }
                else
                {
                    AlertaError.Visible = true;
                }
            }
            else
            {
                AlertaValidar.Visible = true;
            }
        }

        protected void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void AutorIdTextBox_TextChanged(object sender, EventArgs e)
        {
            NuevoOModificando();
        }
    }
}