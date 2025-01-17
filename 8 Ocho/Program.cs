using System;

namespace Ocho
{
    class Program
    {
        static void Main(string[] args)

        {
            //Una importante cadena de delivery cuanta con una promocion por tiempo limitado en la que otorga un 15%
            // de descuento sobre el total del valor de la compra realizada. hacer un programa para solicitar el 
            // monto total y el mismo calcule y emita por pantalla  el total a cobrar con el descuento aplicado.

             float compra, resultado, descuento;

             Console.WriteLine("INGRESE EL VALOR DE SU COMPRA");
             compra = float.Parse(Console.ReadLine());

             descuento = 15 * compra / 100;
             resultado = compra - descuento;

             Console.WriteLine("EL VALOR A PAGAR CON EL DESCUENTO APLICADO ES: " + resultado);

        }
    }
}
