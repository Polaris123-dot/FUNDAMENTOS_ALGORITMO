Algoritmo calculadora
	
	Definir opc Como Entero
	Definir n1, n2, res Como Real
	
	
	Repetir
		
		Escribir "Escoge tu opcion: "
		Escribir "1. Sumar"
		Escribir "2. Restar"
		Escribir "3. Multiplicar"
		Escribir "4. Dividir"
		Escribir "5. Salir"

		Leer opc
		Si opc >= 1 Y opc <= 4 Entonces
			Escribir "mete el primer num:"
			Leer n1
			Escribir "mete el segundo num:"
			Leer n2
		FinSi
		
		
		Segun opc Hacer
			1:
				res <- n1 + n2
				Escribir "la suma es: ", res
			2:
				res <- n1 - n2
				Escribir "la resta es: ", res
			3:
				res <- n1 * n2
				Escribir "la multi es: ", res
			4:
				Si n2 <> 0 Entonces
					res <- n1 / n2
					Escribir "la division es: ", res
				Sino
					Escribir "no seas asi pe, no se puede entre cero"
				FinSi
			5:
				Escribir "ya nos vemos"
			De Otro Modo:
				Escribir "oe esa opcion no existe, lee bien"
		FinSegun
		
		
	Hasta Que opc = 5
	
FinAlgoritmo