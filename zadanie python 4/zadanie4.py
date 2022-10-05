import random

print('Введите степень многочлена')

arr = []

k = int(input())

for i in range(k, -1, -1):
    if i !=0:
        a = f'{str(random.randint(0, 10))}*x^{i}'
        arr.append(a)
    elif i == 0:
        a = str(random.randint(0, 101))
        arr.append(a)

pol = '+'.join(arr)

print(f'{pol}=0')