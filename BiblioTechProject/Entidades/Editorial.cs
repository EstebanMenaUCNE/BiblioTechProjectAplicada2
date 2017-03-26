using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Editorial
    {
        [Key]
        public int EditorialId { get; set; }
        public string Nombre { get; set; }
        //public int UsuarioId { get; set; }

        //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
        //public string UltimoUsuarioEnModificar { get; set; }
        
        public Editorial()
        {
            
        }
        public Editorial(int editorialId, string nombre)
        {
            EditorialId = editorialId;
            Nombre = nombre;
            //UsuarioId = usuarioId;
        }
    }

}
