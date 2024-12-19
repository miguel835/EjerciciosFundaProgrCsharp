/*Crear una matriz bidimensional de enteros, crear una nueva matriz rotada, recorrer la matriz original y copiar cada 
elemento en su posición correspondiente en la matriz rotada, considerando la rotación de 90 grados a la derecha,
imprimir la matriz rotada en la consola*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizRotada90GradosALaDerecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de columnas: ");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz llenada con exito");

            int[,] matrizRotada = new int[columnas, filas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizRotada[j, filas -1 -i] = matriz[i, j];
                }
            }

            Console.WriteLine("Matriz Original: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matriz rotada 90 grados a la derecha: ");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write(matrizRotada[i,j] + " ");                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
