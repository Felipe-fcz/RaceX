using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public abstract class Auto
    {
        public string Nombre { get; private set; }
        public string Tipo { get; protected set; }
        public int DistanciaRecorrida { get; protected set; }

        protected Auto(string nombre)
        {
            Nombre = nombre;
            DistanciaRecorrida = 0;
        }

        public abstract int CalcularBonificacion(string clima);

        public void Avanzar(string clima)
        {
            Random rand = new Random();
            int avanceBase = rand.Next(5, 16); // 5 a 15 metros
            int bonificacion = CalcularBonificacion(clima);
            DistanciaRecorrida += (avanceBase + bonificacion);
        }

        public void Penalizar()
        {
            DistanciaRecorrida = Math.Max(0, DistanciaRecorrida - 5);
        }
    }
}
