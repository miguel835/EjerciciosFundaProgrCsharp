/* Crear una matriz bidimensional de enteros, crear una nueva matriz transpuesta, recorrer la matriz original y copiar cada
elemento en su posición correspondiente en la matriz transpuesta, imprimir la matriz transpuesta en la consola.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranspuestaDeUnaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int[,] matrizOriginal, matrizTranspuesta;
                int i = 0, j = 0, filas, columnas, numeroLimite;
                Random aleatorio = new Random();
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                //Titulo
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para obtener la transpuesta de una matriz");
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
                //Establecemos el tamaño de la matriz transpuesta
                matrizTranspuesta = new int[columnas, filas];
                //Recorrido de la matriz
                //Recorrido de las filas
                while (i < filas)
                {
                    j = 0;
                    //Recorrido de las columnas
                    while (j < columnas)
                    {
                        //Llenado aleatorio de la matriz
                        matrizOriginal[i, j] = aleatorio.Next(1,numeroLimite);
                        Console.Write(matrizOriginal[i,j] + " ");
                        //Llenado de la matriz transpuesta
                        matrizTranspuesta[j, i] = matrizOriginal[i, j];
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                Console.WriteLine($"La matriz transpuesta {columnas} x {filas} es:");
                //Recorrido de la matriz transpuesta
                for (i = 0; i < columnas; i++)
                {
                    for (j = 0; j < filas; j++)
                    {
                        Console.Write(matrizTranspuesta[i,j] + " ");
                    }
                    Console.Write("\n");
                }
            }
            catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();
        }
    }
}
