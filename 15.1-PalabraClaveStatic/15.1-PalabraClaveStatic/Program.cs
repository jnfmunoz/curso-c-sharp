

class Program
{
    static void Main()
    {
        Conversor.velocidad = 3.0;

        Conversor.Conversor1();
        Conversor.Conversor2();

        Console.WriteLine($"Velocidad final: {Conversor.velocidad}");
        Console.ReadLine();
    }

    static class Conversor
    {
        static Conversor()
        {

        }

        public static double velocidad; // variables estáticas

        public static void Conversor1()
        {
            velocidad += 20;
        }

        public static void Conversor2()
        {
            velocidad += 78;
        }

    }
}