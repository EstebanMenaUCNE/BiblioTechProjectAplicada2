using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BiblioTechProject.Entidades
{
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
    }

}
