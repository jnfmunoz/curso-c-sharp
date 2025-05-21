using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Almacen
{
    public abstract List<Producto> getProducto(String valor);
    public abstract void addProducto(Producto producto);

}
