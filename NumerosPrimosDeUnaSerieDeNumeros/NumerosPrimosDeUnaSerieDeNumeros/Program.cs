//Escriba un programa que pida al usuario una serie de números y muestre la cantidad de números primos que hay.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimosDeUnaSerieDeNumeros
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
                int cantidadDeNumeros, i = 1, j, cantidadPrimos = 0;
                float numeros, contador = 0;
                string colección = " ";
                //Ingreso de numeros 
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("PROGRAMA PARA OBTENER LA CANTIDAD DE NUMEROS PRIMOS DE UNA SERIE");
                Console.Write("Ingrese la cantidad de numeros a ingresar: ");
                cantidadDeNumeros = int.Parse(Console.ReadLine());
                //Solicitud de los numeros
                while (i <= cantidadDeNumeros)
                {
                    Console.Write($"Ingrese el numero {i}: ");
                    numeros = float.Parse(Console.ReadLine());
                    //Verificación si un numero es primo 
                    for (j = 0; j <= numeros; j++)
                    {
                        if (numeros % j == 0) contador += 1;
                    }
                    if (contador == 2)
                    {
                        colección += numeros + " ";
                        cantidadPrimos++;
                    }
                    //Reseteamos el contador
                    contador = 0;
                    i++;
                }
                //Impresion de los resultados obtenidos
                Console.WriteLine($"Los numeros primos son: {colección}");
                Console.WriteLine($"La cantidad de numeros primos de la serie es: {cantidadPrimos}");
            }//Manejo para detos no esperados por parte del usuario
            catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();
        }
    }
}
