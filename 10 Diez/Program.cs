using System;

namespace Diez
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, suma, resta, division, multi;

            Console.WriteLine("HOLA, VAMOS A REALIZAR UNAS OPERACIONES BASICAS, EN LA CUAL VAMOS A COMENZAR INGRESANDO DOS NUMEROS");
            Console.WriteLine("INGRESE EL PRIMER NUMERO");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2;

            resta = n1 - n2;

            division = n1 / n2;

            multi = n1 * n2;

            Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + suma);
            Console.WriteLine("EL RESULTADO DE LA RESTA ES: " + resta);
            Console. WriteLine("EL RESULTADO DE LA DIVISION ES: " + division);
            Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION ES: " + multi);

             
        }
    }
}
