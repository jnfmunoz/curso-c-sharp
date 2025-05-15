

using _20_HerenciasDeClases;

class Program : Menu // hija | padre
{
    public Program(string s) : base(s) // invocamos al método constructor de la clase que estamos heredando
    {
        
    }

    static void Main()
    {
        new Program("Empresa: JFMG").getProducto();

        Console.ReadKey();
    }

    protected override void getProducto() // sobrescribir método que estamos heredando
    {
        // Console.WriteLine(s);
    }

}
