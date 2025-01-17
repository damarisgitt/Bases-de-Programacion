using System;

namespace Cuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar los kilometros existentes entre dos ciudades
            // y la velocidad promedio de un vehiculo . Calcular y emitir por pantalla el tiempo 
            //aproximado que demandara llegar de un punto a otro teniendo en cuenta los datos ingresados.

            float kilometros, velocidad, hora;

            Console.WriteLine("HOLA, VAMOS AVERIGUAR CUANTO TIEMPO LE DEMANDARA LLEGAR A DESTINO");
            Console. WriteLine(" INGRESE LA CANTIDAD DE KILOMETROS");

            kilometros = float.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA VELOCIDAD PROMEDIO");

            velocidad = float.Parse(Console.ReadLine());

            hora = kilometros / velocidad;

            Console.WriteLine(" EL TIEMPO QUE LE DEMANDA LLEGAR HASTA DESTIDO ES DE: " + hora + " HORA!");
            Console.WriteLine("BUEN VIAJE");
             
        }
    }
}
