#Задайте последовательность чисел. Напишите программу, которая выведет
#список неповторяющихся элементов исходной последовательности.


a = [int (i) for i in input("Введите числа через пробел:  ").split()]
for i in a:
   if a.count(i) == 1:

     print(i)

    #я забыл указать в программе что силса указываются через пробел