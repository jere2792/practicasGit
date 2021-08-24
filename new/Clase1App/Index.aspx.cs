using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase1App
{
    public partial class Index : System.Web.UI.Page
    {
        protected Array miArray;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*Persona p = new Persona();
            p.Nombre = "María";
            p.Apellido = "Campos";
            txt_nombre.Text = p.Nombre;
            txt_apellido.Text = p.Apellido;*/
        }

        protected void Form_Submit(object sender, EventArgs e) 
        {
            nombre_ingresado.Text = txt_nombre.Text;
            apellido_ingresado.Text = txt_apellido.Text;
        }

        protected void getArray()
        {
            Colecciones c = new Colecciones();
            miArray = c.getArray();
        }
    }
}