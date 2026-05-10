

namespace RetoFinalApp
{
    class Program
    {
        static void Main()
        {
            double suma = 0;
            int cuenta_aprobados = 0;
            int total_notas = 3;
            double mayor = -1;
            double menor = 21;

            for (int i = 1; i <= total_notas; i++)
            {

                double nota_actual = EstadisticasLib.LeerNota("Ingrese la nota del estudiante: ");
                
                suma = suma + nota_actual;

                if (EstadisticasLib.EsAprobado(nota_actual))
                {
                    cuenta_aprobados++;
                }

                Console.WriteLine("Clasificacion: " + EstadisticasLib.ClasificarNota(nota_actual));

                if (nota_actual > mayor) mayor = nota_actual;
                if (nota_actual < menor) menor = nota_actual;
            }

            double prom_final = EstadisticasLib.CalcularPromedio(suma, total_notas);
            
            EstadisticasLib.MostrarEstadisticas(prom_final, mayor, menor, cuenta_aprobados, total_notas);
        }
    }
}