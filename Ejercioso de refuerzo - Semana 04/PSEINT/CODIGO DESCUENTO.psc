Algoritmo  descuento
	
	Definir t_cli Como Entero
	Definir m_compra, desc, m_total Como Real
	
	Escribir "entonces que cliente es?? 1 pa VIP, 2 pa Normal"
	Leer t_cli
	
	Escribir "cual es el monto:"
	Leer m_compra
	
	
	Si t_cli = 1 Entonces
		
		Si m_compra > 100 Entonces
			desc <- m_compra * 0.20
		Sino
			desc <- m_compra * 0.10
			
		FinSi
		
	Sino
		
		
		Si m_compra > 200 Entonces
			desc <- m_compra * 0.10
		Sino
			desc <- m_compra * 0.05
		FinSi
		
		
	FinSi
	
	m_total <- m_compra - desc
	
	Escribir "su descuentito es de: ", desc
	Escribir "total a pagar ps: ", m_total
	
	
FinAlgoritmo