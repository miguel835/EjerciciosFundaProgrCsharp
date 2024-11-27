//Ejercicio de Impresion de n lineas por el usuario
/* Diseñe un algoritmo que permita imprimir n cantidad de lineas por el uuario 
utilize los siguientes nombres: Samantha, Adrian, Alex
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ImpresionDeNCantidadLineas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nombre1 = "Samantha", nombre2 = "Adrian", nombre3 = "Alex";
                int nLineas, i = 0;
                Console.Write("Ingrese la cantidad de lineas: ");
                nLineas = int.Parse(Console.ReadLine());
                while (i < nLineas)
                {
                    if (i % 3 == 0) Console.WriteLine(nombre1);
                    if (i % 3 == 1) Console.WriteLine(nombre2);
                    if (i % 3 == 2) Console.WriteLine(nombre3);
                    i++;
                }
            } catch { Console.WriteLine("Dato ingresado no valido"); }
            Console.ReadKey();
        }
    }
}
