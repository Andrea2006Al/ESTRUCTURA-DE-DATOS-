using System;
using System.Collections.Generic;

class Ejercicio4
{
    public static void Ejecutar()
    {
        Console.WriteLine("EJERCICIO 4");
        Console.WriteLine("Números ganadores de la lotería primitiva");
        Console.WriteLine();

        List<int> numeros = new List<int>();

        for (int i = 1; i <= 6; i++)
        {
            Console.Write("Ingrese el número ganador " + i + ": ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        numeros.Sort();

        Console.WriteLine();
        Console.WriteLine("Números ordenados de menor a mayor:");

        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}
