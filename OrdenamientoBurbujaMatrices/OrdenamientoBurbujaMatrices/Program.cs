/*Crear una matriz didimensional de enteros, elegir un metodo de ordenación (por ejemplo, burbuja, selección, insercción)
implementar el algoritmo de ordenación elegido para ordenar la matriz, imprimir la matriz ordenada en la consola.
Se elegio el metodo burbuja
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBurbujaMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de columnas: ");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas,columnas];
            Random aleatorio = new Random();
            int i = 0, j = 0;
            while (i < filas)
            {
                j = 0;
                while (j < columnas)
                {
                    Console.WriteLine(matriz[i, j] = aleatorio.Next(1,9));
                    j++;
                }
                Console.WriteLine();
                i++;
            }

        }
    }
}
