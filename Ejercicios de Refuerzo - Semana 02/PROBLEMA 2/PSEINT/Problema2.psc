Algoritmo calculadora
    
	Definir num1, num2, resultado Como Real
    Definir operacion Como Entero
    
    Escribir "Ingrese el primer número:"
    Leer num1
    Escribir "Ingrese el segundo número:"
    Leer num2
    Escribir "Seleccione una operación:"
    Escribir "1 - Suma"
    Escribir "2 - Resta"
    Escribir "3 - Multiplicación"
    Escribir "4 - División"
    Leer operacion
    
    Segun operacion Hacer
        1:
            resultado = num1 + num2
            Escribir "La suma es", resultado
        2:
            resultado = num1 - num2
            Escribir "La resta es ", resultado
        3:
            resultado = num1 * num2
            Escribir "La multiplicacion es", resultado
        4:
            
            Si num2 = 0 Entonces
				Escribir "No se puede dividir entre cero"
            Sino
                
				resultado = num1 / num2
                Escribir "la divicion es", resultado
            FinSi
        De Otro Modo:
            Escribir "Opción no válida. Por favor elija del 1 al 4."
    FinSegun
    
FinAlgoritmo