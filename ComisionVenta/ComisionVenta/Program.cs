//Ejercicio de comision de venta
/*Elabore un algoritmo que lea el numero total de ventas que un empleado ha realizado y luego de que si el numero
de ventas es mayor a 500  entonces le damos una comisión al empleado del 20% tomando el numero de ventas pero 
si el empleado en cuestión no alcanzo ese numero total de ventas establecido entonces la comisión sera de 25 dólares*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisionVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTotalDeVentas, comision;
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("COMISION DE VENTA");
            Console.Write("Ingrese el numero total de ventas: ");
            numeroTotalDeVentas = int.Parse(Console.ReadLine());
            if (numeroTotalDeVentas > 500)
            {
                Console.WriteLine("Felicidades por haber alcanzado el numero de ventas propuesto");
                comision = numeroTotalDeVentas * 20/100;
                Console.WriteLine("Su comisión es de ${0}", comision);
            }
            else
            {
                Console.WriteLine("Lametablemente no alcanzado el numero de ventas propuesto");
                comision = 25;
                Console.WriteLine("Su comisión es de ${0}", comision);
            }
            Console.ReadKey();
        }
    }
}
