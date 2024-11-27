/*Crear un programa que solicite al usuario las notas de un estudiante en 5 materias y calcule el promedio general*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nota;
            float suma = 0, aux;
            int i = 1;
            Console.WriteLine("El formato de ingreso es: 10.00");
            try
            {
                while (i <= 5)
                {
                   
                    Console.Write($"Ingrese la nota {i}: ");
                    nota = Console.ReadLine();
                    aux = float.Parse(nota);
                    suma = suma + aux;
                    Console.WriteLine(suma);
                    i++;
                }
                //Console.WriteLine("La suma de todas las notas es: {0:N2}", suma);
                //Console.WriteLine($"El promedio del estudiante es: {suma / float.Parse("5")}");
            } catch {Console.WriteLine("Nota ingresada no valida"); }
        }
    }
}
