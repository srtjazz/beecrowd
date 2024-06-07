# -*- coding: utf-8 -*-

# Cédulas

# Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual
# o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir
# mostre o valor lido e a relação de notas necessárias.

# Entrada
# O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

# Saída
# Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias,
# conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso
# contrário seu programa apresentará a mensagem: “Presentation Error”.

cedules = int(input())
firstValue = cedules

cedules_100 = int(cedules / 100)
cedules %= 100

cedules_50 = int(cedules / 50)
cedules %= 50

cedules_20 = int(cedules / 20)
cedules %= 20

cedules_10 = int(cedules / 10)
cedules %= 10

cedules_5 = int(cedules / 5)
cedules %= 5

cedules_2 = int(cedules / 2)
cedules %= 2

print(firstValue)
print(f"{cedules_100} nota(s) de R$ 100,00")
print(f"{cedules_50} nota(s) de R$ 50,00")
print(f"{cedules_20} nota(s) de R$ 20,00")
print(f"{cedules_10} nota(s) de R$ 10,00")
print(f"{cedules_5} nota(s) de R$ 5,00")
print(f"{cedules_2} nota(s) de R$ 2,00")
print(f"{cedules} nota(s) de R$ 1,00")
