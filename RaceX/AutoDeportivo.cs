using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public class AutoDeportivo : Auto
    {
        public AutoDeportivo(string nombre) : base(nombre)
        {
            Tipo = "Deportivo";
        }

        public override int CalcularBonificacion(string clima)
        {
            return clima == "Soleado" ? 3 : 0;
        }
    }
}

