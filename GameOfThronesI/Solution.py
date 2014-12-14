word = raw_input()

letter_counts = {}

for c in word:
    if c in letter_counts:
        letter_counts[c] += 1
    else:
        letter_counts[c] = 1

odd_counts = 0
for c in letter_counts:
    if letter_counts[c] % 2 != 0:
        odd_counts += 1

if odd_counts <= 1:
    print "YES"
else:
    print "NO"