/*Crear una matriz bidimensional de enteros, elegir un metodo de ordenación (por ejemplo, burbuja, selección, insercción)
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
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            // Llenado de la matriz
            Random aleatorio = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 9);
                }
            }

            // Impresión de la matriz
            Console.WriteLine("La matriz generada es:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Convertir la matriz en un arreglo unidimensional
            int[] arreglo = new int[filas * columnas];
            int index = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    arreglo[index++] = matriz[i, j];
                }
            }

            // Ordenar el arreglo unidimensional con método burbuja
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = 0; j < arreglo.Length - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    }
                }
            }

            // Reconstruir la matriz desde el arreglo ordenado
            index = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = arreglo[index++];
                }
            }

            // Impresión de la matriz ordenada
            Console.WriteLine("--- Matriz ordenada a través del método burbuja ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
