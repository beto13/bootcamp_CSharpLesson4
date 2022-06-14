// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese ancho");
var ancho = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Ingrese alto");
var alto = Convert.ToInt16(Console.ReadLine());

for (int j = 0; j < alto; j++)
{
    for (int i = 0; i < ancho; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


Console.ReadKey();