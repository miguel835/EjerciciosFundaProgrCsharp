//Ejercicio de Sumas de N cuadrados
/* Realice un algoritmo que calcule la suma: 1^2+2^2+3^2+N^3
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumasDeNCuadrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n, suma = 0;
                Console.Write("Ingrese la cantidad de numeros: ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i <=n; i++) suma = suma + (i^2);
                Console.WriteLine("La suma de cuadrados es: {0}", suma);
            } catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();

        }
    }
}
