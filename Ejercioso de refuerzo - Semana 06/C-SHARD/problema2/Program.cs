

class Program
{
    static bool EsPar(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int Factorial(int n)
    {
        int f = 1;

        for (int i = 1; i <= n; i++)
        {
            f = f * i;

        }
        return f;

    }

    static double MaxDe3(double a, double b, double c)
    {
        if (a > b && a > c)

        {
            return a;

        }
        else if (b > c)

        {
            return b;

        }
        else
        {
            return c;
        }
    }

    static double ConvTemp(double c)
    {
        double fahr = (c * 9 / 5) + 32;


        return fahr;
    }

    static double AreaRect(double b, double h)

    {
        return b * h;


    }

    static void Main()

    {
        Console.WriteLine("Que deseas hacer hoy");
        Console.WriteLine("1. Verificar si es Par");
        Console.WriteLine("2. Calcular Factorial");
        Console.WriteLine("3. Hallar el Mayor de 3 numeros");
        Console.WriteLine("4. Convertir Celsius a Fahrenheit");
        Console.WriteLine("5. Calcular Area de Rectangulo");

        int opcion = int.Parse(Console.ReadLine());


        if (opcion == 1)
        {
            Console.WriteLine("Ingrese un numero:");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Es par?: " + EsPar(n));
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Ingrese el numero para su factorial:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + Factorial(n));
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Ingrese tres numeros:");
            double n1 = double.Parse(Console.ReadLine());

            double n2 = double.Parse(Console.ReadLine());

            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("El mayor de todos es: " + MaxDe3(n1, n2, n3));
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Ingrese grados Celsius:");

            double c = double.Parse(Console.ReadLine());


            Console.WriteLine("En Fahrenheit es: " + ConvTemp(c));
        }
        else if (opcion == 5)
        {
            Console.WriteLine("Ingrese base y altura:");

            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            

            Console.WriteLine("El area calculada es: " + AreaRect(b, h));
        }
        else
        {
            Console.WriteLine("Esa opcion no existe");
        }
    }
}