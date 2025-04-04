// See https://aka.ms/new-console-template for more information

using System.Text;

var name = new StringBuilder("Juan");
//name[0] = 'j';
//name.Capacity = 2;
name.Append(" Muñoz").Append(" Grau");
name.AppendLine();
name.AppendFormat("Age {0}", 26);

Console.WriteLine(name.ToString());
//Console.WriteLine(name.Length);

Console.ReadLine();
