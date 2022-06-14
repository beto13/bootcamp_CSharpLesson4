
var input = "";
int positivo = 0;
int negativo = 0;

do
{
    Console.Write("Por favor ingrese un numero... ");

    var numero = Convert.ToInt16(Console.ReadLine());

    if (numero > 0)
    {
        positivo++;
        Console.WriteLine("El numero es positivo");
    }
    else
    {
        negativo++;
        Console.WriteLine("El numero es negativo");
    }
    Console.WriteLine("Cantidad de positivos: {0} ", positivo);
    Console.WriteLine("Cantidad de negativos: {0} ", negativo);
    Console.WriteLine();
    Console.Write("Ingrese switch para salir... ");
    input = Console.ReadLine();
    Console.WriteLine();
}
while (input != "s");
