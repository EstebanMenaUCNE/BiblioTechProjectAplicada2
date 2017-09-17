﻿using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI.Registros
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        private Usuario usuario = null;
        private bool contrasenaAcertada = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;
            YaExisteAlertaValidar.Visible = false;
        }

        private void Limpiar()
        {
            usuario = null;
            UsuarioIdTextBox.Text = "";
            NombreTextBox.Text = "";
            NombreUsuarioTextBox.Text = "";
            ContrasenaTextBox.Text = "";
            ConfirmarContrasenaTextBox.Text = "";
            FechaCreacionTextBox.Text = "";
            contrasenaAcertada = false;

            AlertaValidar.Visible = false;
            AlertaGuardadoExito.Visible = false;
            AlertaError.Visible = false;
            YaExisteAlertaValidar.Visible = false;

            NuevoOModificando();
        }

        private void NuevoOModificando()
        {
            if (UsuarioIdTextBox.Text == "")
            {
                NuevoOModificandoLabel.Text = "Nuevo Usuario";
            }
            else
            {
                NuevoOModificandoLabel.Text = "Modificando el usuario " + UsuarioIdTextBox.Text;
            }
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(NombreUsuarioTextBox.Text))
            {
                flag = false;
            }
            else if (UsuarioBLL.Buscar(U => U.NombreUsuario == NombreUsuarioTextBox.Text) != null)
            {
                Usuario usuarioConIgualNombreUsuario = UsuarioBLL.Buscar(U => U.NombreUsuario == NombreUsuarioTextBox.Text);
                if (UsuarioIdTextBox.Text == "") //Si se va a guardar, no se puede
                {
                    flag = false;
                    YaExisteAlertaValidar.Visible = true;
                }
                else if (UsuarioIdTextBox.Text != usuarioConIgualNombreUsuario.UsuarioId.ToString())
                {
                    flag = false;
                    YaExisteAlertaValidar.Visible = true;
                    //Si se encontró un usuario con el mismo NombreUsuario que el que digitaron y se va a modificar, el NombreUsuario del usuario a modificar será aceptado si el NombreUsuario que fue encontrado ya existente, es el de él mismo.
                    //Si es de otro usuario no puede modificarse, porque ese NombreUsuario le pertenece a otro.
                }
            }
            /*else if (UsuarioIdTextBox.Text =="" && (UsuarioBLL.Buscar(U => U.NombreUsuario == NombreUsuarioTextBox.Text) != null))
            {
                flag = false;
            }*/
            if (string.IsNullOrWhiteSpace(ContrasenaTextBox.Text))
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmarContrasenaTextBox.Text))
            {
                flag = false;
            }
            else if (ConfirmarContrasenaTextBox.Text != ContrasenaTextBox.Text)
            {
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(FechaCreacionTextBox.Text))
            {
                flag = false;
            }
            return flag;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (UsuarioIdTextBox.Text != "")
            {
                id = Utilidad.ToInt(UsuarioIdTextBox.Text);
            }
            usuario = new Usuario(id, NombreTextBox.Text, NombreUsuarioTextBox.Text, ContrasenaTextBox.Text, CargoDropDownList.Text, DateTime.Parse(FechaCreacionTextBox.Text));
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                contrasenaAcertada = true;
                if (usuario != null && usuario.Cargo == "Administrador")
                {
                    //Usar modal para confirmar contraseña si se va modificar un usuario administrador
                    /*contrasenaAcertada = false;
                    if (usuario.Contrasena == ContrasenaTextBox.Text)
                    {
                        contrasenaAcertada = true;
                    }*/
                }
                if (contrasenaAcertada)
                {
                    LlenarCamposInstancia();
                    if (UsuarioBLL.Guardar(usuario))
                    {
                        UsuarioIdTextBox.Text = usuario.UsuarioId.ToString();
                        MensajeAlertaGuardadoExito.Text = "¡Guardado con éxito con el ID " + usuario.UsuarioId + "!";
                        AlertaGuardadoExito.Visible = true;
                        NuevoOModificando();
                    }
                    else
                    {
                        AlertaError.Visible = true;
                    }
                }
            }
            else
            {
                AlertaValidar.Visible = true;
            }
        }

        protected void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void UsuarioIdTextBox_TextChanged(object sender, EventArgs e)
        {
            NuevoOModificando();
        }
    }
}