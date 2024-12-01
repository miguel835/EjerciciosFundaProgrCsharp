// Escriba un programa que pida al usuario una serie de números y muestre el mayor de ellos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeUnaSerieDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Pantalla inicial
            Console.SetCursorPosition(10,0);
            Console.WriteLine("Programa para obtener el mayor de una serie de numeros");
            try
            {
                //Declaración de variables
                int cantidadDeNumeros, i = 1;
                float numero, numeroMayor = 0;
                Console.Write("Ingrese la cantidad de numeros ha ingresar: ");
                cantidadDeNumeros = int.Parse(Console.ReadLine());
                //Bucle de ejecución para el ingreso de numero y verificación de quien es el mayor numero
                while (i <= cantidadDeNumeros)
                {
                    Console.Write($"Ingrese el numero {i}: ");
                    numero = float.Parse(Console.ReadLine());
                    if (numeroMayor < numero) numeroMayor = numero;
                    i++;
                }
                //Impresión de los resultados obtenidos
                if (numeroMayor == 0) Console.WriteLine("El numero mayor de la serie es: 0");
                else Console.WriteLine("El numero mayor de la serie es: " + numeroMayor);
                //Manejo de datos no esperados por parte del usuario 
            } catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();
        }
    }
}
