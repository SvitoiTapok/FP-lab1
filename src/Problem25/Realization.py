x1 = 1
x2 = 1
i = 1
while True:
    x1, x2 = x1 + x2, x1
    i+=1
    if len(str(x2))==1000:
        break
print(i)