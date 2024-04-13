using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13deabril.ClasePadre
{
    internal class ClsConsola
    {
        public int anioLanzamiento { get; set; } 
        public string Marca { get; set; }

        public string MostrarDetalles()
        {
            return ($"Marca:{Marca} Anio:{anioLanzamiento}");

        }
    }
}
