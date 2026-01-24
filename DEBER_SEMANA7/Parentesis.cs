using System;
using System.Collections.Generic;

class Parentesis
{
    /// <summary>
    /// Método que se llama desde el Main
    /// </summary>
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese la expresión matemática:");
        string expresion = Console.ReadLine();

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    /// <summary>
    /// Verifica si los paréntesis, llaves y corchetes están balanceados
    /// utilizando una pila
    /// </summary>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Símbolos de apertura
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Símbolos de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char apertura = pila.Pop();

                if (!EsParCorrecto(apertura, c))
                    return false;
            }
        }

        return pila.Count == 0;
    }

    /// <summary>
    /// Comprueba si el símbolo de apertura coincide con el de cierre
    /// </summary>
    static bool EsParCorrecto(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}
