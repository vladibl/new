# Напишите программу, которая принимает на вход цифру,
# обозначающую день недели, и проверяет, является ли этот день выходным.


Number = int(input("введите день недели от 1-7: "))
if Number <= 5  or Number > 7:
    print(f" {Number}  Будний день")
else:
    print(f"  {Number}  Выходной день") 


