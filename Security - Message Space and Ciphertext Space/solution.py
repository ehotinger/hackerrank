import sys
n = raw_input()

for c in n:
	sys.stdout.write(str((int(c) + 1) % 10))