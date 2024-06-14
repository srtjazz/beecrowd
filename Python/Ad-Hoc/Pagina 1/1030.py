# -*- coding: utf-8 -*-

def josephus(n, k):
  people = list(range(1, n + 1))
  index = 0

  while len(people) > 1:
    index = (index + k - 1) % len(people)
    del people[index]

  return people[0]

number_cases = int(input())

for case in range(1, number_cases + 1):
  n, k = map(int, input().split())
  survivor = josephus(n, k)
  print(f"Case {case}: {survivor}")

