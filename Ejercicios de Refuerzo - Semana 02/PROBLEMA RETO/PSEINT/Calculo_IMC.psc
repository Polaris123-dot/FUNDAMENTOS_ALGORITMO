Algoritmo Calculo_IMC
    Definir peso, altura, imc Como Real
	
    Escribir "Ingresa el peso KG:"
    Leer peso
    Escribir "Ingresa la altura:"
    Leer altura
	
    Si altura > 3 Entonces
        altura <- altura / 100
        Escribir "Altura en Cm, convertida a: ", altura, " m"
    FinSi
	
    imc <- peso / (altura ^ 2)
    Escribir "El resultado IMC es: ", imc
    
	Si  imc <  18.5 Entonces
        Escribir "DIAGNOSTICO: BAJO PESO"
    FinSi
    
    Si  imc >= 18.5 Y  imc < 25 Entonces
		
        Escribir "DIAGNOSTICO: PESO NORMAL"
    FinSi
    
    Si imc >= 25 Y  imc < 30 Entonces
		
        Escribir "DIAGNOSTICO: SOBREPESO"
    FinSi
    
    Si   imc >= 30 Entonces
        Escribir "DIAGNOSTICO: OBESIDAD"
    FinSi
			
FinAlgoritmo