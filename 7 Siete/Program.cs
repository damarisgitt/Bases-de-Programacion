using System;

namespace Siete
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado los metros cuadrados totales de un predio 
            // y los metros cuadrados cubiertos; luego calcular y mostrar por pantalla el porcentaje
            // de metros cuadrados cubiertos y el porcentaje de metros cuadrdos descubiertos.

            int MCT, MCC, MDES, PAL,PAC; 

            Console.WriteLine("HOLA, SACAREMOS PORCENTAJES!");

            Console.WriteLine("INGRESE LOS METROS CUADRADOS TOTALES");
            MCT = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LOS METROS CUADRADOS CUBIERTOS");
            MCC = int.Parse(Console.ReadLine());

            MDES = MCT - MCC;

            PAL = MDES * 100 / MCT;

            PAC = MCC * 100/ MCT;

            Console.WriteLine("EL PORCENTAJE DE METROS DESCUBIERTOS ES: " + PAL + " Y EL PORCENTAJE DE METROS CUBIERTOS ES: " + PAC );



        }
    }
}
