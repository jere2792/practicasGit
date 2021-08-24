﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase1App
{
    public class Instructor : Persona
    {
        //Relación de 1 a muchos
        public List<Materia> Materias { get; set; }
        public Instructor() { }

        public Instructor(string d,string n,string a,List<Materia> m) : base(d, n, a)
        {
            Materias = m;
        }

        public Instructor(string n, string a, List<Materia> m) : base(n, a)
        {
            Materias = m;
        }

    }
}