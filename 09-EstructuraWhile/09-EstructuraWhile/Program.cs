// See https://aka.ms/new-console-template for more information

var value = true;
var count = 0;

/*
while (value)
{
    if(count == 6)
    {
        value = false;        
    }
    count++;
    
    Console.WriteLine(count);
}
*/


do
{
    if (count == 6)
    {
        value = false;
    }
    count++;

    Console.WriteLine(count);
}
while (value);

Console.ReadLine();
