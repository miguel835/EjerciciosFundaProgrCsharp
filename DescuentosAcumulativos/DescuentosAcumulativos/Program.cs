//Ejercicio de calculo de total a pagar con descuentos acumulados
/*
Diseñe un algoritmo que permita hacer el calculo del total a pagar por un monto ingresado por el usuario
despues de haber aplicado descuentos acumulativos
El programa debe funcionar de la siguiente manera:
Si el monto ingresado es mayor a 400, se aplican dos descuentos consecutivos: un 20% seguido de un 15%.
En caso contrario, se aplican dos descuentos consecutivos: un 10% seguido de un 5%.
El programa calcula el total a pagar considerando los descuentos acumulativos y lo muestra en pantalla.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentosAcumulativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double descuento1 = 0.20, descuento2 = 0.15, descuento3 = 0.10, descuento4 = 0.05, monto, totalAPagar;
            Console.Write("Ingrese un monto: ");
            monto = Convert.ToDouble(Console.ReadLine());
            if (monto > 400)
            {
                totalAPagar = monto*(1-descuento1)*(1-descuento2);
            }
            else
            {
                totalAPagar = monto*(1-descuento3)*(1-descuento4);
            }
            Console.WriteLine("El total a pagar es: " + totalAPagar);
            Console.ReadKey();
        }
    }
}
