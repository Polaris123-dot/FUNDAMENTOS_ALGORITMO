
ctot = 0
cexc = 0
cbue = 0
capr = 0
cdes = 0
suma = 0
nmax = 0
nmin = 0

while True:

    n = float(input("Mete una nota 0-20 o pon -1 para ya terminar: "))

    if n == -1:
        break 
        
        
    if n >= 0 and n <= 20:
        
        ctot += 1
        suma += n

        if ctot == 1:
            nmax = n
            nmin = n
        else:
            if n > nmax:
                nmax = n
            if n < nmin:
                nmin = n
                
        if n >= 17:
            cexc += 1
            print("EXCELENTE")
        else:
            if n >= 14:
                cbue += 1
                print("BUENO")
            else:
                if n >= 11:
                    capr += 1
                    print("APROBADO")
                else:
                    cdes += 1
                    print("DESAPROBADO")
                    
                    
    else:
        print("Oe, la nota tiene que ser entre 0 y 20")
        
if ctot > 0:
    
    prom = suma / ctot
    
    
    print("\nNotas procesadas:", ctot)
    print("Promedio del salon:", prom)
    print("La nota mas alta:", nmax)
    print("La nota mas baja:", nmin)
    

    print("Excelentes:", cexc)
    print("Buenos:", cbue)
    print("Aprobados:", capr)
    print("Desaprobados:", cdes)
    
    
else:
    print("No ingresaste ni un dato, asi no se puede pe")