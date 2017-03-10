using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class PrestamoLibro
    {
        [Key]
        public int PrestamoLibroId { get; set; }
        public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public int UsuarioId { get; set; }

    }

}
