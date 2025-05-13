using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_AplicacionParaCrearUnaListaEnlazada
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;

        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

    }
}
