﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase1App
{
    public partial class ColecccionesIndex : System.Web.UI.Page
    {
        protected Array miArray;
        protected List<string> listCadenas;
        protected List<Persona> listadoPersonas;
        protected void Page_Load(object sender, EventArgs e)
        {
            getArray();
            getListCadena();
            obtenerPersonas();
        }

        protected void getArray()
        {
            Colecciones c = new Colecciones();
            miArray = c.getArray();
        }

        protected void getListCadena()
        {
            Colecciones c = new Colecciones();
            listCadenas = c.getListStrings();
        }

        protected void obtenerPersonas()
        {
            Colecciones c = new Colecciones();
            listadoPersonas = c.getPersonas();
        }
    }
}