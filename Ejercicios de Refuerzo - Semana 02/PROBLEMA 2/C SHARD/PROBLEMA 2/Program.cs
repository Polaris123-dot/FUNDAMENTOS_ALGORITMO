

Console.Write("INGRESA PRIMER NUMERO");
double num1 = double.Parse(Console.ReadLine());

Console.Write("INGRESA SEGUNDO NUMERO");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("ESCOJA LA OPERACION");
Console.WriteLine("1 = SUMAR");
Console.WriteLine("2 = RESTAR");
Console.WriteLine("3 = MULTIPLICAR");
Console.WriteLine("4 = DIVIDIR");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"RESULTADO: {num1 + num2}");
        break;

    case 2:
        Console.WriteLine($"RESULTADO: {num1 - num2}");
        break;

    case 3:
        Console.WriteLine($"RESULTADO: {num1 * num2}");
        break;

    case 4:
    
        if (num2 != 0)
        {
            Console.WriteLine($"RESULTADO: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }
        break;

    default:
  
        Console.WriteLine("Opción no válida.");
        break;
}

