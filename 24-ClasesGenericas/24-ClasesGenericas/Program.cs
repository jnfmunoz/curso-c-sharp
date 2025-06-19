

using _23_ExcepcionesEnCSharp;

class Program : Book
{
    static void Main()
    {
        var book = new Books<Book>();
        book.Add(new Book
        {
            Id = 1,
            Title = "Crimen y castigo"
        });

        book.Add(new Book
        {
            Id = 2,
            Title = "Noches Blancas"
        });

        /*
        book.Book = new Book
        {
            Id = 1,
            Title = "Crimen y castigo"
        };*/

        Console.WriteLine(book.Get(0).Id);
        Console.WriteLine(book.Get(0).Title);
        Console.ReadLine();

    }
}
