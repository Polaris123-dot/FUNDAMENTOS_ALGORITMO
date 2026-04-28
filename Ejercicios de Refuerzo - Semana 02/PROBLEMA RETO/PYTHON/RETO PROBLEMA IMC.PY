peso = float(input("Ingresa el peso KG: "))

altura = float(input("Ingresa la altura: "))

if altura > 3:

    altura /= 100

    print(f"Altura en Cm, convertida a: {altura} m")

imc = peso / (altura ** 2 )

print(f"El resultado IMC es: {imc}"  )

if imc < 18.5: 


    print("DIAGNOSTICO: BAJO PESO")

if imc >= 18.5 and imc < 25:


    print("DIAGNOSTICO: PESO NORMAL")

if imc >= 25 and imc < 30:

    print("DIAGNOSTICO: SOBREPESO")
 

if imc >= 30:
    print("DIAGNOSTICO: OBESIDAD")