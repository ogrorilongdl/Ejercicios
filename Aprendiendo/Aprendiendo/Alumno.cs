using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo
{
    public class Alumno : Persona
    {
        public int MateriaAlumno { get; set; }

        public Alumno()
        {
            MateriaAlumno = 1;
        }
        public void SaludoAlumno() {

            Console.WriteLine($" saludos desde el alumno {MateriaAlumno}");
        
        
        }
    }
}
