// See https://aka.ms/new-console-template for more information

int i;
string clave;
string n ="usSystem-2022";

Console.WriteLine("ingrese la contraseña");
clave = Console.ReadLine();

for (i = 1; i <= 5; i++)
{
    if (clave==n)
    {
        Console.WriteLine("bienvenido");
        break;
    }
    Console.WriteLine("ingrese la contraseña nuevamente");
    clave = Console.ReadLine();


}
if (!clave.Equals("usSystem-2022"))
{
    Console.WriteLine("no es posible acceder al sistema");
}
if (clave == n)
{
    Console.WriteLine("Bienvenido al sistema");
}
Console.ReadKey();
