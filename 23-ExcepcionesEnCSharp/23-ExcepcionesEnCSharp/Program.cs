

class Program
{
    static void Main()
    {
        try
        {
            int data = Convert.ToInt16("k");
        }
        catch (FormatException e)
        {
            String m = e.Message;
            Console.WriteLine(m);
        }
    
    }
}