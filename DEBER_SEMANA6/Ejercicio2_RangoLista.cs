using System;

namespace DEBER_SEMANA6
{
    /*
     EJERCICIO 2:
     Crear una lista enlazada con 50 números enteros aleatorios entre 1 y 999.
     Luego eliminar los nodos que estén fuera del rango ingresado por teclado.
    */

    class Nodo2
    {
        public int Dato;
        public Nodo2 Siguiente;

        public Nodo2(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    class ListaRango
    {
        private Nodo2 cabeza;

        public void Agregar(int dato)
        {
            Nodo2 nuevo = new Nodo2(dato);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Nodo2 actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public void EliminarFueraRango(int min, int max)
        {
            while (cabeza != null && (cabeza.Dato < min || cabeza.Dato > max))
                cabeza = cabeza.Siguiente;

            Nodo2 actual = cabeza;
            while (actual != null && actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato < min || actual.Siguiente.Dato > max)
                    actual.Siguiente = actual.Siguiente.Siguiente;
                else
                    actual = actual.Siguiente;
            }
        }

        public void Mostrar()
        {
            Nodo2 actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Ejercicio2
    {
        public static void RangoLista()
        {
            ListaRango lista = new ListaRango();
            Random r = new Random();

            for (int i = 0; i < 50; i++)
                lista.Agregar(r.Next(1, 1000));

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            Console.Write("Ingrese mínimo: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Ingrese máximo: ");
            int max = int.Parse(Console.ReadLine());

            lista.EliminarFueraRango(min, max);

            Console.WriteLine("Lista filtrada:");
            lista.Mostrar();
        }
    }
}
