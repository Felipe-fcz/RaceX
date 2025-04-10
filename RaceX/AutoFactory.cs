using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public static class AutoFactory
    {
        public static Auto CrearAuto(string tipo, string nombre)
        {
            switch (tipo)
            {
                case "Deportivo":
                    return new AutoDeportivo(nombre);
                case "Todoterreno":
                    return new AutoTodoTerreno(nombre);
                case "Híbrido":
                    return new AutoHibrido(nombre);
                default:
                    throw new ArgumentException("Tipo de auto inválido.");
            }
        }
    }
}
