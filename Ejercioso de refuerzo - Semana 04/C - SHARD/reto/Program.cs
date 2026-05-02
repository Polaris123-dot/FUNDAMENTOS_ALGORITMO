
        double nota, suma = 0, notaMax = -1, notaMin = 21, promedio;
        int cTotal = 0, cExc = 0, cBue = 0, cApr = 0, cDes = 0;

        do
        {
            Console.Write("Mete una nota 0-20 o -1 para terminar xd");
            nota = double.Parse(Console.ReadLine());

            if (nota != -1)
            {
                if (nota >= 0 && nota <= 20)
                {
                    cTotal++;
                    suma += nota;

                    if (cTotal == 1)
                    {
                        notaMax = nota;
                        notaMin = nota;
                    }
                    else
                    {
                        if (nota > notaMax) notaMax = nota;
                        if (nota < notaMin) notaMin = nota;
                    }

                    if (nota >= 17)
                    {
                        cExc++;
                        Console.WriteLine("-> EXCELENTE");
                    }
                    else if (nota >= 14)
                    {
                        cBue++;
                        Console.WriteLine("-> BUENO");
                    }
                    else if (nota >= 11)
                    {
                        cApr++;
                        Console.WriteLine("-> APROBADO");
                    }
                    else
                    {
                        cDes++;
                        Console.WriteLine("-> DESAPROBADO");
                    }
                }
                else
                {
                    Console.WriteLine("Oe! la nota debe ser de 0 a 20 pe");
                }
            }

        } while (nota != -1);

        if (cTotal > 0)
        {
            promedio = suma / cTotal;

            Console.WriteLine("Notas procesadas: " + cTotal);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Nota mas alta: " + notaMax);
            Console.WriteLine("Nota mas baja: " + notaMin);
            Console.WriteLine("Categorias: Exc:" + cExc + " | Bue:" + cBue + " | Apr:" + cApr + " | Des:" + cDes);
        }
        else
        {
            Console.WriteLine("No procesamos nada porque no metiste notas.");
        }
