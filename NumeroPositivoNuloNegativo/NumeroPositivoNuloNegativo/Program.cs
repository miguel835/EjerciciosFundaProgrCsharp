//Ejercicio de Numero positivo nulo negativo
/*Diseñe un algoritmo que permita determinar si un numero es positivo, negativo o nulo 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPositivoNuloNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 0) Console.WriteLine("El numero es nulo");
                else if (num > 0) Console.WriteLine("El numero es positivo");
                else Console.WriteLine("El numero es negativo");
            } catch (Exception ex) { Console.WriteLine("Ha ingresado un dato erroneo " + ex); }

        }
    }
}
