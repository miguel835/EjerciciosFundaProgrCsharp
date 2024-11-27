/*Crear un programa que permita convertir unidades de temperatura (Celsius a Fahrenheit y viceversa). */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double temperatura;
                int opcion;
                Console.Write("Ingrese la temperatura: ");
                temperatura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("[0] Convertir a Celsius");
                Console.WriteLine("[1] Convertir a Fahrenheit");
                Console.Write("Selecciona una de las opciones: ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 0) Console.WriteLine($"La temperatura en Celsius es: {((temperatura - 32) * (5 / 9)):F2} ");
                else Console.WriteLine($"La temperatura en Faherenheit es: {((temperatura * (9 / 5)) + 32):F2}");
            } catch {Console.WriteLine("Dato ingresado incorrecto"); }
        }
    }
}
