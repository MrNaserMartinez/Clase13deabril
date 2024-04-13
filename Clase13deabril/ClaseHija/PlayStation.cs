using Clase13deabril.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13deabril.ClaseHija
{
    internal class PlayStation:ClsConsola
    {
        public string ModeloContorlador { get; set; }
        public String MostrarDetallePLay() 
        { 
            return MostrarDetalles() + "Controlador: " + ModeloContorlador;
        
        }
    }
}
