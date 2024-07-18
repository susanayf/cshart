int findecompra() { 

    string codigo;
    int cantidaddeproductos = 0;
    string confirmalacompra = "si";
    string codigofindecompra = "FIN";
    string teclaentrar="";

Console.WriteLine("Bienvenido a mi Tienda, presione la tecla(ENTRAR) para iniciar su pedido");
teclaentrar= Console.ReadLine();
while (true)
{

Console.WriteLine("codigo DES: desodorante 200 pesos");
    Console.WriteLine("codigo JP: jabon en polvo 300 pesos");
    Console.WriteLine("codigo DET: detergente 250 pesos");
    Console.WriteLine("que productos desea comprar? ingrese el codigo para seleccionar: DES, JP o DET");
    codigo = Console.ReadLine();
    Console.WriteLine("cuantos productos desea comprar");
    cantidaddeproductos = Convert.ToInt32(Console.ReadLine());


    while (!findecompra(codigo, codigofindecompra))
    {

    }

    Console.WriteLine("confirma la compra?");
    confirmalacompra = Console.ReadLine();


    switch (codigo)
    {
        case "DES":
            Console.WriteLine("Gracias por comprar en nuestra tienda");
            break;
        case "JP":
            Console.WriteLine("Gracias por comprar en nuestra tienda");
            break;
        case "DET":
            Console.WriteLine("Gracias por comprar en nuestra tienda");
            break;
        default:
            Console.WriteLine("no ha ingresado ningun codigo de compra");
            break;
    }
    break;
}
}

Console.ReadKey();