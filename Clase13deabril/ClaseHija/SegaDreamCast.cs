using Clase13deabril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13deabril.ClaseHija
{
    internal class SegaDreamCast:ClsConsola
    { 
        public string PantallaControlor { get; set; }
        public String MostrarDetalleSegaDreamCast()
        {
            return MostrarDetalles() + "Controlador: " + PantallaControlor;

        }
    }
}
