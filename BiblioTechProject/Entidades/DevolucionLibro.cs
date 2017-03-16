using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class DevolucionLibro
    {
        [Key]
        public int DevolicionLibroId { get; set; }
        public int DevolucionId { get; set; }
        public int LibroId { get; set; }

        public virtual Libro Libro { get; set; }
        public virtual Usuario Usuario { get; set; }

        public DevolucionLibro(int libroId)
        {
            LibroId = libroId;
        }

    }

}
