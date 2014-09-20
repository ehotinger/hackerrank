N = input()

for i in range(N):
    num = raw_input()
    count = 0
    for digit in num:
        if digit != '0' and int(num) % int(digit) == 0:
            count = count + 1
    print count