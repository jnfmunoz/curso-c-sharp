

using _17_Propiedades;

class Program
{
    static void Main()
    {
        var data = new Estudiante();
        //var nombre = data.Nombre;
        data.Nombre = "Francisco";

        Console.WriteLine(data.Nombre);
        Console.ReadLine();
    }
}
