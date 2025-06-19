

using _23_ExcepcionesEnCSharp;

class Program
{
    static void Main()
    {
        try
        {
            int[] array = { };
            int data = array[0];

            //int data = Convert.ToInt16("k");
        }
        catch (FormatException e)
        {
            String m = e.Message;
            Console.WriteLine(m);
        }
        catch (IndexOutOfRangeException e)
        {
            throw new ExcepcionesPersonalizadas("Se ha generado una excepción");
            //String m = e.Message;
            //Console.WriteLine(m);
        }
        finally
        {
            Console.WriteLine("Hello World");
        }
    }
}