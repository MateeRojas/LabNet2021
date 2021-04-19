using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods___Exceptions___Unit_Test.Extensions
{
    public static class IntegerExtensions
    {
        public static bool DividirPorCero(this int numero)
        {
            bool hayExcepcion = false;
            try
            {
                Console.WriteLine($"El resultado es {numero / 0}");
               
            }
            catch (DivideByZeroException ex)
            {
                hayExcepcion = true;
                Console.WriteLine($"Se capturó: {ex.Message}");
            
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

            return hayExcepcion;

        }

        public static int Dividir(this int dividendo, int? divisor)
        {
            bool hayExcepcion = false;
            try
            {
                int resultado = dividendo / divisor.Value;
                return resultado;
            }
            catch(InvalidOperationException ex)
            {
                hayExcepcion = true;
                Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada! Se capturó: {ex.Message}");
                return 0;
            }
            catch(DivideByZeroException ex)
            {
                hayExcepcion = true;
                Console.WriteLine($"Solo Chuck Norris divide por cero! Se capturó: {ex.Message}");
                return 0;
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
           
        }
    }
}
