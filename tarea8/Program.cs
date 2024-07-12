// See https://aka.ms/new-console-template for more information
//nuestro cliente solicita que se valide el acceso atravès de una contraseña
//a su sistema... pero con una condiciòn, que el usuario solo pueda reintentar
//ingresar solamente 5 veces. Si la cantidad de intentos es mayor, informar que
//no es posible acceder al sistema y el mismo se cerrarà. la contraseña seteada 
//es "usSystem-2022" y el usuario debe ingresar por teclado para hacer la 
//comparaciòn. Si el usuario accede correctamente mostrarà un mensaje de
//bienvenida

int i;
string clave;


Console.WriteLine("ingrese la contraseña");
clave = Console.ReadLine();

while (!clave.Equals("usSystem-2022"))
{
    for (i = 1; i <= 5; i++)
    {

            Console.WriteLine("la contraseña es incorrecta, ingresela nuevmente");
            clave = Console.ReadLine();
        if (clave == "usSystem-2022")
        {
            Console.WriteLine("BIenvenido, ha accedido al sistema");
            break;

        }

    }
    Console.WriteLine("no es posible acceder al sistema");
    break;
}

    Console.WriteLine("BIenvenido, ha accedido al sistema");