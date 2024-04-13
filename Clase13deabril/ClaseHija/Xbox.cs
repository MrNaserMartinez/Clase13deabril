using Clase13deabril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13deabril.ClaseHija
{
    internal class Xbox:ClsConsola
    {
        public string Kinect { get; set; }
        public String MostrarDetalleXbox()
        {
            return MostrarDetalles() + "Controlador: " + Kinect;

        }
    }
}
