using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RaceX
{
    public class Carrera
    {
        private List<Auto> autos;
        private string clima;
        private bool enCurso;
        private Random random;

        public int Meta { get; private set; } = 150;

        public bool CarreraIniciada => enCurso;

        public string Clima => clima;

        public IReadOnlyList<Auto> Autos => autos.AsReadOnly();

        public Carrera()
        {
            autos = new List<Auto>();
            random = new Random();
            enCurso = false;
        }

        public bool AgregarAuto(Auto auto)
        {
            if (enCurso)
                throw new InvalidOperationException("No se pueden agregar autos una vez iniciada la carrera.");

            if (string.IsNullOrWhiteSpace(auto.Nombre))
                throw new ArgumentException("El nombre del auto no puede estar vacío.");

            if (autos.Any(a => a.Nombre.Equals(auto.Nombre, StringComparison.OrdinalIgnoreCase)))
                throw new ArgumentException("El nombre del auto ya está registrado.");

            autos.Add(auto);
            return true;
        }



        public void SeleccionarClima(string climaSeleccionado)

        {

            if (string.IsNullOrEmpty(climaSeleccionado))

                throw new ArgumentException("Debe seleccionar un clima válido.");



            clima = climaSeleccionado;

        }



        public void IniciarCarrera()

        {

            if (autos.Count < 3)

                throw new InvalidOperationException("Se requieren al menos 3 autos para iniciar la carrera.");



            if (string.IsNullOrEmpty(clima))

                throw new InvalidOperationException("Debe seleccionarse un clima antes de iniciar.");



            enCurso = true;

        }



        public string EjecutarTurno()

        {

            if (!enCurso)

                throw new InvalidOperationException("La carrera no ha sido iniciada.");



            foreach (var auto in autos)

            {

                auto.Avanzar(clima);

            }



            // Aplicar obstáculo aleatorio con 30% de probabilidad

            if (random.NextDouble() <= 0.3)

            {

                int index = random.Next(autos.Count);

                autos[index].Penalizar();

                return $"¡Obstáculo para {autos[index].Nombre}! Pierde 5 metros.";

            }



            return "Turno ejecutado sin obstáculos.";

        }



        public Auto ObtenerGanador()

        {

            return autos.FirstOrDefault(a => a.DistanciaRecorrida >= Meta);

        }



        public void Reiniciar()

        {

            autos.Clear();

            clima = null;

            enCurso = false;

        }

    }

}
