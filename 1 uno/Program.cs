using System;

namespace uno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar dos numeros, y luego devolver la suma de esos dos numeros!
        
            int N1, N2, SUMA;
            
            Console.WriteLine("HOLA, VAMOS HACER UNA SUMA DE DOS NUMEROS");
            Console.WriteLine("INGRESE EL PRIMER NUMERO");

            N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL SEGUNDO");

            N2 = int.Parse(Console.ReadLine());

            SUMA = N1 + N2;

            Console.WriteLine("EL RESULTADO DE TUS DOS NUMEROS ELEGIDOS ES: " + SUMA); 





        }
    }
}
