using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase1App
{
    public class Curso
    {
        public List<Estudiante> Estudiantes { get; set; }
        public Instructor Instructor { get; set; }
        public List<Clase> Clases { get; set; }  
        public Materia Materia { get; set; }

        public Curso() { }

        public Curso(List<Estudiante> estudiantes, Instructor instructor, List<Clase> clases, Materia materia)
        {
            Estudiantes = estudiantes;
            Instructor = instructor;
            Clases = clases;
            Materia = materia;
        }
    }
}