


public abstract class Almacen // clase que no puede ser instanciada
{
    //public abstract void getProducto();

    /* public void getProducto()
    {
        Console.WriteLine("getProducto() de la clase Principal");
    } */

    public abstract List<Producto> getProducto(String valor);
    public abstract void addProducto(Producto producto);

}
