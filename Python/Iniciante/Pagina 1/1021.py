# -*- coding: utf-8 -*-

# Notas e Moedas

# Leia um valor de ponto flutuante com duas casas decimais. Este valor
# representa um valor monetário. A seguir, calcule o menor número de
# notas e moedas possíveis no qual o valor pode ser decomposto. As
# notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis
# são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação
# de notas necessárias.

# Entrada
# O arquivo de entrada contém um valor de ponto flutuante N
# (0 ≤ N ≤ 1000000.00).

# Saída
# Imprima a quantidade mínima de notas e moedas necessárias para
# trocar o valor inicial, conforme exemplo fornecido.

# Obs: Utilize ponto (.) para separar a parte decimal.

value = float(input())

coins = int(value * 100)

cedules_100 = int(coins / 10000)
coins %= 10000

cedules_50 = int(coins / 5000)
coins %= 5000

cedules_20 = int(coins / 2000)
coins %= 2000

cedules_10 = int(coins / 1000)
coins %= 1000

cedules_5 = int(coins / 500)
coins %= 500

cedules_2 = int(coins / 200)
coins %= 200

coins_1 = int(coins / 100)
coins %= 100

coins_05 = int(coins / 50)
coins %= 50

coins_025 = int(coins / 25)
coins %= 25

coins_010 = int(coins / 10)
coins %= 10

coins_005 = int(coins / 5)
coins %= 5

coins_001 = coins

print("NOTAS:")
print(f"{cedules_100} nota(s) de R$ 100.00")
print(f"{cedules_50} nota(s) de R$ 50.00")
print(f"{cedules_20} nota(s) de R$ 20.00")
print(f"{cedules_10} nota(s) de R$ 10.00")
print(f"{cedules_5} nota(s) de R$ 5.00")
print(f"{cedules_2} nota(s) de R$ 2.00")
print("MOEDAS:")
print(f"{coins_1} moeda(s) de R$ 1.00")
print(f"{coins_05} moeda(s) de R$ 0.50")
print(f"{coins_025} moeda(s) de R$ 0.25")
print(f"{coins_010} moeda(s) de R$ 0.10")
print(f"{coins_005} moeda(s) de R$ 0.05")
print(f"{coins_001} moeda(s) de R$ 0.01")
