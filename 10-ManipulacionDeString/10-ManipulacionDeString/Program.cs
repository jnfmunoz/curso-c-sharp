// See https://aka.ms/new-console-template for more information

/*
string name = "Juan";
string name2 = "Francisco";
string name3 = name; // inmutabilidad

name += name2; 

Console.WriteLine("Name: {0}", name3); 
*/

/*
// interpolación de cadenas
var persona = (nombre: "Juan", nombre2: "Francisco", age:26);
Console.WriteLine($"Nombre: {persona.nombre}, age: {persona.age}");

// formato compuesto
Console.WriteLine("Nombre: {0}, age: {1}", persona.nombre, persona.age);
*/

/*
// subcadenas
var curso = "Curso de C# desde cero";
Console.WriteLine("Cadena: {0}", curso.Substring(9,11));

var repl = curso.Replace("desde cero", ".NET Core");
Console.WriteLine(repl);

var remv = curso.Remove(5, 11);
Console.WriteLine(remv);
*/


// iterando cadena de texto
var curso = "Curso de C# desde cero";
var name = "Curso de C# desde cero";
//var data = curso.IndexOf("#");
//var data = curso.ToCharArray();
//var data = curso.ToLower();
//var data = curso.ToUpper();
//var data = curso.Equals(name);
foreach(var item in curso)
{
    Console.WriteLine(item);
}

//Console.WriteLine(data[10]);
//Console.WriteLine(data);
Console.ReadLine();
