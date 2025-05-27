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
        Almacen f = new Frutas();

        public void iniciar()
        {
            int des = -1;

            do
            {
                Console.WriteLine("Almacen");
                Console.WriteLine("Seleccione una opción \n 1) Gestión/Venta de Frutas \n 2) Gestión/Venta de Golosinas \n 0) Salir");
                des = int.Parse(Console.ReadLine());

                if (des == 1)
                {
                    frutas();
                }
                else if (des == 2)
                {
                    golosinas();
                }
            }
            while (des != 0);

        }

        public void frutas()
        {
            var des = "";
            var valor = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Gestión/Venta de frutas");
                if (f.getProducto("").Count.Equals(0))
                {
                    Console.WriteLine("No hay frutas");
                    Console.WriteLine("Agregar frutas? Presione las teclas s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuántas frutas desea agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());

                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva frutas");
                            Console.WriteLine("Ingrese id producto");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre producto");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese precio producto");
                            var precio = Convert.ToDouble(Console.ReadLine());

                            f.addProducto(new Producto
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
                    Console.WriteLine("Lista de frutas");
                    foreach (var item in f.getProducto(""))
                    {
                        Console.WriteLine($"Código {item.ID} Fruta {item.Nombre} Precio {item.Precio} ");
                    }
                    Console.WriteLine("Desea realizar ventas de frutas? s/n");
                    des = Console.ReadLine();

                    if (des.Equals("s"))
                    {
                        ventas(f);
                    }
                    else
                    {
                        valor = false;
                    }

                }

            }
            while (valor);

        }

        public void golosinas()       
        {
            var des = "";
            var valor = false;

            do
            {
                Console.Clear();                
                Console.WriteLine("Gestión/Venta de golosinas");
                if (g.getProducto("").Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Agregar golosinas? Presione las teclas s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuántas golosinas desea agregar?");
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
                    foreach (var item in g.getProducto(""))
                    {
                        Console.WriteLine($"Código {item.ID} Golosina {item.Nombre} Precio {item.Precio} ");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    des = Console.ReadLine();

                    if (des.Equals("s"))
                    {
                        ventas(g);   
                    }
                    else
                    {
                        valor = false;
                    }

                }

            }
            while (valor);
        }

        public double solicitarPago() 
        {
            bool pagoCorrecto = false;
            double res = 0;

            while (!pagoCorrecto)
            {
                Console.WriteLine("Cómo desea pagar con: 10, 5");
                res = double.Parse(Console.ReadLine());
                if (res != 5 && res != 10)
                {
                    Console.WriteLine("Pago no válido");
                }
                else
                {
                    pagoCorrecto = true;
                }
            }

            return res;
        }

        public void ventas(Almacen almacen)
        {
            double total = 0;
            string des = "";

            do
            {
                Console.WriteLine("Ingrese el producto");
                string producto = Console.ReadLine();
                var productos = almacen.getProducto(producto);

                while (productos.Count.Equals(0))
                {
                    Console.WriteLine("Golosina no disponible, por favor seleccione otro:");
                    producto = Console.ReadLine();
                    productos = g.getProducto(producto);
                }

                Console.WriteLine($"Su monto a pagar es: {productos[0].Precio} $ Dolar");
                double pago = solicitarPago();

                while (pago < productos[0].Precio)
                {
                    Console.WriteLine("Faltan " + (productos[0].Precio - pago).ToString() + " $ Dolar");
                    pago += solicitarPago();
                }

                Console.WriteLine("Su cambio: " + (pago - productos[0].Precio).ToString());
                total += productos[0].Precio;
                Console.WriteLine("Su pago fue de: " + total.ToString() + " $ Dolar");
                
                Console.WriteLine("Desea realizar otra compra? s/n");
                des = Console.ReadLine();

            }
            while (des.Equals("s"));
        }

    }
}
