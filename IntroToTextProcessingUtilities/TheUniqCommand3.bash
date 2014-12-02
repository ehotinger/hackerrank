#!/bin/bash
uniq -c -i | sed 's/ *$//' | sed 's/^ *//'

# uniq -c - i should be sufficient here, but in order to match hackerrank's formatting, I threw in the seds. 
# The first removes trailing whitespace; the second removes starting whitespace.
# This effectively just performs a trim() on the output.