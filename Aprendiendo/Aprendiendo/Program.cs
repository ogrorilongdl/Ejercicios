using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo
{
    public class Program
    {
        static void Main(string[] args)
        {


            List<Alumno> list2 = new List<Alumno>();
          List<Alumno> list = new List<Alumno>
          
            { 
              new Alumno {nombre = "Pedro", edad = 2}, 
              new Alumno {nombre = "carlos", edad = 23}, 
              new Alumno {nombre = "chris", edad = 2123} 
            
            
            };

            foreach (var item in list)
            {
                Console.WriteLine($" tu nombre{ item.nombre } y tu edad { item.edad}");
                list2.Add(item);
                
            }

            foreach (var item in list2) {


                Console.WriteLine($" agregados aqui ---> {item.nombre} y tu edad {item.edad}");

            }



            Console.ReadLine();

            
        }
    }
}
