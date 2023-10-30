using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3pr.__.Servicios

{
    internal class OperacionesImplementacion : OperacionesInterfaz 
    {
        public int peticionDeNumero()
        {
            int numeroSeleccionado;
            Console.WriteLine("Escribe un numero entero");
            numeroSeleccionado = Convert.ToInt32(Console.ReadLine());
            return numeroSeleccionado;
        }
    }
}