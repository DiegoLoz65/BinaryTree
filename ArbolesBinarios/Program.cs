using System;

namespace ArbolesBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Busqueda
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
            Nodo raiz = arbol.Insertar(6, null);

            arbol.Insertar(2, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);

            arbol.ApuntadorPreOrder(raiz);

            Console.WriteLine("El menor es {0}", arbol.EncontrarMinimo(raiz));
            Console.WriteLine("El mayor es {0}", arbol.EncontrarMaximo(raiz));
        }
    }
}
