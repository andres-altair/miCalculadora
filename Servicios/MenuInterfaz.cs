using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miCalculadora.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que muestra el mensaje de bienvenida
        /// 101023-amd
        /// </summary>
        public void mensajeBienvenida();
        /// <summary>
        /// metodo que muestra el menu y la seleccion
        /// 101023-amd
        /// </summary>
        public double menuYSeleccion();
    }
    
}
