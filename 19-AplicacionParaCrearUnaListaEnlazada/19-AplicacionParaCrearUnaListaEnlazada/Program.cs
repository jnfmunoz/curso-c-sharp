

using _19_AplicacionParaCrearUnaListaEnlazada;

class Program
{
    static void Main()
    {
        var list = new ListaNodo();
        
        list.addNodo(1);
        list.addNodo(3);
        list.addNodo(2);
        list.addNodo(4);
        // list.ListaVacia();
        //list.Listar();
        // list.DeleteUltimo(); 
        // list.DeletePrimero();
        // list.DeletePosicionNodo(2);
        //list.Buscar(3);
        list.Sustituir(3, 6);
        Console.WriteLine(list.Size());
        Console.WriteLine();
        list.Listar();

        Console.ReadKey();
    }
}
