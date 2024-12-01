//Escriba un programa que permita contar los números múltiplos de 6 que hay entre 1 y 1000
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe6
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
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Programa para calcular la cantidad de multiplos de 6 que hay entre 1 y 1000");
                //Declaración de variables
                int i = 0, contador = 0, j = 1;
                string colección = " ";
                //Comprobación de los numeros multiplos de 6 
                while (i <= 1000)
                {
                    if (i % 6 == 0)
                    {
                        contador++;
                        colección += i + " ";
                    }
                    i++;
                }
                Console.WriteLine($"Los numeros multiplos de 6 son: {colección}");
                Console.WriteLine($"Hay {contador} numeros multiplos de 6 ");
            } catch { Console.WriteLine("Ha ocurrido un error"); }
            Console.ReadKey();
        }
    }
}
