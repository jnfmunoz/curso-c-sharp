

using _20_HerenciasDeClases;

class Program : Menu // hija | padre
{
    public Program(string s) : base(s) // invocamos al método constructor de la clase que estamos heredando
    {

    }

    static void Main()
    {
        //new Program("Empresa: JFMG").getProducto();
        new Program("Empresa: JFMG"); //.getProducto();

        Almacen al = new Golosinas(); // crear objeto de la clase almacen  | polimorfismo

        Console.ReadKey();
    }

    //protected override void getProducto() // sobrescribir/anular/invalidar método que estamos heredando
    //{
    //   Console.WriteLine("Método sobrescrito");
    //}

}


