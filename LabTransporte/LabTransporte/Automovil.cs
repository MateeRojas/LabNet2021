using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    class Automovil : Transporte
    {
        private int pasajerosConCinturon; //creado con la finalidad de usar atributos privados
        public Automovil (int cantidad) : base(cantidad) { }

        public override int GetCantidadPasajeros()
        {
            return cantidadPasajeros;
        }

        public override string GetNombre()
        {
            return string.Format("Atomóvil");
        }
        public override string Avanzar()
        {
            return string.Format("El auto avanza con una familia entera. La familia cuenta con {0} miembros", cantidadPasajeros);
        }

        private int DeterminarSeguridad() //creado con la finalidad de usar metodos privados
        {
            Random rd = new Random();
            return rd.Next(0, cantidadPasajeros+1); 
        }

        public override string Detenerse()
        {
            pasajerosConCinturon = DeterminarSeguridad();
            return string.Format("Frenó y de los {0} pasajeros, tenían puesto el cinturón {1}.", cantidadPasajeros, pasajerosConCinturon);
        }
    }
}
