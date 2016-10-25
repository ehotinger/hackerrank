#!/bin/python3

import sys
import math

t = int(input().strip())
for a0 in range(t):
    n,k = input().strip().split(' ')
    n,k = [int(n),int(k)]
    perm = list()
    hasPerm = False
    if (k == 0):
        hasPerm = True
        perm = range(1, n+1)
    elif((k <= n/2) and (n%k == 0) and ((n/k)%2 == 0)):
        hasPerm = True
        for i in range(n):
            if( math.floor((i/k) % 2) == 0):
                perm.append(i+k+1)
            else:
                perm.append(i-k+1)
    else:
        hasPerm = False

    if(hasPerm):
        print(' '.join(map(str, perm)))
    else:
        print(-1)
