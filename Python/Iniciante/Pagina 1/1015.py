# -*- coding: utf-8 -*-

# Distância Entre Dois Pontos

# Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule
# a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

# Distancia = √(x2 - x1)³ + (y2 - y1)³

# Entrada
# O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda
# linha contém dois valores de ponto flutuante x2 y2.

# Saída
# Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

import math

x1, y1 = map(float, input().split()) 


x2, y2 = map(float, input().split()) 


# p1 - 1, 7
# p2 - 5, 9
distance = pow(x2-x1, 2) + pow(y2-y1, 2)

print(f"{math.sqrt(distance):.4f}")