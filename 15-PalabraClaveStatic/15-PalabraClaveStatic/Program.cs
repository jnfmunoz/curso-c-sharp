

class Program()
{
    static void Main()
    {
        var data = new Conversor();
        Conversor.velocidad = 3.0;
        var data2 = new Conversor();
    }

    class Conversor
    {
        public static double velocidad; // variables estáticas

    }
}