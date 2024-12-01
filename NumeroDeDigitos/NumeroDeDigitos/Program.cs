/*Escriba un programa que pida al usuario un número y muestre el número de dígitos que tiene.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroDeDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            try
            {
                //Declaración de variables 
                float numero;
                string cadenaNumero;
                int contador = 0;
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("PROGRAMA PARA MOSTRAR EL NUMERO DE DIGITOS DE UNA CANTIDAD DADA");
                Console.Write("Ingrese un numero: ");
                //Ingreso de datos
                numero = float.Parse(Console.ReadLine());
                //Conversión del numero a cadena y eliminamos los espacios en blancos
                cadenaNumero = Convert.ToString(numero).Trim();
                contador = cadenaNumero.Count();
                //Restamos uno del contador si el numero contiene un menos
                if (cadenaNumero.Contains('-')) contador -= 1;
                //Restamos uno del contador si el numero contiene una coma
                if (cadenaNumero.Contains(',')) contador -= 1;
                Console.WriteLine("La cantidad de digitos de {0} es: {1}", numero, contador);
            }
            catch { Console.WriteLine("Dato ingresado erroneo"); }
            Console.ReadKey();
        }
    }
}
