using System;
using GarajeApp.Clases;

namespace GarajeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Garaje
            Garaje miGaraje = new Garaje(1, "Garaje Principal", 50, 10);

            Console.WriteLine($"Espacios disponibles: {miGaraje.EspaciosDisponibles()}");

            // Solicitar 5 espacios
            miGaraje.ActualizarEspacios(5);

            Console.WriteLine($"Espacios disponibles después: {miGaraje.EspaciosDisponibles()}");
        }
    }
}
