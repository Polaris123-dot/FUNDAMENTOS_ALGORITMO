while True:
    
    print("1-Suma, 2-Resta, 3-Mult, 4-Div, 5-Salir")
    
    op = input("que vas a hacer?: ")
    
    if op == '5':
        print("baisss..")
        break
    
    if op in ['1', '2', '3', '4']:
        
        num1 = float(input("num 1: "))
        num2 = float(input("num 2: "))
      
        if op == '1':
            print("Resultado:", num1 + num2)
            
        elif op == '2':
            print("Resultado:", num1 - num2)
            
        elif op == '3':
            print("Resultado:", num1 * num2)
            
        elif op == '4':
            if num2 != 0:
                print("Resultado:", num1 / num2)
            else:
                print("error: division x 0")
                
    else:
        
        print("opcion invalida, intentalo de nuevo")


