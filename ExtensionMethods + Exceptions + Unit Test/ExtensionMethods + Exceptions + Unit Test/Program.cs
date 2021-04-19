using ExtensionMethods___Exceptions___Unit_Test.Extensions;
using ExtensionMethods___Exceptions___Unit_Test.Excepcions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test //uy que feo quedó esto, no volverá a pasar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1)
            Console.WriteLine("Pruebo el punto 1");
            int numero = 10;
            numero.DividirPorCero();
            Console.WriteLine();

            //2)
            Console.WriteLine("Pruebo el punto 2");
            int otroNumero = 10;
            int resultado;
           
            Console.WriteLine("Division normal");
            resultado = otroNumero.Dividir(2);
            if (resultado == 0)
            {
                Console.WriteLine("División imposible");
            }
            else
            {
                Console.WriteLine($"El resultado es: {resultado}");
            }
            Console.WriteLine();

            Console.WriteLine("Division por 0");
            resultado = otroNumero.Dividir(0);
            if (resultado == 0 )
            {
                Console.WriteLine("División imposible");
            }
            else
            {
                Console.WriteLine($"El resultado es: {resultado}");
            }
            Console.WriteLine();

            Console.WriteLine("Division por null");
            resultado = otroNumero.Dividir(null);
            if (resultado == 0)
            {
                Console.WriteLine("División imposible");
            }
            else
            {
                Console.WriteLine($"El resultado es: {resultado}");
            }
            Console.WriteLine();
            

            //3)
            Console.WriteLine("Pruebo el punto 3");
            bool hayExcepcion = false;
            Logic logic = new Logic(); 
            try
            {
                logic.TirarExcepcion();
            }
            catch (IndexOutOfRangeException ex)
            {
                hayExcepcion = true;
                Console.WriteLine($"Se capturó: {ex.Message}");
                Console.WriteLine($"Tipo de la excepción: {ex.GetType().Name}");
            }
            finally
            {
                if (hayExcepcion)
                {
                    Console.WriteLine("Terminó con excepción");
                }
                else
                {
                    Console.WriteLine("Terminó sin excepción");

                }
            }
            Console.WriteLine();

            //4)
            Console.WriteLine("Pruebo el punto 4");
            try
            {
                logic.TirarExcepcionPersonalizada();
            }
            catch(ExcepcionPersonalizada ex)
            {
                Console.WriteLine($"Se capturó: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
