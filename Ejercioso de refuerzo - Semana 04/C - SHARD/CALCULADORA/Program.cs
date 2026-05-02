

        int op;
        double n1 = 0, n2 = 0, res;

        do
        {
            Console.Write("que vas realizar?: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            
            Console.Write("que vas a marcar?: ");
            
            // aqui lo leo rapido sin mucha validacion de letras
            op = int.Parse(Console.ReadLine());

            if (op >= 1 && op <= 4)
            {
                Console.Write("dame el primer n: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("dame el segundo n: ");
                n2 = double.Parse(Console.ReadLine());
            }

            switch (op)
            {
                case 1:
                    res = n1 + n2;
                    Console.WriteLine("la suma salio: " + res);
                    break;

                case 2:
                    res = n1 - n2;
                    Console.WriteLine("la resta es: " + res);
                    break;

                case 3:
                    res = n1 * n2;
                    Console.WriteLine("multiplicado sale: " + res);
                    break;

                case 4:
                    if (n2 != 0) {
                        res = n1 / n2;
                        Console.WriteLine("la divi es: " + res);
                    } else {
                        Console.WriteLine("oe no se puede dividir entre cero pe xddd");
                    }
                    break;

                case 5:
                    Console.WriteLine("ya me jalo, nos vemos xdd");
                    break;

                default:
                    Console.WriteLine("error fatal: esa opcion no existe :c");
                    break;
            }


        } while (op != 5);
        
        

