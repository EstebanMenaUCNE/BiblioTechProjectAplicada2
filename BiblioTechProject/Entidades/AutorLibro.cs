using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class AutorLibro
    {
        [Key]
        public int Id { get; set; }
        public int AutorId { get; set; }
        public int LibroId { get; set; }

        public AutorLibro()
        {

        }

        public AutorLibro(int id, int autorId, int libroId)
        {
            Id = id;
            AutorId = autorId;
            LibroId = libroId;
        }
    }

}
