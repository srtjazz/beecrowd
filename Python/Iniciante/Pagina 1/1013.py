# -*- coding: utf-8 -*-

# O Maior

# Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

# (a + b + abs(a-b)) / 2

# Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

# Entrada
# O arquivo de entrada contém três valores inteiros.

# Saída
# Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

a, b, c = map(int, input().split())

greater_ab = max(a, b)
greater = max(greater_ab, c)

print(f"{greater} eh o maior")