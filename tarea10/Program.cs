// See https://aka.ms/new-console-template for more information


string clave;

Console.WriteLine("ingrese la contraseña");
clave = Console.ReadLine();

while (!clave.Equals("co2024"))
{
    Console.WriteLine("la contraseña es incorreta, ingresela nuevamente");
    clave= Console.ReadLine();
}
Console.WriteLine("****** es correcta");
Console.ReadKey();
//    List<char> passwordChars = new List<char>();

//var key = Console.ReadKey(true);
//if (key.Key == ConsoleKey.Enter)
////break;

//    passwordChars.Add(key.KeyChar);
//    Console.Write("*");

//string password = new string(passwordChars.ToArray());
//Console.WriteLine("\nLa contraseña es: " + password);
   




// static void OcultarContraseña()
//{
//    List<string> lstClave = new List<string>();
//    while (true)
//    {
//        var tecla = Console.ReadKey(true);
//        if (tecla.Key == ConsoleKey.Enter)
//        {
//            break;
//        }
//        lstClave.Add(Convert.ToString(tecla.KeyChar));
//        Console.Write("*");
//    }
//    string strDato = "";
//    for (int i = 0; i < lstClave.Count(); i++)
//    {
//        strDato += lstClave[i];
//    }
//    Console.WriteLine("\nLa contraseña es " + strDato);
//    Console.ReadKey();
//}