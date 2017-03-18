using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public int UsuarioId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string UltimoUsuarioEnModificar { get; set; }

        //public virtual Usuario Usuario { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(int clienteId, string nombre, string cedula, string sexo, string telefono, string direccion, DateTime fechaNacimiento, string email, int usuarioId)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Cedula = cedula;
            Sexo = sexo;
            Telefono = telefono;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            Email = email;
            UsuarioId = usuarioId;
        }

    }

}
