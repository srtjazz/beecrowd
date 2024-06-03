# -*- coding: utf-8 -*-

# Salário com Bônus

# Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas
# efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão
# sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas
# decimais.

# Entrada
# O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla
# precisão (double) com duas casas decimais, representando o salário fixo do vendedor e
# montante total das vendas efetuadas por este vendedor, respectivamente.

# Saída
# Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

name = str(input())
salary = float(input())
sales_in_one_month = float(input())

final_comission = sales_in_one_month * 0.15
final_salary = salary + final_comission

print(f"TOTAL = R$ {final_salary:.2f}")
