using System.Diagnostics.CodeAnalysis;
using System.Xml;

Console.WriteLine("Hello, World!");

Console.WriteLine("Ingresa la nota del estudiante");

double nota = double.Parse(Console.ReadLine());

if (nota  <11)
    Console.WriteLine("DESAPROBADO");
else if (nota >=11 && nota < 20 )
    Console.WriteLine("APROBADO");
else if (nota == 20)
    Console.WriteLine("EXCELENTE");
else
    Console.WriteLine("DATOS INGRESADOS INCORRECTOS");

