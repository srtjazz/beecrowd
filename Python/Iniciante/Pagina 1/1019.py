# -*- coding: utf-8 -*-

# Conversão de Tempo

# Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e
# informe-o expresso no formato horas:minutos:segundos.

# Entrada
# O arquivo de entrada contém um valor inteiro N.

# Saída
# Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme
# exemplo fornecido.

n = int(input())

minutes, seconds = divmod(n, 60)
hours, minutes = divmod(minutes, 60)

print("%d:%d:%d" % (hours, minutes, seconds))