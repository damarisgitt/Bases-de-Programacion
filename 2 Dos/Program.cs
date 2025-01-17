using System;

namespace Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un numero y luego devolver su valor elevado al cubo!
            
            float CUBO, RESPUESTA;

            Console.WriteLine("INGRESE UN NUMERO PARA ELEVARLO AL CUBO");

            CUBO = float.Parse(Console.ReadLine());

            RESPUESTA = CUBO * CUBO * CUBO;

            Console.WriteLine("EL VALOR DE ELEVAR " + CUBO + " AL CUBO ES: " + RESPUESTA);


            
                
            
            
        }
    }
}
