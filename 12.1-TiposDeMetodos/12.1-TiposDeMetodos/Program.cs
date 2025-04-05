

class Program
{
    private String names;

    static void Main()
    {
        var data = new Program();
        var name = data.MetodoPrivado();
        var edad = data.Edad();
        String names;
        Console.WriteLine(name);
        Console.WriteLine(edad);
        Console.ReadLine();
    }

    private string MetodoPrivado()
    {
        //return $"Juan Muñoz {26}";
        names = "";
        return "Juan Muñoz";
    }

    private int Edad()
    {
        return Convert.ToInt16("26");
    }

    /*
    private void MetodoPublico()
    {
        Console.WriteLine("Hola, soy un método público");
        Console.ReadLine();
    }
    */

}