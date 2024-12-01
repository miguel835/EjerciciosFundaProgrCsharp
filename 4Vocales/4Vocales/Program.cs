//Escriba un programa que permita el ingreso de una cadena de texto y
//validar que esta cadena de texto no tenga más de 4 vocales
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Vocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Declaración de variables
            int i = 0, contadorVocales = 0;
            string cadena;
            Console.SetCursorPosition(10,0);
            Console.WriteLine("Programa para verificar si en una cadena no haya más de 4 vocales");
            Console.Write("Ingrese la cadena: ");
            //Entrada de data y lo convertimos en minusculas y eliminamos espacios
            cadena = Console.ReadLine().ToLower().Trim();
            //Recorrer la cadena
            while (i < cadena.Length)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                {
                    contadorVocales++;
                }
                //En caso de que las vocales traigan tildes
                else if (cadena[i] == 'á' || cadena[i] == 'é' || cadena[i] == 'í' || cadena[i] == 'ó' || cadena[i] == 'ú')
                {
                    contadorVocales++;
                }
                i++;
            }
            if (contadorVocales >= 5) Console.WriteLine("La cadena tiene más de 4 vocales");
            else if (contadorVocales == 0) Console.WriteLine("La cadena no tiene vocales");
            else Console.WriteLine($"La cadena no tiene más de cuatro vocales, tiene {contadorVocales} vocales");         
            Console.ReadKey();
        }
    }
}
