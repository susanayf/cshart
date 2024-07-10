// See https://aka.ms/new-console-template for more information
using System.Timers;

string comision;
int nota = 0;

Console.WriteLine("ingrese la comision A, B o C");
comision= Console.ReadLine();

switch (comision) 
{
    case "A":
    Console.WriteLine("Turno mañana");
        break;

        case "B":
        Console.WriteLine("turno tarde");
        break;

        case "C":
        Console.WriteLine("turno noche");
        break;

        default:
        Console.WriteLine("el alumno no tiene turno fijado");
        break;
}
    Console.WriteLine("ingrese la nota del alumno de 0 a 10");
    nota=Convert.ToInt32(Console.ReadLine());

if (nota < 4)
{
    Console.WriteLine("el alumno recursa la materia");
}
if (nota >=4 && nota <= 7)
{
    Console.WriteLine("el alumno aprobo la cursada");
}
else if (nota > 7)
{
    Console.WriteLine("el alumno promociona la materia");
}