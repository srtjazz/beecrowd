# -*- coding: utf-8 -*-

# Animal

# Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o
# esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes
# foi escolhido, através das três palavras fornecidas.

# Link para a imagem:
# https://resources.beecrowd.com/gallery/images/problems/UOJ_1049_b.png

# Entrada
# A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal
# segundo a figura acima, com todas as letras minúsculas.

# Saída
# Imprima o nome do animal correspondente à entrada fornecida.
def verifyVertebrateType(word2, word3):
  if word2 == "ave":
    if word3 == "carnivoro":
      print("aguia")
    elif word3 == "onivoro":
      print("pomba")
    
  elif word2 == "mamifero":
    if word3 == "onivoro":
      print("homem")
    elif word3 == "herbivoro":
      print("vaca")   

def verifyInvertebrateType(word2, word3):
  if word2 == "inseto":
    if word3 == "hematofago":
      print("pulga")
    elif word3 == "herbivoro":
      print("lagarta")

  elif word2 == "anelideo":
    if word3 == "hematofago":
      print("sanguessuga")
    elif word3 == "onivoro":
      print("minhoca")

word_one = str(input())
word_two = str(input())
word_three = str(input())

vertebrateType = verifyVertebrateType(word_two, word_three)
invertebrateType = verifyInvertebrateType(word_two, word_three)

if word_one == "vertebrado":
  vertebrateType

if word_one == "invertebrado":
  invertebrateType
  