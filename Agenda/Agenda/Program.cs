﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
                        abo.Insertar(100);
                        abo.Insertar(50);
                        abo.Insertar(25);
                        abo.Insertar(75);
                        abo.Insertar(150);
                        Console.WriteLine("Impresion entreorden: ");
                        abo.ImprimirEntre();
                        Console.WriteLine("Cantidad de nodos del árbol:" + abo.Cantidad());
                        Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja());
                        Console.WriteLine("Impresion en entre orden junto al nivel del nodo.");
                        abo.ImprimirEntreConNivel();
                        Console.Write("Artura del arbol:");
                        Console.WriteLine(abo.RetornarAltura());
                        abo.MayorValorl();
                        abo.BorrarMenor();
                        Console.WriteLine("Luego de borrar el menor:");
                        abo.ImprimirEntre();
                        Console.ReadKey();*/

            MenuArbolBinario menu = new MenuArbolBinario();
            menu.MenuPrincipal();
        }
    }
}