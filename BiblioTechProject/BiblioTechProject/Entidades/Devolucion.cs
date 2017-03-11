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

        public virtual Cliente Cliente { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<DevolucionLibro> DevolucionesLibros { get; set; }

        public Devolucion()
        {
            DevolucionesLibros = new HashSet<DevolucionLibro>();
        }

        public void AgregarDetalle(int libroId)
        {
            DevolucionesLibros.Add(new DevolucionLibro(libroId));
        }
    }

}
