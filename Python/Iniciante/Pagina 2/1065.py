# Pares entre Cinco Números

# Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são 
# pares e mostre esta informação.

# Entrada
# O arquivo de entrada contém 5 valores inteiros quaisquer.

# Saída
# Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares
# lidos.
pair_numbers = []

for _ in range(5):
  number_input = int(input())
  if number_input % 2 == 0:
    pair_numbers.append(number_input)
    
print(f"{len(pair_numbers)} valores pares")