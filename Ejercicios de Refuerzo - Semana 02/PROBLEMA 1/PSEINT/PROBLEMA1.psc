Algoritmo PROBLEMA1
	NOTAS <- ENTERO	
	Escribir "iNGRESA LA NOTA DEL ESTUDIANTE"
	LEER NOTA
	
	SI NOTA >= 11 y nota < 20 Entonces
		Escribir "APROBADO"
	SiNo
		
		SI NOTA <= 11 Entonces
			Escribir "DESAPROBADO"
		SiNo
			
			SI NOTA == 20 Entonces
				Escribir "EXCELENTE"
			FinSi
		FinSi
	FinSi
	
FinAlgoritmo
