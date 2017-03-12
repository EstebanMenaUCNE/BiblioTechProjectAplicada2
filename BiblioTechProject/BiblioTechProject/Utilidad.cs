using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioTechProject
{
    public class Utilidad
    {
        public static int ToInt(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
    }
}
