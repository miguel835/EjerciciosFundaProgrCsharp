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
            double nota, suma = 0;
            int i = 1;
            try
            {
                while (i <= 5)
                {
                    Console.Write($"Ingrese la nota {i}: ");
                    nota = Convert.ToDouble(Console.ReadLine());
                    suma = suma + nota;
                    i++;
                }
                Console.WriteLine("La suma de todas las notas es: {0}", suma);
                Console.WriteLine($"El promedio del estudiante es: {suma / 5}");
                Console.ReadKey();
            } catch {Console.WriteLine("Nota ingresada no valida"); }
        }
    }
}
