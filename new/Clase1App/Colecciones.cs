using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase1App
{
    public class Colecciones
    {
        public Array getArray() 
        {
            Array array = new int[] { 12, 24, 48, 96 };
            return array;        
        }

        public List<string> getListStrings()
        {
            List<string> listadoString = new List<string>();
            listadoString.Add("Hola");
            listadoString.Add("Mundo");
            listadoString.Add("Otra palabra");
            listadoString.Add("Y otra palabra mas");
            listadoString.Remove("Mundo");
            
            return listadoString;
        }

        public List<Persona> getPersonas()
        {
            List<Persona> personas = new List<Persona>();
            Persona p1 = new Persona("132456","Maria", "Perez");
            Persona p2 = new Persona("789465","Pedro", "Gonzalez");
            Persona p3 = new Persona("456789","Margarita", "Rodriguez");
            Persona p4 = new Persona("456888", "Matias", "Re");

            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            personas.Add(p4);

            return personas;
        }
    }
}