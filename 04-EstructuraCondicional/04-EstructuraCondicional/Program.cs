// See https://aka.ms/new-console-template for more information

int value = 9;
int value2 = 8;
double value3 = 10;
double value4 = 11;
string name;
var data = value != value2;

// Estructura condicional
/*
if (data)  // &&, ||
{
    if (value3 == value4)
    {
        Console.WriteLine("Resultado {0}", "true");
    }
    else
    {
        Console.WriteLine("Resultado {0}", "false");
    }
}
else
{
    //Console.WriteLine("Resultado {0}", "no se cumplió la condición");
    Console.WriteLine("Resultado: {0}", data);
}
*/

// Operador condicional
/*
if (data)
{
    name = "Juan";
}
else
{
    name = "Francisco";
}
*/

name = data ? "Juan" : "Francisco";

Console.WriteLine(name);

Console.ReadLine();
