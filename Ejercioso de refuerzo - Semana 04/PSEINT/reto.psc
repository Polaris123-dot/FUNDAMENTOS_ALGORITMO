Algoritmo reto
	
	Definir nota, suma, promedio, nota_max, nota_min Como Real
	Definir c_total, c_exc, c_buen, c_apr, c_des Como Entero
	
	c_total <- 0
	c_exc <- 0
	c_buen <- 0
	c_apr <- 0
	c_des <- 0
	suma <- 0
	
	Repetir
		
		Escribir "Mete una nota 0-20 o pon -1 para ya terminar"
		Leer nota
		
		Si nota <> -1 Entonces
			
			
			Si nota >= 0 Y nota <= 20 Entonces
				
				c_total <- c_total + 1
				suma <- suma + nota
				Si c_total = 1 Entonces
					nota_max <- nota
					nota_min <- nota
				Sino
					Si nota > nota_max Entonces
						nota_max <- nota
					FinSi
					
					Si nota < nota_min Entonces
						nota_min <- nota
					FinSi
				FinSi

				Si nota >= 17 Entonces
					c_exc <- c_exc + 1
					Escribir "EXCELENTE"
				Sino
					Si nota >= 14 Entonces
						c_buen <- c_buen + 1
						Escribir "BUENO"
					Sino
						Si nota >= 11 Entonces
							c_apr <- c_apr + 1
							Escribir "APROBADO"
						Sino
							c_des <- c_des + 1
							Escribir "DESAPROBADO"
						FinSi
					FinSi
				FinSi
				
			Sino
				Escribir "Oe, la nota tiene que ser entre 0 y 20"
			FinSi
			
		FinSi
		
	Hasta Que nota = -1
	
	Si c_total > 0 Entonces
		promedio <- suma / c_total

		Escribir "Notas procesadas: ", c_total
		Escribir "Promedio del salon: ", promedio
		Escribir "La nota mas alta: ", nota_max
		Escribir "La nota mas baja: ", nota_min
		Escribir "--- Conteos ---"
		Escribir "Excelentes: ", c_exc
		Escribir "Buenos: ", c_buen
		Escribir "Aprobados: ", c_apr
		Escribir "Desaprobados: ", c_des
	Sino
		Escribir "No ingresaste ni un dato, asi no se puede pe"
	FinSi
	
FinAlgoritmo