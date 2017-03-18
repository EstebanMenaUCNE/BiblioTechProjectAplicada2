using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class EditorialLibro
    {
        [Key]
        public int Id { get; set; }
        public int EditorialId { get; set; }
        public int LibroId { get; set; }
        /*
        public virtual Editorial Editorial { get; set; }
        public virtual Libro Libro { get; set; }
        */
        public EditorialLibro(int libroId)
        {
            LibroId = libroId;
        }

        public EditorialLibro()
        {

        }

        public EditorialLibro(int id, int editorialId, int libroId)
        {
            Id = id;
            EditorialId = editorialId;
            LibroId = libroId;
        }
    }
}
