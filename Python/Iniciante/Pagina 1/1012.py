# -*- coding: utf-8 -*-

# Área

# Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
# Em seguida, calcule e mostre:
# a) a área do triângulo retângulo que tem A por base e C por altura.
# b) a área do círculo de raio C. (pi = 3.14159)
# c) a área do trapézio que tem A e B por bases e C por altura.
# d) a área do quadrado que tem lado B.
# e) a área do retângulo que tem lados A e B.
# Entrada
# O arquivo de entrada contém três valores com um dígito após o ponto decimal.

# Saída
# O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas
# descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o
# valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

a, b, c = map(float, input().split())
pi = 3.14159

triangle_area = (a * c) / 2
circle_area = (c * c) * pi
trapeze_area = ((a + b) * c) / 2
square_area = b * b
rectangle_area = a * b


print(f"TRIANGULO: {triangle_area:.3f}")
print(f"CIRCULO: {circle_area:.3f}")
print(f"TRAPEZIO: {trapeze_area:.3f}")
print(f"QUADRADO: {square_area:.3f}")
print(f"RETANGULO: {rectangle_area:.3f}")