/*Crear un programa que solicite al usuario sus nombres y apellidos por separado y lo salude por su nombre completo.
Para ello debe concatenar las palabras*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludoDeUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nombre, apellido;
                Console.Title = "Ejercicio de saludo del usuario";
                Console.Write("Ingrese su nombre: ");
                nombre = Convert.ToString(Console.ReadLine());
                Console.Write("Ingrese su apellido: ");
                apellido = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Saludos " + nombre + " " + apellido);
            } catch { Console.WriteLine("Ha ocurrido un error en la ejecución"); }
        }
    }
}
