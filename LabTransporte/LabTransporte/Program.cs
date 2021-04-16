using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorAviones = 0;
            int contadorAutomoviles = 0;
            List<Transporte> transportes = new List<Transporte>
            {
                new Avion(100),
                new Avion(150),
                new Avion(65),
                new Avion(2),
                new Avion(101),
                new Automovil(4),
                new Automovil(2),
                new Automovil(3),
                new Automovil(2),
                new Automovil(7),

            };

            Console.WriteLine("Se hará prueba de la funcionalidad principal del programa pedida:");
            Console.WriteLine();

            foreach (var item in transportes)
            {
                if (item.GetNombre() == "Avión")
                {
                    contadorAviones++;
                    Console.WriteLine("Avión " + contadorAviones + ": " + item.GetCantidadPasajeros() + " pasajeros");
                    Console.WriteLine();
                }
                else { //es un else y no otro if debido a que asumo que los items son si o si o auto o avión.
                    contadorAutomoviles++;
                    Console.WriteLine("Automóvil " + contadorAutomoviles + ": " + item.GetCantidadPasajeros() + " pasajeros");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Se hará prueba de las funciones Detenerse y Avanzar de cada Transporte:");
            Console.WriteLine();
            foreach (var item in transportes)
            {
                Console.WriteLine(item.Avanzar());
                Console.WriteLine(item.Detenerse());
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
