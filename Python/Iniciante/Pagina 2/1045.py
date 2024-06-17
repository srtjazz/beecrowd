# -*- coding: utf-8 -*-

# Tipos de Triângulos

# Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o
# lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes
# três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

# se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
# se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
# se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
# se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
# se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
# se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
# Entrada
# A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C
# (0 < C).

# Saída
# Imprima todas as classificações do triângulo especificado na entrada.

a, b, c=list(map(float,input().split()))

if(a < b):
    temp = a
    a = b
    b = temp
if(b < c):
    temp = b
    b = c
    c = temp
if(a < b):
    temp = a
    a = b
    b = temp
if(a>=(b+c)):
    print("NAO FORMA TRIANGULO")
elif(a*a == (b*b+c*c)):
     print("TRIANGULO RETANGULO")
elif(a * a > (b*b+ c*c)):
    print("TRIANGULO OBTUSANGULO")
elif(a*a<(b*b + c*c)):
    print("TRIANGULO ACUTANGULO")
if(a == b and b == c):
        print("TRIANGULO EQUILATERO")
elif(a == b or b == c):
        print("TRIANGULO ISOSCELES")

