using System;
using System.Collections.Generic;

class TorresHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    /// <summary>
    /// Método que se llama desde el Main
    /// </summary>
    public static void Ejecutar()
    {
        int discos = 3;

        for (int i = discos; i >= 1; i--)
            origen.Push(i);

        Resolver(discos, origen, destino, auxiliar,
                 "Origen", "Destino", "Auxiliar");
    }

    /// <summary>
    /// Algoritmo recursivo para resolver las Torres de Hanoi
    /// </summary>
    static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                         string nomOrigen, string nomDestino, string nomAux)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nomOrigen} a {nomDestino}");
            return;
        }

        Resolver(n - 1, origen, auxiliar, destino, nomOrigen, nomAux, nomDestino);

        int discoMayor = origen.Pop();
        destino.Push(discoMayor);
        Console.WriteLine($"Mover disco {discoMayor} de {nomOrigen} a {nomDestino}");

        Resolver(n - 1, auxiliar, destino, origen, nomAux, nomDestino, nomOrigen);
    }
}
