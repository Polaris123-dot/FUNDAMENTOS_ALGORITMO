
import  funciones


suma = 0
cuenta_aprobados = 0
total_notas = 3
mayor = - 1
menor = 21

for  i  in  range ( total_notas ) :

    nota_actual = funciones.LeerNota ( "Ingrese la nota del estudiante: " )
    
    suma = suma + nota_actual
    
    if  funciones.EsAprobado ( nota_actual ) :
        cuenta_aprobados = cuenta_aprobados + 1
    

    print ( "Clasificacion: " ,  funciones.ClasificarNota ( nota_actual ) )
    
    if  nota_actual > mayor :
        mayor = nota_actual
    
    if  nota_actual < menor :
        menor = nota_actual


prom_final = funciones.CalcularPromedio ( suma ,  total_notas )

funciones.MostrarEstadisticas ( prom_final ,  mayor ,  menor ,  cuenta_aprobados ,  total_notas )