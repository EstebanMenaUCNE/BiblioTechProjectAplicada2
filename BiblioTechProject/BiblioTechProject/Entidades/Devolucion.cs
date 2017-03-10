using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Devolucion
    {
        [Key]
        public int DevolucionId { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
    }

}
