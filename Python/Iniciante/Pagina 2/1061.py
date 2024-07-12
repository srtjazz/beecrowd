# Tempo de um Evento

# Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril,
# iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o
# evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

# Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho
# a calcular a duração deste evento.

# Entrada
# Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do
# mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o
# evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá 
# outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.

# Saída
# Na saída, deve ser apresentada a duração do evento, no seguinte formato:

# W dia(s)
# X hora(s)
# Y minuto(s)
# Z segundo(s)

# Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
import datetime

first_day_input = input().split(" ")
first_day = int(first_day_input[1])
first_hour, first_minute, first_second = map(int, input().split(" : "))
last_day_input = input().split(" ")
last_day = int(last_day_input[1])
last_hour, last_minute, last_second = map(int, input().split(" : "))

diff = datetime.timedelta(days=last_day - first_day,
                           hours=last_hour - first_hour,
                           minutes=last_minute - first_minute,
                           seconds=last_second - first_second)

hours = diff.seconds // 3600
minutes = (diff.seconds % 3600) //60

print(f"{diff.days} dia(s)\n"
      f"{hours} hora(s)\n"
      f"{minutes} minuto(s)\n"
      f"{(diff.seconds % 3600) % 60} segundo(s)")
