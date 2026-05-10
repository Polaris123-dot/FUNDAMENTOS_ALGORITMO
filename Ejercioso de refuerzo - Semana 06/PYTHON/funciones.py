def  LeerNota ( mensaje ) :
    nota = float ( input ( mensaje ) )
    while  nota < 0  or  nota > 20 :
        print ( "Intente de nuevo 0-20:" )
        nota = float ( input ( mensaje ) )
    return  nota

def  EsAprobado ( nota ) :
    if  nota >= 11 :
        return  True
    else :
        return  False

def  ClasificarNota ( nota ) :
    if  nota >= 18 :
        return  "Excelente"
    elif  nota >= 14 :
        return  "Bueno"
    elif  nota >= 11 :
        return  "Aprobado"
    else :
        return  "Desaprobado"

def  CalcularPromedio ( suma ,  total ) :
    if  total > 0 :
        return  suma / total
    else :
        return  0

def  MostrarEstadisticas ( prom ,  mayor ,  menor ,  aprobados ,  total ) :
    print ( "RESUMEN DE ESTADISTICAS" )
    print ( "" )
    print ( "Promedio grupal: " ,  prom )
    print ( "Nota mas alta: " ,  mayor )
    print ( "Nota mas baja: " ,  menor )
    print ( "Cantidad de aprobados: " ,  aprobados )
    print ( "Total de alumnos: " ,  total )