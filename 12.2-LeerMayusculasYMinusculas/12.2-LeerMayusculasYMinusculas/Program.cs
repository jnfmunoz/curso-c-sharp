

class Program
{
    private String cadena; // _cadena
    private String verMayusculas = "";
    private String verMinusculas = "";
    private int n;
    private string[] mayusculas;
    private string[] minusculas;
    private string[] tempMy;
    private string[] tempMn;

    // método constructor
    public Program(String cadena)
    {
        this.cadena = cadena; // _cadena = cadena;
        n = cadena.Length;
        mayusculas = new string[n];
        minusculas = new string[n];
        tempMy = new string[n];
        tempMn = new string[n];
    }

    private String Mayusculas()
    {
        for (int i = 0; i < n; i++)
        {
            // indica si un carácter Unicode está categorizado como una letra mayúscula
            if (Char.IsUpper(cadena[i]))
            {
                tempMy[i] = Convert.ToString(cadena[i]);
            }
        }

        for (int i = 0; i < tempMy.Length; i++)
        {
            if (tempMy[i] != null)
            {
                mayusculas[i] = tempMy[i];
                //verMayusculas = verMayusculas + "," + mayusculas[i];
                verMayusculas = $"{verMayusculas}, {mayusculas[i]}";
            }
        }

        return verMayusculas;
    }

    private String Minusculas()
    {
        for (int i = 0; i < n; i++)
        {
            // indica si un carácter Unicode está categorizado como una letra minúscula
            if (Char.IsLower(cadena[i]))
            {
                tempMn[i] = Convert.ToString(cadena[i]);
            }
        }

        for (int i = 0; i < tempMn.Length; i++)
        {
            if (tempMn[i] != null)
            {
                minusculas[i] = tempMn[i];
                verMinusculas = $"{verMinusculas} {minusculas[i]}";
            }
        }

        return verMinusculas;
    }

    static void Main()
    {

        var cadena = Console.ReadLine();
        var data = new Program(cadena);

        Console.WriteLine("Las letras mayúsculas son: " + data.Mayusculas()
            + "\n\n" + "Las letras minúsculas son: " + data.Minusculas());
        Console.ReadLine();
    }
}
