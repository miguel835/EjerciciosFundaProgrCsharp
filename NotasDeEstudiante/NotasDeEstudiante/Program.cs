//Ejercicio de notas de estudiantes
/*Diseñe un algoritmo que permita leer la nota de un estudiante y que evalue segun los siguientes criterios:
10,5 = Insuficiente
11 = Suficiente
15 = Bien
18 = Notable
20 = Sobresaliente
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasDeEstudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese la nota del estudiante: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                if (nota < 0 && nota > 20) Console.WriteLine("La nota ingresado no esta en el rango de 0 a 20");
                else
                {
                    if (nota == 20) Console.WriteLine("La nota del estudiante es sobresaliente");
                    else if (nota < 20 && nota >= 18) Console.WriteLine("La nota del estudiante es notable");
                    else if (nota < 18 && nota >= 15) Console.WriteLine("La nota del estudiante es bien");
                    else if (nota < 15 && nota >= 10.5) Console.WriteLine("La nota del estudiante es suficiente");
                    else Console.WriteLine("La nota del estudiante es insuficiente");
                }
            } catch { Console.WriteLine("La nota ingresada no es valida"); }

        }
    }
}
