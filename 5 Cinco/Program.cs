using System;

namespace Cinco
{
    class Program
    {
        static void Main(string[] args)
        {
           //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión 
           //del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total 
           //facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar 
           //por el mismo.

           float facturado, comisión, total;
           
            Console.WriteLine("INGRESE EL TOTAL FACTURADO");
            facturado = float.Parse(Console.ReadLine());
            
            comisión = facturado * 0.05F;

            total = comisión + 15000;

            Console.WriteLine("SU SUELDO DE ESTE MES ES: " + total);

        }
    }
}
