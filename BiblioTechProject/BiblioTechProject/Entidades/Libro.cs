using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public int Edicion { get; set; }
        public string Estado { get; set; }
        public int CategoriaId { get; set; }
        public virtual List<Autor> AutorId { get; set; }
        public int EditorialId { get; set; }
        public int UsuarioId { get; set; }

        public Libro()
        {
            AutorId = new List<Autor>();
        }
        
    }
}
