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
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
    }

}
