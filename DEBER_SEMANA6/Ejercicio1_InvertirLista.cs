using System;

namespace DEBER_SEMANA6
{
    /*
     EJERCICIO 1:
     Implementar un método dentro de la lista enlazada que permita invertir los datos
     almacenados en una lista enlazada, es decir que el primer elemento pase a ser el último
     y el último pase a ser el primero, y así sucesivamente.
    */

    class Nodo1
    {
        public int Dato;
        public Nodo1 Siguiente;

        public Nodo1(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    class ListaInvertible
    {
        private Nodo1 cabeza;

        public void Agregar(int dato)
        {
            Nodo1 nuevo = new Nodo1(dato);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Nodo1 actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public void Invertir()
        {
            Nodo1 anterior = null;
            Nodo1 actual = cabeza;
            Nodo1 siguiente;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }
            cabeza = anterior;
        }

        public void Mostrar()
        {
            Nodo1 actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Ejercicio1
    {
        public static void InvertirLista()
        {
            ListaInvertible lista = new ListaInvertible();

            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            lista.Invertir();
            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}
