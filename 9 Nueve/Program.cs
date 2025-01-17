using System;

namespace Nueve
{
    class Program
    {
        static void Main(string[] args)
        {
            // UNA UNIVERSIDAD DESEA CONOCER LOS PORCENTAJES DE MUJERES Y HOMBRES EN LAS CARRERAS
            // DE CIENCIAS EXACTAS.SE SOLICITA UN PROGRAMA PARA CARGAR LA CANTIDAD DE MUJERES Y LA CANTIDAD 
            // DE HOMBRES Y QUE EL MISMO CALCULE Y EMITA POR PANTALLA LOS PORCENTAJES CORRESPONDIENTES!

            int hombres, mujeres, total, pm, ph;

            Console.WriteLine("VAMOS A CONOCER LOS PORCENTAJES DE MUJERES Y HOMBRES, DE LAS CARRERAS DE CIENCIAS EXACTAS ");
            Console.WriteLine("INGRESE LA CANTIDAD DE MUJERES");
            mujeres = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA CANTIDAD DE HOMBRES");
            hombres = int.Parse(Console.ReadLine());

            total = mujeres + hombres;

            pm = mujeres * 100 / total;
            ph = hombres * 100 / total;

            Console.WriteLine("EL PORCENTAJE DE MUJERES ES: " + pm);
            Console.WriteLine("EL PORCENTAJE DE HOMBRES ES: " + ph);

        }
    }
}
