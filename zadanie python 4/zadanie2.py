#Задайте натуральное число N. 
#Напишите программу, которая составит список простых множителей числа N.


N = int(input('Задайте число: '))

factors = []
d = 2
m = N 
while d * d <= N:
        if N % d == 0:
            factors.append(d)
            N //= d
        else:
            d += 1
factors.append(N) 

print(m, factors)