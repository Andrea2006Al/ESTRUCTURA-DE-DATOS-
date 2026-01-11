using System;
using System.Collections.Generic;

class Ejercicio1
{
    public static void Ejecutar()
    {
        Console.WriteLine("EJERCICIO 1");
        Console.WriteLine("Escribir un programa que almacene las asignaturas de un curso");
        Console.WriteLine("y las muestre por pantalla.");
        Console.WriteLine();

        List<string> asignaturas = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        foreach (string a in asignaturas)
        {
            Console.WriteLine(a);
        }
    }
}
