using System;
using System.Collections.Generic;

class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.WriteLine("EJERCICIO 3");
        Console.WriteLine("Asignaturas y notas ingresadas por el usuario");
        Console.WriteLine();

        List<string> asignaturas = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        List<double> notas = new List<double>();

        foreach (string a in asignaturas)
        {
            Console.Write("Ingrese la nota de " + a + ": ");
            notas.Add(double.Parse(Console.ReadLine()));
        }

        Console.WriteLine();
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
        }
    }
}
