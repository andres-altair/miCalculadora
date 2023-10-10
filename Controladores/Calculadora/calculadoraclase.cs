using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace miCalculadora.Controladores.Calculadora
{
    internal class calculadoraclase : calculadorainterfaz
    {

      public double sumar(double a, double b)
        {
            return a + b;

        }
      public double restar(double a, double b) 
        { 
            return a - b;
        }
      public double multiplicar(double a, double b)
        {
            return (a * b);
        }    
      public double dividir(double a, double b)
        {
            return a / b;   
        }

        
    }



}
