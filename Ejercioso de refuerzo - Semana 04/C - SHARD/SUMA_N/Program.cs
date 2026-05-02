
        double n, cont, num, suma, ma = 0, mi = 0, prom;

        Console.Write("cuantos num vas a meter: ");
        n = double.Parse(Console.ReadLine());

        cont = 1;
        suma = 0;

        while (cont <= n)
        {
            Console.Write("pon el numero " + cont + ": ");
            num = double.Parse(Console.ReadLine());

            if (cont == 1)
            {
                ma = num;
                mi = num;
            }
            else
            {
                if (num > ma) {
                    ma = num;
                }
                if (num < mi) {
                    mi = num;
                }
            }

            suma = suma + num;
            cont = cont + 1;
        }

        prom = suma / n;

        Console.WriteLine("\nla cant de num fue: " + n);
        Console.WriteLine("la suma total salio: " + suma);
        Console.WriteLine("el promedio es: " + prom);
        Console.WriteLine("el mas grande: " + ma);
        Console.WriteLine("el mas chiquito: " + mi);
        
