using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_TiendaDeGolosinas
{
    public class Menu : IMenu
    {
        Almacen g = new Golosinas();

        public void golosinas()       
        {
            var des = "";
            var valor = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Venta de golosinas");
                if (g.getProducto().Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Agregar golosinas? Presione las teclas s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuántas golosinas va a agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());

                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva golosina");
                            Console.WriteLine("Ingrese id producto");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre producto");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese precio producto");
                            var precio = Convert.ToDouble(Console.ReadLine());

                            g.addProducto(new Producto
                            {
                                ID = id,
                                Nombre = nombre,
                                Precio = precio
                            });
                        }

                        Console.WriteLine("Desea ir al inicio? s/n");
                        des = Console.ReadLine();

                        if (des.Equals("s"))
                        {
                            valor = true;
                        }
                        else if (des.Equals("n"))
                        {
                            valor = false;
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de golosinas y frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach (var item in g.getProducto())
                    {
                        Console.WriteLine($"Código {item.ID} Golosina {item.Nombre} Precio {item.Precio} ");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    des = Console.ReadLine();

                }

            }
            while (valor);
        }

        public void ventas()          
        {
            throw new NotImplementedException();
        }

        public double solicitarPago() 
        {
            throw new NotImplementedException();
        }
    }
}
