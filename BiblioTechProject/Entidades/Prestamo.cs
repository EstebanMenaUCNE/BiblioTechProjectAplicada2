using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaEntregarAntes { get; set; }
        public DateTime FechaLibrosEntregados { get; set; }
        public string Estado { get; set; }
        public int ClienteId { get; set; }
        //public int UsuarioId { get; set; }

        //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
        //public string UltimoUsuarioEnModificar { get; set; }
        
        public Prestamo()
        {

        }
        public Prestamo(int prestamoId, DateTime fechaPrestamo, DateTime fechaEntregarAntes, DateTime fechaLibrosEntregados, string estado, int clienteId)
        {
            PrestamoId = prestamoId;
            FechaPrestamo = fechaPrestamo;
            FechaEntregarAntes = fechaEntregarAntes;
            FechaLibrosEntregados = fechaLibrosEntregados;
            Estado = estado;
            ClienteId = clienteId;
            //UsuarioId = usuarioId;
        }
    }

}
