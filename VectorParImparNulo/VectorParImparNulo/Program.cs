//Vector Par Impar Nulo
/*Diseñe un algoritmo que permita crear un vector o arreglo, luego que permita añadir elementos enteros a este y finalmente
que determine se lea el vector y se determina la cantidad de numeros pares, impares y nulos. Adicionalmente mostrar por
pantalla los numeros mencionados. Haga uso de por lo menos una vez del operador terneario. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorParImparNulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] vector;
                int par = 0, impar = 0, nulo = 0;
                string npar = "", nimpar = "";
                Console.WriteLine("¿Cuantos elementos va a ingresar en el vector?");
                int n = int.Parse(Console.ReadLine());
                vector = new int[n];
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write($"Ingrese el elementos vector[{i}]:");
                    vector[i] = int.Parse(Console.ReadLine());
                    var aux = (vector[i] % 2 == 0) ? par += 1 : impar += 1;
                    if (vector[i] == 0) Console.WriteLine(nulo += 1);
                    if (vector[i] % 2 == 0) npar = npar + vector[i] + " ";
                    else if (vector[i] % 2 ==1) nimpar = nimpar + vector[i] + " ";
                }
                Console.WriteLine("La cantidad de numeros pares es: {0}", par);
                Console.WriteLine("La cantidad de numeros impares es: {0}", impar);
                Console.WriteLine("La cantidad de numeros nulos es: {0}", nulo);
                Console.WriteLine("Los numeros pares es: {0}", npar);
                Console.WriteLine("Los numeros impares es: {0}", nimpar);
            } catch { Console.WriteLine("Dato ingresado no valido"); }
            Console.ReadKey();
        }
    }
}
