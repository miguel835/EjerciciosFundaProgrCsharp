//Ejercicio de edad del usuario
/*Diseñe un algoritmo que permita solicitar la edad del usuario. Si la edad del usuario es mayor que 20 y menor 
que 30, entonces se imprime por pantalla un mensaje "Selecccionado" en caso contrario "No seleccionado".
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadDelUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad > 20 && edad < 30) Console.WriteLine("Seleccionado");
            else Console.WriteLine("No seleccionado");
            Console.ReadKey();

        }
    }
}
