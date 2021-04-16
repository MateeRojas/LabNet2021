using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    class Avion : Transporte
    {
        private int sobrevivientes; //creado con la finalidad de usar atributos privados
        public Avion(int cantidad) : base(cantidad) { }

        public override int GetCantidadPasajeros()
        {
            return cantidadPasajeros;
        }

        public override string GetNombre()
        {
            return string.Format("Avión");
        }

        public override string Avanzar()
        {
            return string.Format("El avión vuela por el cielo con {0} tripulantes", cantidadPasajeros);
        }

        private int DeterminarSobrevivientes()
        {
            return cantidadPasajeros / 10;
        }

        public override string Detenerse() //creado con la finalidad de usar metodos privados
        {
            sobrevivientes = DeterminarSobrevivientes();
            return string.Format("Un avión no debería frenar, estamos en caída libre. Estamos cayendo con {0} pasajeros. Se estiman {1} sobrevivientes.", cantidadPasajeros, sobrevivientes);
        }
    }
}
