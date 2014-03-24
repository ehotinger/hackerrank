#!/usr/bin/python
n,m=[int(x) for x in raw_input().split()]
total = 0
for _ in range(m):
    a,b,k=[int(x) for x in raw_input().split()]
    total += (b-a+1)*k
print (total/n)