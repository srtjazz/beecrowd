# -*- coding: utf-8 -*-

# Sort Simples

# Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem
# crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

# Entrada
# A entrada contem três números inteiros.

# Saída
# Imprima a saída conforme foi especificado.

X = [int(i) for i in input().strip().split(' ')]

x = X[:]

x.sort()

for i in range(3):
  print(x[i])

print()

for i in range(3):
  print(X[i])

