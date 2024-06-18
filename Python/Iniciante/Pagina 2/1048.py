# -*- coding: utf-8 -*-

# Aumento de Salário

# A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com
# a tabela abaixo:


# Salário	          Percentual de Reajuste
# 0 - 400.00                  15%
# 400.01 - 800.00             12%
# 800.01 - 1200.00            10%
# 1200.01 - 2000.00           7%
# Acima de 2000.00            4%

# Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste
# ganho e o índice reajustado, em percentual.

# Entrada
# A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

# Saída
# Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser
# apresentados com 2 casas decimais) e o percentual de reajuste ganho, conforme exemplo
# abaixo.

def checksReajust(salary):
  new_salary = 0
  reajust = 0
  reajust_percentage = 0

  if salary >= 0 and salary <= 400:
    reajust = salary * 0.15
    new_salary = salary + reajust
    reajust_percentage = 15
  elif salary > 400 and salary <= 800:
    reajust = salary * 0.12
    new_salary = salary + reajust
    reajust_percentage = 12
  elif salary > 800 and salary <= 1200:
    reajust = salary * 0.10
    new_salary = salary + reajust
    reajust_percentage = 10
  elif salary > 1200 and salary <= 2000:
    reajust = salary * 0.07
    new_salary = salary + reajust
    reajust_percentage = 7
  elif salary > 2000:
    reajust = salary * 0.04
    new_salary = salary + reajust
    reajust_percentage = 4
  return print(f"Novo salario: {new_salary:.2f}\n"
               f"Reajuste ganho: {reajust:.2f}\n"
               f"Em percentual: {reajust_percentage} %")
    
salary = float(input())

checksReajust(salary)