// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese ancho");
int ancho = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Ingrese alto");
int alto = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("tiene relleno? 0/1");
int relleno = Convert.ToInt16(Console.ReadLine());


for (int j = 0; j < alto; j++)
{
    for (int i = 0; i < ancho; i++)
    {
        if (ancho != alto)
        {
            if (i == (ancho / 2))
            {
                if (relleno == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write("*");
            }
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}


Console.ReadKey();