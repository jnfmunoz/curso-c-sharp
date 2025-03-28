// See https://aka.ms/new-console-template for more information

// Ciclo for
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}
*/

// Ciclo foreach
string[] name = { "Alex", "Joel", "Pdhn" };
int[] age = { 52, 45, 65 };

/*
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine("{0}", name[i]+ " age " + age[i]);
}
*/

foreach (var item in name)
{
    Console.WriteLine("{0}", item);
}

Console.ReadLine();
