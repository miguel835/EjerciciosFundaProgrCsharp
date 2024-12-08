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
            try
            {
                //Declaración de variables
                int[,] matrizOriginal, matrizRotada;
                int i = 0, j = 0, filas, columnas, numeroLimite;
                Random aleatorio = new Random();
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                //Titulo
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para rotar 90 grados una matriz");
                //Ingreso del numero de filas y columnas
                Console.Write("Ingrese el numero de filas: ");
                filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de columnas: ");
                columnas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero limite para el llenado aleatorio: ");
                numeroLimite = int.Parse(Console.ReadLine());
                Console.WriteLine($"La matriz original {filas} x {columnas} es: ");
                //Establecemos el tamaño de la matriz
                matrizOriginal = new int[filas, columnas];
                //Establecemos el tamaño de la matriz rotada
                matrizRotada = new int[columnas, filas];
                //Recorrido de la matriz original 
                //Recorrido de las filas
                while (i < filas)
                {
                    j = 0;
                    //Recorrido de las columnas
                    while (j < columnas)
                    {
                        //Llenado aleatorio de la matriz
                        matrizOriginal[i, j] = aleatorio.Next(1, numeroLimite);
                        Console.Write(matrizOriginal[i, j] + " ");
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                Console.WriteLine($"La matriz rotada de {columnas} x {filas} es: ");
                //Llenado de la matriz rotada
                //Recorrido de las filas
                i = 0;
                while (i < filas)
                {
                    j = 0;
                    //Recorrido de las columnas
                    while (j < columnas)
                    {
                        matrizRotada[j, filas - i - 1]= matrizOriginal[i, j];
                        j++;
                    }
                    i++;
                }
                //Mostramos la matriz rotada
                j = 0; 
                while (j < columnas)
                {
                    i = 0;
                    //Recorrido de las columnas
                    while (i < filas)
                    {
                        Console.WriteLine(matrizRotada[j,i] + " ");
                        i++;
                    }
                    Console.WriteLine();
                    j++;
                }
            }
            catch { Console.WriteLine("Ha ocurrido un error"); }
        }
    }
}
