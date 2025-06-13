using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ExcepcionesEnCSharp
{
    public class ExcepcionesPersonalizadas : Exception
    {
        public ExcepcionesPersonalizadas(string message) : base(message) 
        {
            
        } 
    }
}
