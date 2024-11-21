//Ejercicio de suma de cuadrados de los primeros n numeros naturales 
/*
Elabore un algoritmo que permita resolver la suma de los cuadrados de todos los numeros desde 1 hasta el numero
n dado por el usuario. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeCuadrados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            resultado = (numero*(numero+1)*(2*numero+1))/6;
            Console.WriteLine("La suma de los cuadrados desde 1 hasta " + numero + " es: " + resultado);
            Console.ReadKey();
        }
    }
}
