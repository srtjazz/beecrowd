# -*- coding: utf-8 -*-

# Tempo de Jogo

# Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo
# que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora
# e máxima de 24 horas.

# Entrada
# A entrada contém dois valores inteiros representando a hora de início e a hora de fim do
# jogo.

# Saída
# Apresente a duração do jogo conforme exemplo abaixo.

initial_time, final_time = map(int, input().split())

if initial_time > final_time:
  total_time = 24 - (initial_time - final_time)
  print(f"O JOGO DUROU {total_time} HORA(S)")
elif final_time > initial_time:
  total_time = final_time - initial_time
  print(f"O JOGO DUROU {total_time} HORA(S)")
else:
  print("O JOGO DUROU 24 HORA(S)")