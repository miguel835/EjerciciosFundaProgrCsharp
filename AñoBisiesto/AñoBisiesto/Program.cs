/*Crear un programa que determine si un año ingresado por el usuario es bisiesto o no*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int ano;
                Console.Write("Ingrese un año: ");
                ano = Convert.ToInt32(Console.ReadLine());
                if ((ano % 4 == 0) && (ano % 100 == 0) && (ano % 400 ==0)) Console.WriteLine("El año es bisiesto");
                else Console.WriteLine("El año no es bisiesto");
            } catch { Console.WriteLine("Dato no válido"); }
        }
    }
}
