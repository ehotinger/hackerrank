#!/bin/bash
read N
X=0
T=0
while [ $X -lt $N ]
do
	read Y
	let "T += $Y"

	X=$((X+1))
done

echo $(printf %.3f $(echo $T/$N | bc -l))