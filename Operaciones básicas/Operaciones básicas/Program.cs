/*Crear un programa que realice las operaciones básicas aritmeticas (suma, resta, multiplicación y división) entre dos
numeros ingresados por el usuario*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_básicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double numero1, numero2;
                Console.Write("Ingrese un numero: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese otro numero: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Suma: {numero1 + numero2}");
                Console.WriteLine($"Resta: {numero1 - numero2}");
                Console.WriteLine($"Multiplicación: {numero1 * numero2}");
                Console.WriteLine($"División: {numero1 / numero2}");
            } catch { Console.WriteLine("Dato ingresado incorrecto"); }
            
        }
    }
}
