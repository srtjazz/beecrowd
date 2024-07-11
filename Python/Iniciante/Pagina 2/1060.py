# Números Positivos

# Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos
# (desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

# Entrada
# Seis valores, negativos e/ou positivos.

# Saída
# Imprima uma mensagem dizendo quantos valores positivos foram lidos.
counter = 0
positive_numbers = []

while counter < 6:
  number_input = float(input())
  if number_input > 0:
    positive_numbers.append(number_input)
  counter += 1

print(f"{len(positive_numbers)} valores positivos")