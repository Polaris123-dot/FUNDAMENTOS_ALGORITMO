Algoritmo suma_n_numeros
	
	Definir n, contador, num, suma, mayor, menor Como Real
	Definir promedio Como Real
	Escribir "cuantos num vas a meter "
	Leer n
	contador <- 1
	suma <- 0
	
	Mientras contador <= n Hacer
		Escribir "pon el numero ", contador, ":"
		Leer num
		
		Si contador = 1 Entonces
			mayor <- num
			menor <- num
		Sino
			Si num > mayor Entonces
				mayor <- num
			FinSi
			Si num < menor Entonces
				menor <- num
			FinSi
		FinSi
		
		suma <- suma + num
		contador <- contador + 1
		
	FinMientras
	
	promedio <- suma / n
	
	Escribir "la cant de num fue: ", n
	Escribir "la suma total salio: ", suma
	Escribir "el promedio es: ", promedio
	
	Escribir "el mas grande: ", mayor
	Escribir "el mas chiquito: ", menor
	
FinAlgoritmo