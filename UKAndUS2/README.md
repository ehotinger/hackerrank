UK and US: Part 2
==================
We’ve already seen how UK and US words differ in their spelling. One other difference is how UK has kept the usage of letters our in some of its words and US has done away with the letter u and uses just or. Given the UK format of the word that has our in it, find out the total number of occurrences of both its UK and US variants in a given sequence of words.

###Input Format###

First line contains an integer N. N lines follow, each line contains a sequence of words (W) separated by a single space.
Next lines contains an integer T. T testcases follow in a new line. Each line contains the UK spelling of a word (W’)

###Constraints###

```
1 <= N <= 10
Each line doesn’t contain more than 10 words (W)
Each character of W and W’ is a lowercase alphabet.
If C is the count of the number of characters of W or W’, then
1 <= C <= 20
1 <= T <= 10
W’ that has our as a sub-string in it.
```

###Output Format###

Output T lines and in each line output the number of UK and US version of (W’) in all of N lines that contains a sequence of words.

###Sample Input###

```
2
the odour coming out of the left over food was intolerable
ammonia has a very pungent odor
1
odour
```

###Sample Output###

```
2
```

###Explanation###

In the given 2 lines, we find odour and odor once each. So, the total count is 2.