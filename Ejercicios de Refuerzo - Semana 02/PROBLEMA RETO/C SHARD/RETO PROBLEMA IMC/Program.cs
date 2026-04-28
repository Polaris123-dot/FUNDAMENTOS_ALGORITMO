Console.Write("INGRESA PESO");

double peso = double.Parse(Console.ReadLine());

Console.Write("INGRESA ALTURA  ");

double altura = double.Parse(Console.ReadLine());

if (altura > 3) {
    altura /= 100;
    Console.WriteLine($"Altura en Cm, convertida a: {altura} m");
}

double imc = peso / Math.Pow(altura, 2);
Console.WriteLine($"El resultado IMC es: {imc}");

if (imc < 18.5 ) 

{
    Console.WriteLine("DIAGNOSTICO: BAJO PESO");
}

if (imc >= 18.5 && imc < 25  )  

{
    Console.WriteLine("DIAGNOSTICO: PESO NORMAL");
    
}

if (imc >= 25 && imc < 30 ) 
{
    Console.WriteLine("DIAGNOSTICO: SOBREPESO");

}

if (imc   >= 30 ) 

{
    Console.WriteLine("DIAGNOSTICO: OBESIDAD");
}