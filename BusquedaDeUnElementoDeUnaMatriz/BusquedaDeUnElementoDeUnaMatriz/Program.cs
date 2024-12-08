/* Crear una matriz bidimensional de enteros, solicitar al usuario un valor entero a buscar, recorrer la matriz y buscar
el elemento especificado, indicar si el elemento se encuentra en la matriz y en que posición7*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaDeUnElementoDeUnaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int[,] matriz;
                int filas, columnas, i = 0, j, limiteRandom, numeroBusqueda, contador = 0;
                Random aleatorio = new Random();
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //Titulo del programa
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para buscar un elemento en una matriz");
                //Configuración de la matriz
                Console.Write("Ingrese el numero de filas: ");
                filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero de columnas: ");
                columnas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el numero limite para el llenado aleatorio: ");
                limiteRandom = int.Parse(Console.ReadLine());
                //Creación de la matriz
                matriz = new int[filas, columnas];
                //Recorrido, llenado aleatorio de la matriz 
                while (i < filas)
                {
                    j = 0;
                    while (j < columnas)
                    {
                        matriz[i, j] = aleatorio.Next(1, limiteRandom);
                        j++;
                    }
                    i++;
                }
                Console.Write("Ingrese un numero a buscar en la matriz: ");
                numeroBusqueda = int.Parse(Console.ReadLine());
                //Busqueda del numero en la matriz
                for (i = 0; i < filas; i++)
                {
                    for (j = 0; j < columnas; j++)
                    {
                        if (matriz[i, j] == numeroBusqueda)
                        {
                            Console.WriteLine($"El numero {numeroBusqueda} ha sido encontrado en la posición [{i},{j}]");
                            contador++;
                        }
                    }
                }
                if (contador == 0) Console.WriteLine($"No hay ningun numero {numeroBusqueda} en la matriz");
            } catch { Console.WriteLine("Dato ingresado no valido"); }
        }
    }
}
