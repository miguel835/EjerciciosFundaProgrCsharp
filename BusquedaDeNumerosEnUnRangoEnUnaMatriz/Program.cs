/*
Ejercicio a resolver: Desarrollar un programa en lenguaje C# que llene una matriz de 10 x 8 con números aleatorios enteros positivos.

Utilizar bucles para recorrer toda la matriz buscando números en entre 20 y 30, o entre 40 y 50, contando cuales son y cuántos son.

Desplegar el listado de números en el rango especificado e indicar cuantos son.

PARA ESTE EJERCICIO YO ELEGI EL RANGO ENTRE 40 Y 50. 

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("Programa para buscar numeros entre 40 y 50 en una matriz de 10 x 8");
            Console.WriteLine("La matriz generada es: ");
            //Declaración de variables 
            int filas = 10, columnas = 8, contador = 0;
            Random aleatorio = new Random();
            int[,] matriz = new int[filas, columnas];
            //Recorrido de la matriz
            int i = 0, j = 0;
            while (i < filas)
            {
                j = 0;
                while (j < columnas)
                {
                    //Llenado de la matriz con numeros aleatorios de 1 hasta 100
                    matriz[i, j] = aleatorio.Next(1,100);
                    //Impresion de los valores
                    Console.Write(matriz[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            //Busqueda de numeros en un rango de 40 y 50 
            i = 0; j = 0;
            while (i < filas)
            {
                j = 0;
                while (j < columnas)
                {
                    if (matriz[i,j] >= 40 && matriz[i,j] <= 50)
                    {
                        //Impresión de cuales son los numeros encontrados
                        Console.WriteLine($"Numero {matriz[i, j]} encontrado en la posición [{i},{j}]");
                        contador++;   
                    }
                    j++;
                }
                i++;
            }
            if (contador == 0) Console.WriteLine("No se encontro ningun numeros entre 40 y 50");
            else Console.WriteLine($"La cantidad de numeros encontrados es de {contador}");
            Console.ReadKey();
        }
    }
}
