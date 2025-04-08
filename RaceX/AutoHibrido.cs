using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public class AutoHibrido : Auto
    {
        public AutoHibrido(string nombre) : base(nombre)
        {
            Tipo = "Híbrido";
        }

        public override int CalcularBonificacion(string clima)
        {
            return clima == "Ventoso" ? -1 : 0;
        }
    }
}
