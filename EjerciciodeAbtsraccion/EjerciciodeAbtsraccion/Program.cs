using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciodeAbtsraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("chris", 35, 1234m);

            Console.WriteLine($"tu nombre es {empleado.Nombre} , tu edad es {empleado.Edad} y tu sueldo es de {empleado.Sueldo}");

            Console.ReadKey();
        
        }
    }
}
