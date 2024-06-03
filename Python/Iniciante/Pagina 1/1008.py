# -*- coding: utf-8 -*-

# Salário

# Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o
# valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número
# e o salário do funcionário, com duas casas decimais.

# Entrada
# O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais,
# representando o número, quantidade de horas trabalhadas e o valor que o funcionário 
# recebe por hora trabalhada, respectivamente.

# Saída
# Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço
# em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço
# em branco após o $.

employee_number = int(input())
hours_worked = int(input())
salary_per_hour = float(input())

final_salary = salary_per_hour * hours_worked

print(f"NUMBER = {employee_number}")
print(f"SALARY = U$ {final_salary:.2f}")