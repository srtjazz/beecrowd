# -*- coding: utf-8 -*-

# Cálculo Simples

# Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário
# de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada
# peça 2. Após, calcule e mostre o valor a ser pago.

# Entrada
# O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores,
# respectivamente dois inteiros e um valor com 2 casas decimais.

# Saída
# A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar
# um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado
# com 2 casas após o ponto.

piece_one_code, piece_one_quantity, piece_one_value = map(float, input().split())
piece_two_code, piece_two_quantity, piece_two_value = map(float, input().split())

piece_one_final_value = piece_one_value * piece_one_quantity
piece_two_final_value = piece_two_value * piece_two_quantity

final_value = piece_one_final_value + piece_two_final_value

print(f"VALOR A PAGAR: R$ {final_value:.2F}")