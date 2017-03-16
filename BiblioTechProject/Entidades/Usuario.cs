using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Cargo { get; set; }

        public Usuario()
        {

        }

        public Usuario(int usuarioId, string nombre, string nombreUsuario, string contrasena, string cargo)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Cargo = cargo;
        }
    }

}
