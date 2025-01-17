using System;

namespace Tres
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que permita ingresar el año actual y la fecha de nacimiento de una persona
           // y luego calcule y emita por pantalla su edad.
           
            int AÑOACTUAL, FECHADENACIMIENTO, EDAD;

            Console.WriteLine("HOLA, VAMOS AVERIGUAR SU EDAD!");

            Console.WriteLine("INGRESE EL AÑO ACTUAL");

            AÑOACTUAL = int.Parse(Console.ReadLine());
            
            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO");

            FECHADENACIMIENTO = int.Parse(Console.ReadLine());

            EDAD = AÑOACTUAL - FECHADENACIMIENTO;

            Console.WriteLine("SU EDAD ES: " + EDAD);
        }
    }
}
