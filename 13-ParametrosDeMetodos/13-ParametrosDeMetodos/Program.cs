

class Program
{
    static void Main()
    {
        //Object[] parametros = { "Juan", 26, true };
        //new Program().persona(parametros);
        new Program().persona("Juan", 26, true);

        //int data = 26;
        //int data; // para out
        //new Program().metodo(out data);
        //Console.WriteLine(data);

        Console.ReadLine();
    }

    private void metodo(out int valor) // palabras clave: in, ref, out
    {
        valor = 50 * 2;
    }

    private void persona(params Object[] parametros)
    {
        String nombre = (String)parametros[0];
        int age = (int)parametros[1];
        bool soltero = (bool)parametros[2];

        Console.WriteLine("Nombre: " + nombre + "\n"+ "Edad: " + age + "\n" + "Soltero: " + soltero);
    }
}
