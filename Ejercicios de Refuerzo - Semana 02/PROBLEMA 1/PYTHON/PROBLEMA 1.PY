
print("Ingresa la nota")
nota = float(input())

if nota < 11:

    print("DESAPROBADO")
elif nota >= 11 and nota < 20:

    print("APROBADO")

elif nota == 20:

    print("EXCELENTE")
else:
    print("DATOS INGRESADOS INCORRECTOS")