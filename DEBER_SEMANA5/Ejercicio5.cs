using System;
using System.Collections.Generic;

class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.WriteLine("EJERCICIO 5");
        Console.WriteLine("Números del 1 al 10 en orden inverso separados por comas");
        Console.WriteLine();

        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        numeros.Reverse();

        for (int i = 0; i < numeros.Count; i++)
        {
            if (i < numeros.Count - 1)
                Console.Write(numeros[i] + ", ");
            else
                Console.Write(numeros[i]);
        }

        Console.WriteLine();
    }
}
