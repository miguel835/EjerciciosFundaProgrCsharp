/*Escriba un programa que pida al usuario un numero y muestre la suma de todos los numeros pares desde el 1 hasta ese numero*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDePares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Configuración visual de consola
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                //Ingreso de datos
                int numero, i = 1, suma = 0;
                string coleccion = " ";
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para la suma de numeros pares en un rango de 1 hasta n");
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                //Proceso de suma de numeros pares
                while (i <= numero)
                {
                    if (i % 2 == 0)
                    {
                        suma += i;
                        coleccion += i + " ";
                    }
                    i++;
                }
                //Muestra de resultados 
                Console.WriteLine($"Los numeros pares son: {coleccion}");
                Console.WriteLine($"La suma entre los pares de 1 hasta {numero} es: {suma}");
            }
            //Manejo cuando para los datos no esperados
            catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();

        }
    }
}
