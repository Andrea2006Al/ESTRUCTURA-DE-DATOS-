using System;
using System.Collections.Generic;

class Ejercicio2
{
    public static void Ejecutar()
    {
        Console.WriteLine("EJERCICIO 2");
        Console.WriteLine("Mostrar el mensaje: Yo estudio <asignatura>");
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
            Console.WriteLine("Yo estudio " + a);
        }
    }
}
