
        int t_cli;
        double m_compra, desc, m_total;


        Console.WriteLine("entonces que cliente es?? 1 pa VIP, 2 pa Normal");
        t_cli = int.Parse(Console.ReadLine());


        Console.WriteLine("cual es el monto ");
        m_compra = double.Parse(Console.ReadLine());



        if (t_cli == 1) 
        {

            if (m_compra > 100) 
            {
                desc = m_compra * 0.20;
            }
            else 
            {
                desc = m_compra * 0.10;
            }
        }
        else 
        {

            if (m_compra > 200) 
            {
                desc = m_compra * 0.10;
            }
            else 
            {
                desc = m_compra * 0.05;
            }
        }


        m_total = m_compra - desc;


        Console.WriteLine("su descuentito es de: " + desc);
        Console.WriteLine("total a pagar ps: " + m_total);
