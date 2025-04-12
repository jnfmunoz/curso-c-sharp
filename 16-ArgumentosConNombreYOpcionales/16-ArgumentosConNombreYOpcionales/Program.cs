

class Program
{
    readonly int valor; // readonly int valor = 23;
    const int VALOR_2 = 98; 

    public Program()
    {
        valor = 10;
    }

    static void Main()
    {
        var data = new Program();
        //data.Metodo("C#", "Juan"); //, 85);

        //data.Metodo(cantidad: 32, curso: "C#");
        //data.Metodo(cantidad: null, curso: null);        

        Console.WriteLine($"{ data.valor }, { VALOR_2}");
        Console.ReadLine();
    }

    //private void Metodo(String curso, String nombre, int cantidad = 69) // parametros, argumentos opcionales, por defecto
    private void Metodo(String curso, int? cantidad, String nombre = "Juan") // argumentos con nombres
    {
        Console.WriteLine(curso + ' ' + nombre + ' ' + cantidad);
        Console.ReadLine();
    }


}
