Funcion r <- EsPar(n)
	Si n % 2 == 0 Entonces
		r <- Verdadero
	Sino
		r <- Falso
	FinSi
FinFuncion

Funcion res <- Factorial(n)
	Definir f, i Como Entero
	f <- 1
	Para i <- 1 Hasta n Hacer
		f <- f * i
	FinPara
	res <- f
FinFuncion

Funcion m <- MaxDe3(a, b, c)
	Si a > b Y a > c Entonces
		m <- a
	Sino
		Si b > c Entonces
			m <- b
		Sino
			m <- c
		FinSi
	FinSi
FinFuncion

Funcion fahr <- ConvertirTemp(c)
	fahr <- (c * 9 / 5) + 32
FinFuncion

Funcion area <- AreaRectangulo(base, altura)
	area <- base * altura
FinFuncion

Algoritmo SelectorActividades
	Definir opcion Como Entero
	Definir num1, num2, num3 Como Real
	
	Escribir "Que deseas hacer hoy"
	Escribir "1. Verificar si es Par"
	Escribir "2. Calcular Factorial"
	Escribir "3. Hallar el Mayor de 3 numeros"
	Escribir "4. Convertir Celsius a Fahrenheit"
	Escribir "5. Calcular Area de Rectangulo"
	
	Leer opcion
	
	Segun opcion Hacer
		1:
			Escribir "Ingrese un numero: "
			Leer num1
			Escribir "Es par?: ", EsPar(num1)
		2:
			Escribir "Ingrese el numero para su factorial: "
			Leer num1
			Escribir "El resultado es: ", Factorial(num1)
		3:
			Escribir "Ingrese tres numeros: "
			Leer num1, num2, num3
			Escribir "El mayor de todos es: ", MaxDe3(num1, num2, num3)
		4:
			Escribir "Ingrese grados Celsius: "
			Leer num1
			Escribir "En Fahrenheit es: ", ConvertirTemp(num1)
		5:
			Escribir "Ingrese base y altura: "
			Leer num1, num2
			Escribir "El area calculada es: ", AreaRectangulo(num1, num2)
		De Otro Modo:
			Escribir "Esa opcion no existe"
	FinSegun
	
FinAlgoritmo