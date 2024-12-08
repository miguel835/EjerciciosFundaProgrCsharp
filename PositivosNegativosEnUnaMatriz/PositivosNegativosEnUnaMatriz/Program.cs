/* Crear una matriz bidimensional de enteros, recorrer la matriz y contar la cantidad de elementos positivos y 
negativos, imprimir la cantidad de elementos positivos y negativos en la consola */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivosNegativosEnUnaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int[,] matriz;
                int filas, columnas, i = 0, j, limiteRandom, cantidadPositivos = 0, cantidadNegativos = 0;
                Random aleatorio = new Random();
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //Titulo del programa
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para contar los numeros positivos y negativos en una matriz");
                //Configuración de la matriz
                Console.Write("Ingrese el numero de filas: ");
                filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de columnas: ");
                columnas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero limite para el llenado aleatorio: ");
                limiteRandom = int.Parse(Console.ReadLine());
                Console.WriteLine("La matriz creada es: ");
                //Creación de la matriz
                matriz = new int[filas, columnas];
                //Recorrido, llenado aleatorio de la matriz 
                while (i < filas)
                {
                    j = 0;
                    while (j < columnas)
                    {
                        matriz[i, j] = aleatorio.Next(-10, limiteRandom);
                        //Contador de numeros positivos y negativos 
                        if (matriz[i, j] < 0) cantidadNegativos++;
                        else if (matriz[i,j] > 0) cantidadPositivos++;
                        Console.Write(matriz[i, j] + " ");
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                Console.WriteLine($"La cantidad de numeros positivos es: {cantidadPositivos}");
                Console.WriteLine($"La cantidad de numeros negativos es: {cantidadNegativos}");
            }
            catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();
        }
    }
}
