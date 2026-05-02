cli = int(input("pon el tipo 1 o 2: "))
monto = float(input("cuanto va a pagar: "))

if cli == 1:
    
    if monto > 100:
        d = monto * 0.20
        
    else:
        d = monto * 0.10
             
elif cli == 2:
    
    if monto > 200:
        d = monto * 0.10
        
    else:
        
        d = monto * 0.05
       
final = monto - d

print("descuento sale: ", d)

print("monto final es: ", final)