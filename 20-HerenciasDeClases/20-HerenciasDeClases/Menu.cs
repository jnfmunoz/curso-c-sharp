using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_HerenciasDeClases
{
    public class Menu : Almacen, IProductos
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
            getProducto(); //base.getProducto();         

        }

        public void addProductos()
        {

        }

        //public override void getProducto()
        //{
        //    Console.WriteLine(s);
        //}

        // public void getProducto()
        // protected void getProducto() // las clases derivadas tienen acceso a la clase
        /* protected virtual void getProducto()
        {
            Console.WriteLine(s);
        } */
    }

    interface IProductos
    {
        //void addProductos();
    }
}
