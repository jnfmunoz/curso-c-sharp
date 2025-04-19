using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Propiedades
{
    public class Estudiante
    {
        private String nombre; 

        //public String nombre { get; set; } = "Juan";
        public String Nombre
        {
            set { nombre = value; }
        }
    }
}
