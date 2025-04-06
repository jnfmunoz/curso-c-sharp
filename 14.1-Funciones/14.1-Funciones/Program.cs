

class Program
{
    static void Main()
    {
        int data;
        String nombre;
        //new Program().Metodo(out data);
        Mensaje();
        Console.WriteLine(nombre); // data
        void Mensaje() => nombre = "Juan Muñoz";
        Console.ReadLine();
    }

    private void Metodo(out int valor)
    {
        valor = Funcion();

        /*
        int Funcion()
        {
            return 50 + 20;
        }
        */
        static int Funcion() => 50 + 20;

    }
}
