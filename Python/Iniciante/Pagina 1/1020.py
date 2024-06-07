# -*- coding: utf-8 -*-

# Idade em Dias

# Leia um valor inteiro correspondente à idade de uma pessoa em dias e
# informe-a em anos, meses e dias

# Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias
# e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação
# que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é
# apenas um exercício com objetivo de testar raciocínio matemático simples.

# Entrada
# O arquivo de entrada contém um valor inteiro.

# Saída
# Imprima a saída conforme exemplo fornecido.

age_in_days = int(input())

year = int(age_in_days / 365)
age_in_days %= 365

month = int(age_in_days / 30)
days = int(age_in_days % 30)

print(f"{year} ano(s)")
print(f"{month} mes(es)")
print(f"{days} dia(s)")

