// See https://aka.ms/new-console-template for more information
Console.Write("Por favor ingrese un numero... ");

var numero = Convert.ToInt16(Console.ReadLine());
int i = 1;
while (i <= 10)
{
    Console.WriteLine(i * numero);
    i++;
}
Console.ReadKey();  