#!/bin/bash
read N
shopt -s nocasematch

if [[ $N == "y" ]] ; then
	echo "YES"
else
	echo "NO"
fi