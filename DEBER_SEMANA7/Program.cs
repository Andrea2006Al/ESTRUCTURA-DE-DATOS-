using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== EJERCICIOS CON PILAS =====");
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Seleccione un ejercicio (1 o 2): ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Parentesis.Ejecutar();
                break;

            case 2:
                TorresHanoi.Ejecutar();
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
