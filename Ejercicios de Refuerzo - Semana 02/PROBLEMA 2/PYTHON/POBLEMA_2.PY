

num1 = float(input("INGRESA EL PRIMER NUMERO"))
num2 = float(input("INGRESA SEGUNDO NUMERO"))


print("ESCOGE UNA OPERACION")
print("1 = SUMA")
print("2 = RESTA")
print("3 = MULTRIPLICACION")
print("4 = DIVISION")

opcion = int(input("Opción: "))
match opcion:
    case 1:
        print(f"RESULTADO: {num1 + num2}")
    case 2:
        print(f"RESULTADO: {num1 - num2}")
    case 3:
        print(f"RESULTADO: {num1 * num2}")
    case 4:
       
        if num2 != 0:
            print(f"RESULTADO: {num1 / num2}")
        else:
            print("No se puede dividir entre cero.")
    case _:
        print("SELECCION INVALIDA.")