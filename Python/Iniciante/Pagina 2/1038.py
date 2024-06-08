# -*- coding: utf-8 -*-

# Lanche

# Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade 
# deste item. A seguir, calcule e mostre o valor da conta a pagar.

# codigo   especificação     preço
# 1        Cachorro quente   R$ 4.00
# 2        X-salada          R$ 4.50
# 3        X-bacon           R$ 5.00
# 4        Torrada simples   R$ 2.00
# 5        Refrigerante      R$ 1.50

# Entrada
# O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade
# de um item conforme tabela acima.

# Saída
# O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com
# 2 casas após o ponto decimal.

code, item_quantity = map(int, input().split())

food = {
  1: 4.00,
  2: 4.50,
  3: 5.00,
  4: 2.00,
  5: 1.50,
}

price = food[code]
total_value = price * item_quantity

print(f"Total: R$ {total_value:.2f}")

