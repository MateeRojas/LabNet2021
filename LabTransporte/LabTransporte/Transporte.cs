using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    public abstract class Transporte
    {
        protected int cantidadPasajeros; //opté por hacerlo protegido para que solo sus hijas tengan acceso, manteniendo el encapsulamiento.

        public Transporte(int cantidad)
        {
            this.cantidadPasajeros = cantidad;
        }
        public abstract int GetCantidadPasajeros();
        public abstract string GetNombre();
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
