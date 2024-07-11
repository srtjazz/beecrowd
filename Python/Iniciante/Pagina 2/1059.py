# Números Pares

# Faça um programa que mostre os números pares entre 1 e 100, inclusive.

# Entrada
# Neste problema extremamente simples de repetição não há entrada.

# Saída
# Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada.

for i in range(1, 100):
  i += 1
  if i % 2 == 0 :
    print(i)
  