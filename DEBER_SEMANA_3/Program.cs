using System;

namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    class Estudiante
    {
        // Atributos del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }

        // Array para almacenar los teléfonos
        public string[] Telefonos = new string[3];

        // Método para mostrar la información del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Estudiante
            Estudiante estudiante = new Estudiante();

            // Solicitar datos al usuario
            Console.Write("Ingrese el ID del estudiante: ");
            estudiante.Id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los nombres: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese los apellidos: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            estudiante.Direccion = Console.ReadLine();

            // Ingreso de los teléfonos usando un array
            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                Console.Write($"Ingrese el teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            // Mostrar resultados
            estudiante.MostrarDatos();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

