# Pares, Ímpares, Positivos e Negativos

# Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos
# valores digitados foram ímpares, quantos valores digitados foram positivos e quantos
# valores digitados foram negativos.

# Entrada
# O arquivo de entrada contém 5 valores inteiros quaisquer.

# Saída
# Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo
# o final de linha após cada uma.
def count_numbers(numbers):
  pairs = 0
  odds = 0
  positives = 0
  negatives = 0

  for number in numbers:
    if number % 2 == 0:
      pairs += 1
    else:
      odds += 1
    if number > 0:
      positives += 1
    elif number < 0:
      negatives += 1
  
  return pairs, odds, positives, negatives

numbers = []
for _ in range(5):
  numbers.append(int(input()))

pairs, odds, positives, negatives = count_numbers(numbers)

print(f"{(pairs)} valor(es) par(es)\n"
      f"{(odds)} valor(es) impar(es)\n"
      f"{(positives)} valor(es) positivo(s)\n"
      f"{(negatives)} valor(es) negativo(s)")