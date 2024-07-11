// See https://aka.ms/new-console-template for more information

//string cadena1 = "soy una cadena1   ";
//string cadena2 = "soy una cadena1";

//if (cadena1.Equals(cadena2))
//{
//    Console.WriteLine("cadena1 es igual a cadena 2");
//}
//else
//{
//    Console.WriteLine("cadena1 no es igual a cadena2");
//}
//if (cadena1.Contains(cadena2)) 
//{
//    Console.WriteLine("cadena 1 contiene a cadena2");
//}
//else
//{
//    Console.WriteLine("cadena1 no contiene a cadena2");
//}


using System.Timers;

//Console.WriteLine("ingrese un numero a sumar");
//string numero = Console.ReadLine();

//double numeroasumar = 5;
//double numeroaparsear;
//double resultado;

//if (String.IsNullOrEmpty(numero))
//{
//    Console.WriteLine("no ingreso ningun numero esta vacio o es nulo y no esta parseado");
//}
//else
//{
//    numeroaparsear= double.Parse(numero);
//    resultado = numeroaparsear + numeroasumar;
//    Console.WriteLine("el resultado es: " + resultado);
//}
//Console.ReadKey();



//Console.WriteLine("Ingrese la contraseña");
//string clave=Console.ReadLine();

//while (!clave.Equals("coderhouse2024"))
//{
//    Console.WriteLine("la contraseña es incorrecta, ingresela nuevamente");
//    clave= Console.ReadLine();
//}
//Console.WriteLine("ha ingresado correctamente");
//Console.ReadKey();


int i;
int cantidaddenotascargadas = 0;
double promediodenotas = 0;
double sumadenotas = 0;
double nota;

bool aplazado=false;

Console.WriteLine("ingrese la cantidad de notas a calcular");
cantidaddenotascargadas= int.Parse(Console.ReadLine());

for (i = 0; i < cantidaddenotascargadas; i++)
{
    Console.WriteLine("Ingrese la nota");
    nota=double.Parse(Console.ReadLine());

    if (nota <= 2)
    {
        aplazado = true;
        break;
    }

    if (nota > 2 && nota < 4)
    {
        cantidaddenotascargadas--;
        continue;
    }
    sumadenotas = sumadenotas + nota;
}

if (aplazado)
{
    Console.WriteLine("el alumno esta aplazado");
}
else
{ 
promediodenotas = sumadenotas / cantidaddenotascargadas;
Console.WriteLine("el promedio de notas del alumno es: {0:N2}", promediodenotas); /*N2 es para limitar a 2 digitos despues de la coma*/
}
Console.ReadKey();