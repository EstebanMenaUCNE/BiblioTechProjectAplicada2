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
        public int EditorialId { get; set; }
        //public int UsuarioId { get; set; }

        //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
        //public string UltimoUsuarioEnModificar { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string NombreEditorial { get; set; }

        public Libro()
        {

        }

        public Libro(int libroId, string titulo, int edicion, string estado, int editorialId)
        {
            LibroId = libroId;
            Titulo = titulo;
            Edicion = edicion;
            Estado = estado;
            EditorialId = editorialId;
            //UsuarioId = usuarioId;
        }
    }

}
