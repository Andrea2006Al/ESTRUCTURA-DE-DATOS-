// See https://aka.ms/new-console-template for more information
using System;

// Clase Circulo
public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Cuadrado
public class Cuadrado
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public double CalcularArea()
    {
        return lado * lado;
    }

    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

// Clase principal con Main
public class Program
{
    public static void Main(string[] args)
    {
        // Crear objetos
        Circulo c = new Circulo(5);
        Cuadrado q = new Cuadrado(4);

        // Mostrar resultados
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        Console.WriteLine("Área del cuadrado: " + q.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + q.CalcularPerimetro());
    }
}
