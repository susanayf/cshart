

string codigo= "det, jp, des";
    int cantidaddeproductos = 0;
    string confirmalacompra = "FIN";
    int montototal = 0;
    int det = 250;
    int jp = 300;
    int des = 200;

Console.WriteLine("BIENVENIDO A MI TIENDA");

while (true)
{

    Console.WriteLine("codigo DES: desodorante 200 pesos");
    Console.WriteLine("codigo JP: jabon en polvo 300 pesos");
    Console.WriteLine("codigo DET: detergente 250 pesos");
    Console.WriteLine("que productos desea comprar? ingrese el codigo para seleccionar: DES, JP o DET");
    codigo = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad que desea comprar");
    cantidaddeproductos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el codigo 'FIN' para saber el monto total de su compra");
    confirmalacompra = Console.ReadLine();

    if (det == int.Parse(codigo))
    {
        montototal = det * cantidaddeproductos;
        Console.WriteLine("EL monto total de su compra es:" + montototal);

    }
    else if (jp== int.Parse(codigo))
    {
        montototal = jp * cantidaddeproductos;
        Console.WriteLine("EL monto total de su compra es:" + montototal);
    }
    else if(des == int.Parse(codigo))
    {
        montototal = des * cantidaddeproductos;
        Console.WriteLine("EL monto total de su compra es:" + montototal);
    }

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
            
            break;
    }
    break;

}


//void findecompra()
//{
//    const string codigoFindeCompra = "FIN";
//    string codigoProductoSeleccionado = null;
//    int montototal=0;
//    while (!findecompra(codigoProductoSeleccionado, codigoFindeCompra))
//    {

//    }
//}

Console.ReadKey();