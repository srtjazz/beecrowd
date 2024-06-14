# -*- coding: utf-8 -*-

# Múltiplos

# Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos"
# ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

# Entrada
# A entrada contém valores inteiros.

# Saída
# A saída deve conter uma das mensagens conforme descrito acima.

def verifyMultiples(num1, num2):
  if num1 % num2 == 0:
    return print("Sao Multiplos")
  else:
    return print("Nao sao Multiplos")

a, b = map(int, input().split())

if a > b:
  verifyMultiples(a, b)
elif b > a:
  verifyMultiples(b, a)