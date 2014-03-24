#!/usr/bin/python
#A positive integer ω is a Fibonacci number if and only if one of 5ω2 + 4 and 5ω2 - 4 is a perfect square.
from math import *
for _ in range(int(raw_input())):
    n = int(raw_input())
    root1 = sqrt(5 * n**2 + 4)
    root2 = sqrt(5 * n**2 - 4)
    isFibo = root1 % 1 == 0 or root2 % 1 == 0

    if(isFibo):
        print "IsFibo"

    else:
        print "IsNotFibo"