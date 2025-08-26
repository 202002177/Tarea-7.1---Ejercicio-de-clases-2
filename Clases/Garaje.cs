using System;

namespace GarajeApp.Clases
{
    public class Garaje
    {
        // Atributos
        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int Capacidad { get; set; }
        public int Ocupados { get; set; }

        // Constructor
        public Garaje(int numeroGaraje, string descripcion, int capacidad, int ocupados)
        {
            NumeroGaraje = numeroGaraje;
            Descripcion = descripcion;
            Capacidad = capacidad;
            Ocupados = ocupados;
        }

        // Método para retornar espacios disponibles
        public int EspaciosDisponibles()
        {
            return Capacidad - Ocupados;
        }

        // Método para actualizar espacios ocupados
        public void ActualizarEspacios(int solicitados)
        {
            // Verificamos que no se supere la capacidad
            if (Ocupados + solicitados <= Capacidad)
            {
                Ocupados += solicitados;
                Console.WriteLine($"Se ocuparon {solicitados} espacios. Ahora hay {Ocupados} ocupados.");
            }
            else
            {
                Console.WriteLine("No hay suficientes espacios disponibles.");
            }
        }
    }
}