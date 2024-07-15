# Positivos e Média

# Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na
# próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um
# dígito após o ponto decimal.

# Entrada
# A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo
# menos um destes números será positivo.

# Saída
# O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve
# mostrar a média dos valores positivos digitados.
positive_numbers = []

for _ in range(6):
  number_input = float(input())
  if number_input > 0:
    positive_numbers.append(number_input)

positive_numbers_quantity = len(positive_numbers)
positive_numbers_media = sum(positive_numbers) / positive_numbers_quantity

print(f"{positive_numbers_quantity} valores positivos\n"
      f"{positive_numbers_media:.1f}")