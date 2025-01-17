using System;

namespace Seis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego 
            //calcule y emita por pantalla el promedio final.

            float NOTA1, NOTA2, NOTA3, PROMEDIO, NOTAFINAL;

            Console.WriteLine("HOLA, VAMOS A SACAR EL PROMEDIO DE SUS TRES NOTAS!");
            Console.WriteLine("INGRESE LA PRIMER NOTA");
            NOTA1 = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA SENGUNDA NOTA");
            NOTA2 = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA TERCER NOTA");
            NOTA3 = float. Parse(Console.ReadLine());

            PROMEDIO = NOTA1 + NOTA2 + NOTA3;

            NOTAFINAL = PROMEDIO / 3;

            Console.WriteLine("LA NOTA final: " + NOTAFINAL);







        }
    }
}
