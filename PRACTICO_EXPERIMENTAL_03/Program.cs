using System;
using System.Collections.Generic;
using System.Diagnostics;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }

    public Libro(string titulo, string autor, int anio)
    {
        Titulo = titulo;
        Autor = autor;
        Anio = anio;
    }
}

class Program
{
    static Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();
    static HashSet<string> isbnRegistrados = new HashSet<string>();

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n--- SISTEMA DE BIBLIOTECA ---");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Visualizar libros");
            Console.WriteLine("3. Consultar libro por ISBN");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            Stopwatch cronometro = Stopwatch.StartNew();

            switch (opcion)
            {
                case "1":
                    RegistrarLibro();
                    break;
                case "2":
                    VisualizarLibros();
                    break;
                case "3":
                    ConsultarLibro();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            cronometro.Stop();
            Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds} ms");
        }
    }

    static void RegistrarLibro()
    {
        Console.Write("Ingrese ISBN: ");
        string isbn = Console.ReadLine();

        if (isbnRegistrados.Contains(isbn))
        {
            Console.WriteLine("El libro ya está registrado.");
            return;
        }

        Console.Write("Ingrese título: ");
        string titulo = Console.ReadLine();

        Console.Write("Ingrese autor: ");
        string autor = Console.ReadLine();

        int anio;
    Console.Write("Ingrese año de publicación: ");

    while (!int.TryParse(Console.ReadLine(), out anio))
{
    Console.WriteLine("Entrada inválida. Por favor ingrese un año numérico.");
    Console.Write("Ingrese año de publicación: ");
}

        Libro nuevoLibro = new Libro(titulo, autor, anio);

        biblioteca.Add(isbn, nuevoLibro);
        isbnRegistrados.Add(isbn);

        Console.WriteLine("Libro registrado correctamente.");
    }

    static void VisualizarLibros()
    {
        if (biblioteca.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        foreach (var item in biblioteca)
        {
            Console.WriteLine($"\nISBN: {item.Key}");
            Console.WriteLine($"Título: {item.Value.Titulo}");
            Console.WriteLine($"Autor: {item.Value.Autor}");
            Console.WriteLine($"Año: {item.Value.Anio}");
        }
    }

    static void ConsultarLibro()
    {
        Console.Write("Ingrese ISBN a consultar: ");
        string isbn = Console.ReadLine();

        if (biblioteca.ContainsKey(isbn))
        {
            Libro libro = biblioteca[isbn];
            Console.WriteLine($"\nTítulo: {libro.Titulo}");
            Console.WriteLine($"Autor: {libro.Autor}");
            Console.WriteLine($"Año: {libro.Anio}");
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }
}