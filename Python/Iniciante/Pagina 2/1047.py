# -*- coding: utf-8 -*-

# Tempo de Jogo com Minutos

# Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule
# a duração do jogo.

# Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

# Entrada
# Quatro números inteiros representando a hora de início e fim do jogo.

# Saída
# Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)”.
import datetime

initial_hour, initial_minute, final_hour, final_minute = map(int, input().split())

diff = datetime.timedelta(hours=final_hour - initial_hour, minutes=final_minute - initial_minute)

hours = diff.seconds // 3600
minutes = (diff.seconds % 3600) // 60

if initial_hour == final_hour and initial_minute == final_minute:
  print(f"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)")
else:
  print(f"O JOGO DUROU {hours} HORA(S) E {minutes} MINUTO(S)")