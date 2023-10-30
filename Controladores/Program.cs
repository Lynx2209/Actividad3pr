using Actividad3pr.__.Servicios;
using Actividad3pr.servicios;
using System;

namespace Actividad3pr.__.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz MI = new MenuImplementacion();
            int numero = MI.peticionDeNumero();
            OperacionesInterfaz OI = new OperacionesImplementacion();
            OI.calcular(numero);
        }
    }
}