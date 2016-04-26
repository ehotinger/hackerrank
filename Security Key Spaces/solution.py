import sys
n = raw_input()
k = int(raw_input())

for c in n:
	sys.stdout.write(str((int(c) + k) % 10))