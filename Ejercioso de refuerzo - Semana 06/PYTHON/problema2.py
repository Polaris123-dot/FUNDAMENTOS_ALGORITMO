
def  es_par ( n ) :
    if  n % 2 == 0 :
        return  True
    else :
        return  False

def  factorial ( n ) :
    f = 1
    for  i  in  range ( 1 ,  n + 1 ) :
        f = f * i
    return  f

def  max_de3 ( a , b , c ) :
    if  a > b  and  a > c :
        return  a
    elif  b > c :
        return  b
    else :
        return  c

def  conv_temp ( c ) :
    farenheit = ( c * 9 / 5 ) + 32
    return  farenheit

def  area_rect ( base ,  altura ) :
    return  base * altura

print ( "Que deseas hacer hoy" )
print ( "1. Verificar si es Par" )
print ( "2. Calcular Factorial" )
print ( "3. Hallar el Mayor de 3 numeros" )
print ( "4. Convertir Celsius a Fahrenheit" )
print ( "5. Calcular Area de Rectangulo" )

opcion = int ( input ( "Elige una opcion: " ) )

if  opcion == 1 :
    num1 = int ( input ( "Ingrese un numero: " ) )
    print ( "Es par?: " ,  es_par ( num1 ) )

elif  opcion == 2 :
    num1 = int ( input ( "Ingrese el numero para su factorial: " ) )
    print ( "El resultado es: " ,  factorial ( num1 ) )

elif  opcion == 3 :
    n1 = float ( input ( "Primero: " ) )
    n2 = float ( input ( "Segundo: " ) )
    n3 = float ( input ( "Tercero: " ) )
    print ( "El mayor de todos es: " ,  max_de3 ( n1 , n2 , n3 ) )

elif  opcion == 4 :
    c = float ( input ( "Ingrese grados Celsius: " ) )
    print ( "En Fahrenheit es: " ,  conv_temp ( c ) )

elif  opcion == 5 :
    b = float ( input ( "Ingrese base: " ) )
    h = float ( input ( "Ingrese altura: " ) )
    print ( "El area calculada es: " ,  area_rect ( b , h ) )

else :
    print ( "Esa opcion no existe" )