using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miCalculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje = "bienvenido a la calculadora";
            Console.WriteLine(mensaje);
        }
        public double menuYSeleccion()
        {
            double opcionIntroducida;

            Console.WriteLine("***********************************************");
            Console.WriteLine("0. cerrar aplicacion ");
            Console.WriteLine("1. suma");
            Console.WriteLine("2. resta");
            Console.WriteLine("3. multiplicacion ");
            Console.WriteLine("4. division");
            Console.WriteLine("***********************************************");

        }
    }
}
