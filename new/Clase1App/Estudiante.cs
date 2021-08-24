using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase1App
{
    public class Estudiante:Persona
    {
        public bool Regular { get; set; }

        public Estudiante() { }
        public Estudiante(string d,string n,string a,bool r) : base(d, n, a)
        {
            Regular = r;
        }
        public Estudiante(string n, string a, bool r) : base(n, a)
        {
            Regular = r;
        }
    }
}