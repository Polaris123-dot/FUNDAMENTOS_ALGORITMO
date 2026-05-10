

def  MostrarLinea ( caracter ,  n ) :
    for  i  in  range ( n ) :
        print ( caracter , end="" )
    
    print ( "" )

print ( "ingresa el caracter" )

carac = input ( ) 

print ( "ingresa N numero" )

Num = int ( input ( ) )

MostrarLinea ( carac ,  Num )


print ( "fin de la impresion" )