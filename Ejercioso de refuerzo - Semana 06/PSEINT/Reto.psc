
Funcion n <- LeerNota(mensaje)
	Definir n Como Real
	Escribir mensaje
	Leer n
	Mientras n < 0 O n > 20 Hacer
		Escribir "Intente de nuevo 0-20:"
		Leer n
	FinMientras
FinFuncion


Funcion r <- EsAprobado(nota)
	Si nota >= 11 Entonces
		r <- Verdadero
	Sino
		r <- Falso
	FinSi
	
	
FinFuncion


Funcion t <- ClasificarNota(nota)
	Si nota >= 18 Entonces
		t <- "Excelente"
	Sino
		
		Si nota >= 14 Entonces
			t <- "Bueno"
		Sino
			Si nota >= 11 Entonces
				t <- "Aprobado"
			Sino
				t <- "Desaprobado"
			FinSi
		FinSi
		
		
	FinSi
FinFuncion

Funcion p <- CalcularPromedio(suma, total)
	Si total > 0 Entonces
		p <- suma / total
	Sino
		
		p <- 0
	FinSi
	
FinFuncion


Funcion MostrarEstadisticas(prom, mayor, menor, aprobados, total)

	Escribir "RESUMEN DE ESTADISTICAS"
	
	Escribir " "
	Escribir "Promedio grupal: ", prom
	Escribir "Nota mas alta: ", mayor
	Escribir "Nota mas baja: ", menor
	Escribir "Cantidad de aprobados: ", aprobados
	Escribir "Total de alumnos: ", total
	
	
FinFuncion

Algoritmo RetoFinal
	Definir nota_actual, suma, mayor, menor Como Real
	Definir total_notas, cuenta_aprobados, i Como Entero
	
	suma <- 0
	
	cuenta_aprobados <- 0
	
	total_notas <- 3 
	mayor <- -1
	menor <- 21
	
	Para i <- 1 Hasta total_notas Hacer

		nota_actual <- LeerNota("Ingrese la nota del estudiante: ")
		
		suma <- suma + nota_actual
		
		Si EsAprobado(nota_actual) Entonces
			cuenta_aprobados <- cuenta_aprobados + 1
			
		FinSi
		
		Escribir "Clasificacion: ", ClasificarNota(nota_actual)
		
		Si nota_actual > mayor Entonces
			mayor <- nota_actual
			
		FinSi
		Si nota_actual < menor Entonces
			menor <- nota_actual
			
		FinSi
	FinPara
	

	Definir prom_final Como Real
	prom_final <- CalcularPromedio(suma, total_notas)
	
	
	MostrarEstadisticas(prom_final, mayor, menor, cuenta_aprobados, total_notas)
	
FinAlgoritmo