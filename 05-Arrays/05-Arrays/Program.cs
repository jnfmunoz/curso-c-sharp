// See https://aka.ms/new-console-template for more information

/*
string[] cadenas = new string[5];
string[] name = { "Juan", "Francisco", "Cindy", "Fernando", "Joel" };
cadenas[0] = "Juan";
cadenas[1] = "Francisco";
cadenas[2] = "Cindy";
cadenas[3] = "Fernando";
cadenas[4] = "Joel";

Console.WriteLine("Resultado {0}", cadenas.Length);
Console.WriteLine("Resultado {0}", name[4]); 
*/

/*
int[] age = new int[5];
int[] ages = {5, 15, 50, 55, 95};

age[0] = 5;
age[1] = 15;
age[2] = 50;
age[3] = 55;
age[4] = 95;

Console.WriteLine("Resultado {0}", age[1]);
Console.WriteLine("Resultado {0}", ages[4]);
*/

// Arreglos multidimensionales
// Array bidimensional
//double[,] doble = new double[2, 2] { { 6, 3.0 }, { 6.3, 5.6 } }; // filas x columnas

// Array tridimensional
double[,,] doble2 = new double[2, 2, 3] // filas x columnas x profundidad
{ 
    { 
        { 6, 3.0, 8.9 }, 
        { 6.3, 5.6, 6.7 } 
    },
    {
        { 26, 33.2, 9.9 },
        { 34, 0.6, 4.7 }
    }
}; 

//Console.WriteLine("Resultado {0}", doble[1,0]);
Console.WriteLine("Resultado {0}", doble2[1, 0, 0]); // 26

Console.ReadLine();
