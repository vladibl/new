# 1. Задайте список из нескольких чисел. Напишите программу,
# которая найдёт сумму элементов списка, стоящих на нечётной позиции.


from random import randint

Number = int(input("введите число : "))

list = [randint(1, 20) for i in range(Number*2)]



sum = 0
num = ""
for i in range(1, len(list), 2):
    sum = sum + list[i]
    num = num + str(list[i]) + ","
print(num, 'ответ: ', sum)
