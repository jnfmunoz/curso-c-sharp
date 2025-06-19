using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23_ExcepcionesEnCSharp
{
    public class Books<T> where T : Book // clases genéricas, para crear colecciones de objetos
    {
        private Nodo<T> primero;
        private int size;

        public void Add(T obj)
        {
            var nuevo = new Nodo<T>(obj);
            Nodo<T> valor;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                valor = primero;
                while (valor != null)
                {
                    nuevo.next = primero;
                    primero = nuevo;
                    break;
                }
            }

            size++;
        }

        public T Get(int index)
        {
            var actual = primero;
            T obj = null;
            int count = size;
            count--;

            for (int i = count; i >= 0; i--)
            {
                if (index == i)
                {
                    obj = actual.obj;
                    break;
                }
                actual = actual.next;
                count--;
            }

            return obj;

        }

        /* private T book;
        public T Book
        {
            get { return book; }
            set { book = value; }
        } */

    }
}
