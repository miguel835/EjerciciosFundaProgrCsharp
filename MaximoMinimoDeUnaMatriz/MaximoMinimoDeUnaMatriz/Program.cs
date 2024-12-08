/*Crear una matriz bidimensionales de enteros, inicializar variables para el maximo y el minimo con valores adecuados,
recorrer la matriz y comparar cada elemento con el maximo y el minimo actualizados, actualizar las variables del maximo
y minimo si es necesario, imprimir el valor maximo y el valor minimo en la consola.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximoMinimoDeUnaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaración de variables
                int[,] matriz;
                int filas, columnas, i = 0, j, limiteRandom, maximo = 0, minimo = 0;
                Random aleatorio = new Random();
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //Titulo del programa
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para buscar el minimo y maximo en una matriz");
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
                        //Busqueda del maximo
                        if (maximo < matriz[i, j]) maximo = matriz[i, j];
                        Console.Write(matriz[i,j] + " ");
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                Console.WriteLine($"El maximo de la matriz es: {maximo}");
                //Busqueda del minimo 
                i = 0;
                while(i < filas)
                {
                    j = 0;
                    while (j < columnas)
                    {
                        if (matriz[i, j] < maximo)
                        {
                            minimo = matriz[i, j];
                            maximo = matriz[i, j];
                        }
                        j++;
                    }
                    i++;
                }
                Console.WriteLine($"El minimo de la matriz es: {minimo}");
            }
            catch { Console.WriteLine("Dato ingresado no valido"); }
            Console.ReadKey();
        }
    }
}
