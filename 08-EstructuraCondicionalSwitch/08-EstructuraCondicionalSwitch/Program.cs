// See https://aka.ms/new-console-template for more information

/*
var data = 5; // int char double
switch (data)
{
	case 7:
		Console.WriteLine("Case {0}", data);
		break;

	default:
        Console.WriteLine("Case {0}", "default");
        break;
}
*/

// Switch expressions #1

/*
var data = 2;
var result = data switch
{
	1 => "Alex",
    2 => "Joel",
	3 => "Pdhn",

};
Console.Write(result);
*/

// Switch expressions #2
var (a,b,opcion) = (2, 5, "*");
var result = opcion switch
{
    "+" => a + b, // a == b,
    "-" => a - b, // a < b,
    "*" => b * a  // b < a
};

Console.Write("Resultado {0}", result);

Console.ReadLine();
