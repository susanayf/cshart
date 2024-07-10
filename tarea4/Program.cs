// See https://aka.ms/new-console-template for more information

int contrasena = 12345678;
int verificarcontraseña;
string perfil;

Console.WriteLine("ingrese la contraseña");
verificarcontraseña= Convert.ToInt32(Console.ReadLine());

if (verificarcontraseña == contrasena)
{
    Console.WriteLine("ingrese A, U o X para verificar su perfil");
    perfil = Console.ReadLine();
    switch (perfil)
    {
        case "A":
            Console.WriteLine("usted tiene perfil de administrador");
            break;
        case "U":
            Console.WriteLine("usted tiene perfil de usuario");
            break;
        case "X":
            Console.WriteLine("Bienvenido sin perfil definido");
            break;
        default:
            break;
    }
}
else
{
    Console.WriteLine("ingrese la contraseña nuevamente");
    verificarcontraseña = Convert.ToInt32(Console.ReadLine());

    if (verificarcontraseña == contrasena)
    {
        Console.WriteLine("ingrese A, U o X para verificar su perfil");
        perfil = Console.ReadLine();
        switch (perfil)
        {
            case "A":
                Console.WriteLine("Bienvenido administrador");
                break;
            case "U":
                Console.WriteLine("BIenvenido usuario");
                break;
            case "X":
                Console.WriteLine("Bienvenido sin perfil definido");
                break;
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("debe reiniciar el sistema");
    }
}