using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_AplicacionParaCrearUnaListaEnlazada
{
    public class ListaNodo
    {
        private Nodo primero;
        private int size;

        public ListaNodo()
        {
            primero = null;
            size = 0;
        }

        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato); // add el nodo
            Nodo valor1, valor2;

            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            } 
            else
            {
                valor1 = primero;
                
                while(valor1 != null)
                {
                    valor2 = valor1.siguiente;
                    // condición que verifica si el número entrante debe ir primero
                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        // condición que verifica si el número entrante debe ir al último
                        if (nuevo.dato > valor1.dato && valor2 == null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            // condición que verifica si el número entrante debe ir en medio de otro nodo
                            if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
                            {
                                valor1.siguiente = nuevo;
                                nuevo.siguiente = valor2;
                                break;
                            }
                            else
                            {
                                valor1 = valor1.siguiente;
                            }
                            
                        }
                    }
                }
            }        
        }

        public void ListaVacia()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Console.WriteLine("La lista contiene datos");
            }
        }

    }
}
