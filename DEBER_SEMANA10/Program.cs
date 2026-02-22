using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1️⃣ Universo de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 2️⃣ 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 3️⃣ 75 vacunados con AstraZeneca
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // 🔹 Operaciones de conjuntos

        // Unión
        var vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        // No vacunados
        var noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // Ambas dosis
        var ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Solo Pfizer
        var soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Solo AstraZeneca
        var soloAstraZeneca = new HashSet<string>(astraZeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        // 📊 Mostrar resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Ciudadanos solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos solo AstraZeneca: " + soloAstraZeneca.Count);

        Console.ReadLine();
    }
}
