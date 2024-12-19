/*
Desarrolle un algoritmo que permite realizar la busqueda del elemento que más se repita en una matriz
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaDelElementoQueMásSeRepiteEnUnaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, j = 0, aux = 0, cont = 0, rep = 0, f, c;
            Random random = new Random();
            Console.SetCursorPosition(10,0);        
            Console.WriteLine("PROGRAMA PARA OBTENER EL ELEMENTO QUE MÁS SE REPITE EN UNA MATRIZ ALEATORIA");
            Console.Write("Ingrese la dimension de la matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            //Llenado de la matriz
            Console.WriteLine("\nLa matriz es: ");
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    Console.Write(matriz[i, j] = random.Next(1,9));
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            //Buscar quien es el que más se repite
            i = 0;
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    f = 0;
                    //Recorrer hasta obtener el mayor
                    while (f < n)
                    {
                        c = 0;
                        while (c < n)
                        {
                            if (matriz[i,j] == matriz[f, c])
                            {
                                cont++;
                            }
                            c++;
                        }
                        f++;
                    }
                    if ( rep < cont)
                    {
                        aux = matriz[i, j];
                        rep = cont;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine($"\nEl numero que más veces se repite es: {aux}");
            Console.ReadKey();
        }
    }
}
