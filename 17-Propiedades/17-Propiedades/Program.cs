

using _17_Propiedades;

class Program
{
    static void Main()
    {
        /* var data = new Estudiante();
        //var nombre = data.Nombre;
        data.Nombre = "Francisco";

        Console.WriteLine(data.Nombre); */

        var s1 = new Estudiante()
        {
            Nombre = "Juan",
            Edad = 26,
            Calificacion = 6.7
        };

        var s2 = new Estudiante()
        {
            Nombre = "Francisco",
            Edad = 24,
            Calificacion = 5.5
        };

        var s3 = new Estudiante()
        {
            Nombre = "JMG",
            Edad = 33,
            Calificacion = 5.9
        };

        var school = new School();

        school.addStudent(s1);
        school.addStudent(s2);
        school.addStudent(s3);

        bool valor = false;

        do
        {
            Console.WriteLine("Ingrese el nombre");
            String name = Console.ReadLine();
            valor = school.buscarPorNombre(name);

        }
        while (valor);

        Console.ReadKey(); 
    }
}
