using miCalculadora.Controladores.Calculadora;
using miCalculadora.Servicios;
using System;
namespace micalculadora
{
    class micalculadora
    {
        /// <summary>
        /// metodo de entrada de la calculadora
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.mensajeBienvenida();

            bool cerrarmenu=false;
            double opcionSeleccionar;
            
            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            


            while (!cerrarmenu)
            {
                opcionSeleccionar = mi.menuYSeleccion();
                Console.WriteLine(opcionSeleccionar);
                calculadorainterfaz ci = new calculadoraclase();
                ci.calculadora();
                switch (opcionSeleccionar)
                {
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso 0.");
                        cerrarMenu |= true;
                    case 1:
                        Console.WriteLine("la suma es:" + ci.calculadora.sumar(num1, num2));
                            break;
                    case 2:
                        Console.WriteLine("la resta es:" + ci.calculadora.resta(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("la multiplicacion es" + ci.calculadora.multiplicacion(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("la division es" + ci.calculadora.division(num2 , num2));
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no esta disponible.");
                        break;

                }
            }

        }
    }
}