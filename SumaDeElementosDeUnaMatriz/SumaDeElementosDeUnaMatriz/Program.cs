/*Crear una matriz bidimensional de enteros, solicitar al usuario el numero de filas y columnas de la matriz, 
recorrer la matriz e ingresar un valor entero en cada posición, imprimir cada elemento de la matriz, 
imprimir la suma total en consola*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeElementosDeUnaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int[,] matriz;
                int i = 0, j = 0, filas, columnas, suma = 0;
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                //Titulo
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para obtener la suma total de una matriz");
                //Ingreso del numero de filas y columnas
                Console.Write("Ingrese el numero de filas: ");
                filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de columnas: ");
                columnas = int.Parse(Console.ReadLine());
                //Establecemos el tamaño de la matriz
                matriz = new int[filas, columnas];
                //Recorrido de la matriz
                //Recorrido de las filas
                while (i < filas)
                {
                    j = 0;
                    //Recorrido de las columnas
                    while (j < columnas)
                    {
                        Console.Write($"Ingrese el valor para la posición matriz[{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                        j++;
                    }
                    i++;
                }
                //Impresión de la matriz
                //Recorrido de las filas
                for (i = 0; i < filas; i++)
                {
                    //Recorrido de las columnas
                    for (j = 0; j < columnas; j++)
                    {
                        //Se imprime el elemento de la matriz y se realiza la suma de cada elemento
                        suma += matriz[i, j];
                        Console.Write(matriz[i, j]);
                    }
                    Console.Write("\n");
                }
                //Impresion de la suma de los elementos de la matriz
                Console.WriteLine($"La suma de todos los elementos es: {suma}");
            } catch { Console.WriteLine("Dato ingresado erroneo"); }
        }
    }
}