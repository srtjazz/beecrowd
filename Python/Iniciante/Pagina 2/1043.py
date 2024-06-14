# -*- coding: utf-8 -*-

# Triângulo

# Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso
# positivo, calcule o perímetro do triângulo e apresente a mensagem:


# Perimetro = XX.X


# Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura,
# mostrando a mensagem


# Area = XX.X

# Entrada
# A entrada contém três valores reais.

# Saída
# O resultado deve ser apresentado com uma casa decimal.

a, b, c = map(float, input().split())

is_ab = a + b
is_ac = a + c
is_bc = b + c

if(is_ab > c and is_ac > b and is_bc > a):
  print(f"Perimetro = {a + b + c}")
else:
  print(f"Area = {((a + b) * c) / 2}")