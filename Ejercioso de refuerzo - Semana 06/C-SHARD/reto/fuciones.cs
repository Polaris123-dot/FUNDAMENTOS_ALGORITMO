

    public class EstadisticasLib
    {
        public static double LeerNota(string mensaje)
        {
            Console.WriteLine(mensaje);
            double nota = double.Parse(Console.ReadLine());
            while (nota < 0 || nota > 20)
            {
                Console.WriteLine("Intente de nuevo 0-20:");
                nota = double.Parse(Console.ReadLine());
            }
            return nota;
        }

        public static bool EsAprobado(double nota)
        {
            if (nota >= 11) return true;
            else return false;
        }

        public static string ClasificarNota(double nota)
        {
            if (nota >= 18) return "Excelente";
            else if (nota >= 14) return "Bueno";
            else if (nota >= 11) return "Aprobado";
            else return "Desaprobado";
        }

        public static double CalcularPromedio(double suma, int total)
        {
            if (total > 0) return suma / total;
            else return 0;
        }

        public static void MostrarEstadisticas(double prom, double mayor, double menor, int aprobados, int total)
        {
            Console.WriteLine("RESUMEN DE ESTADISTICAS");
            Console.WriteLine("");
            Console.WriteLine("Promedio grupal: " + prom);
            Console.WriteLine("Nota mas alta: " + mayor);
            Console.WriteLine("Nota mas baja: " + menor);
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
            Console.WriteLine("Total de alumnos: " + total);
        }
    }
