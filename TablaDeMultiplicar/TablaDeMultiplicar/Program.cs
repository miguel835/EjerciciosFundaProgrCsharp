/*Crear un programa que genere y muestre la tabla de multiplicar (hasta el 12) de un número ingresado por el usuario*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero, i = 0;
                Console.Write("Ingrese un numero: ");
                numero = Int32.Parse(Console.ReadLine());
                while (i != 13) Console.WriteLine($"{i} * {numero} = {i * numero}"); i++;
            }
            catch { Console.WriteLine("Dato ingresado no valido"); }
        }
    }
}
