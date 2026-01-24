using System;
using System.Collections.Generic;

class Parentesis
{
    /// <summary>
    /// Método que se llama desde el Main
    /// </summary>
    public static void Ejecutar()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    /// <summary>
    /// Verifica si los símbolos están balanceados usando una pila
    /// </summary>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);

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

    static bool EsParCorrecto(char a, char c)
    {
        return (a == '(' && c == ')') ||
               (a == '{' && c == '}') ||
               (a == '[' && c == ']');
    }
}
