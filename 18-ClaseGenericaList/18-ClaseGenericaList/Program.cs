

class Program
{
    static void Main()
    {
        List<Object> lista = new List<Object>(); // String , int

        lista.Add(12);
        lista.Add("a");
        lista.Add(false);
        //lista.Remove(12);
        //lista.Remove(lista[0]);

        /* lista.Insert(1, "Juan");
        Console.WriteLine(lista.IndexOf(12, 1,2)); */

        //lista.Clear();
        //lista.Reverse();
        //Console.WriteLine(lista.LastIndexOf("a", 2));
        //Console.WriteLine(lista.Contains(12));
        Console.WriteLine(lista.Exists(e => e.Equals("a")));

        /* lista.ForEach(item =>
        {
            Console.WriteLine(item);
        }); */

        /* for(int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }; */

        /* int j = 0;
        for( ; ; )
        {
            if(j < lista.Count)
            {
                Console.WriteLine(lista[j]);
                j++;
            } else
            {
                break;
            }            
        }; */

        //lista.ForEach(item => Console.WriteLine(item));

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        //Console.WriteLine(lista[0]);
        //Console.WriteLine(lista.Count);

        Console.ReadKey();
    }
}
