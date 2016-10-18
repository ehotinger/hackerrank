#!/bin/python3

import sys


h = int(input().strip())
m = int(input().strip())

hstr = ['one','two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 
        'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen',
        'eighteen', 'nineteen', 'twenty', 'twenty one', 'twenty two', 'twenty three', 
        'twenty four', 'twenty five', 'twenty six', 'twenty seven', 'twenty eight', 
        'twenty nine', 'thirty']

hour = hstr[h-1]

if m == 0:
    print(hour + ' o\' clock')
elif m == 15:
    print('quarter past ' + hour)
elif m == 30:
    print('half past ' + hour)
elif m == 1:
    print('one minute past ' + hour)
elif m < 30:
    print(hstr[m-1] + ' minutes past ' + hour)
else:
    hour = hstr[h] if h < 12 else hstr[h-12]
    if m == 45:
        print('quarter to ' + hour)
    elif m == 59:
        print('one minute to ' + hour)
    else:
        print(hstr[60-m-1] + ' minutes to ' + hour)
