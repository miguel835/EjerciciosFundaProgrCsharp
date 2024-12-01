//Escriba un programa que pida al usuario una serie de números y muestre la media de los números positivos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDeUnaSerieDeNumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Configuración visual de la consola
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //Declaración de variables
                int cantidadDeNumeros, i = 1;
                float numeros, suma = 0, contador = 0;
                string colección = " ";
                //Ingreso de numeros 
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("PROGRAMA PARA OBTENER LA MEDIA DE LOS NUMEROS POSITIVOS");
                Console.Write("Ingrese la cantidad de numeros a ingresar: ");
                cantidadDeNumeros = int.Parse(Console.ReadLine());
                //Solicitud de los numeros
                while (i <= cantidadDeNumeros)
                {
                    Console.Write($"Ingrese el numero {i}: ");
                    numeros = float.Parse(Console.ReadLine());
                    //Verificación si un numero es positivo y diferente a cero
                    if (numeros > 0)
                    {
                        suma += numeros; contador += 1; colección += numeros + " ";
                    }
                    i++;
                }
                //Impresion de los resultados obtenidos
                Console.WriteLine($"Los numeros positivos son: {colección}");
                Console.WriteLine($"La media de la serie es: {suma/contador}");
            } catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();
        }
    }
}
