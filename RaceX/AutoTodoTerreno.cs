using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public class AutoTodoTerreno : Auto
    {
        public AutoTodoTerreno(string nombre) : base(nombre)
        {
            Tipo = "Todoterreno";
        }

        public override int CalcularBonificacion(string clima)
        {
            return clima == "Lluvia" ? 2 : 0;
        }
    }
}
