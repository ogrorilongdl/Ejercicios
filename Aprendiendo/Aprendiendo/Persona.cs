using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo
{
    public class Persona
    {

        public int edad { get; set; }
        public string nombre { get; set; }

        public Persona()
        {
                edad = 12;
                nombre = "Carlos";
        }

        public static  void Saludar()
        {

            Console.WriteLine("Buenos dias");


        }

        public void Ejecutar () { 
        
        Console.WriteLine($" tu nombre es {nombre} y tu edad {edad}");
        
        
        }




    }
}
