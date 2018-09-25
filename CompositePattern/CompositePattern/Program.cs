using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Clases;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado CEO = new Empleado("Richard", "CEO", 300000);
            Empleado ventas = new Empleado("Gregorio", "Jefe de ventas", 250000);
            Empleado desarrollo = new Empleado("Genaro", "Jefe de desarrollo", 20000);

            Empleado empleado1 = new Empleado("Jota", "Programador Full Stack", 2500);
            Empleado empleado2 = new Empleado("Gustavo", "Programador Web", 2500);

            Empleado ejecutivo1 = new Empleado("Borgia", "Ventas", 10000);
            Empleado ejecutivo2 = new Empleado("Sonia", "Ventas", 150000);

            CEO.Agregar(ventas);
            CEO.Agregar(desarrollo);

            ventas.Agregar(ejecutivo1);
            ventas.Agregar(ejecutivo2);

            desarrollo.Agregar(empleado1);
            desarrollo.Agregar(empleado2);

            Console.WriteLine(CEO);

            foreach (var subordinado in CEO.ObtenerSubordinados())
            {
                Console.WriteLine("\t" + subordinado);

                foreach (var empleado in subordinado.ObtenerSubordinados())
                {
                    Console.WriteLine("\t\t" + empleado);
                }
            }
        }
    }
}
