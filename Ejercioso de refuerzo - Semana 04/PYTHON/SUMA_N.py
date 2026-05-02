n = int(input("cuantos n vas a querer sumar? "))

c = 1
s = 0

ma = None
me = None

while c <= n:
        
    val = int(input(f"mete el numero {c}: "))
        
    if c == 1:
        ma = val
        me = val
        
    else:
        if val > ma:
            ma = val
        if val < me:
            me = val      
            
    s = s + val
    c = c + 1

prom = s / n

print(f"numeros: {n}")
print(f"suma total: {s}")
print(f"el promedio: {prom}")

print(f"el mayor: {ma}")
print(f"el menor: {me}")