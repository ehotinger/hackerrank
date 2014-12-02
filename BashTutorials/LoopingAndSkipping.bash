#!/bin/bash
X=0
while [ $X -le 100 ]
do
	if (($X % 2)); then
		echo $X
	fi
	X=$((X+1))
done