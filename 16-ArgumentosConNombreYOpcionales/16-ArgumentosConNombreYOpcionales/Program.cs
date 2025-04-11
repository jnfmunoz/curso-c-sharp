

class Program
{
    static void Main()
    {
        var data = new Program();
        data.Metodo("C#", "Juan"); //, 85);

    }

    private void Metodo(String curso, String nombre, int cantidad = 69) // argumentos opcionales, por defecto
    {
        Console.WriteLine(curso + ' ' + nombre + ' ' + cantidad);
        
}
