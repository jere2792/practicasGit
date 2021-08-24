using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase1App
{
    public partial class EjemploCursos : System.Web.UI.Page
    {
        protected Curso MiCurso;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CrearCursos();
        }

        protected void CrearCursos()
        {
            Estudiante es1 = new Estudiante("123456","Maria", "Perez", true);
            Estudiante es2 = new Estudiante("456789","Pedro", "Ramirez", true);
            Estudiante es3 = new Estudiante("789456","Noelia", "Jota", true);
            Estudiante es4 = new Estudiante("789456", "Noelia", "Jota", true);
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(es1);
            estudiantes.Add(es2);
            estudiantes.Add(es3);
            estudiantes.Add(es4);


            Materia m1 = new Materia("PHP", "Programa de PHP");
            Materia m2 = new Materia("C#", "Programa de C#");
            List<Materia> materias = new List<Materia>();
            materias.Add(m1);
            materias.Add(m2);

            Instructor i1 = new Instructor("1236456","Carla", "García",materias);

            Aula a1 = new Aula("0010", 15);
            Aula a2 = new Aula("0012", 10);
            Clase c1 = new Clase(DateTime.Parse("24/8/2021 7:00:00 PM"), DateTime.Parse("24/8/2021 10:00:00 PM"), a1);
            Clase c2 = new Clase(DateTime.Parse("31/8/2021 7:00:00 PM"), DateTime.Parse("31/8/2021 10:00:00 PM"), a1);
            Clase c3 = new Clase(DateTime.Parse("7/9/2021 7:00:00 PM"), DateTime.Parse("7/9/2021 10:00:00 PM"), a2);

            List<Clase> clases = new List<Clase>();
            clases.Add(c1);
            clases.Add(c2);
            clases.Add(c3);

            MiCurso = new Curso(estudiantes,i1,clases,m1);
        }
    }
}