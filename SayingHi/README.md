Saying Hi
=========
You are given N lines and your task is to find out which of the N lines starts with

```
hi<BLANK>
```
where hi is case-insensitive and is not immediately followed by the letter D which is also case-insensitive

###Input Format###

First line contains an integer N, N lines follow each line with a sentence not more than 10 words W each, separated by a single space

###Constraints###

```
1 <= N <= 10
If C is the count of the number of words W in every sentence, then
1 <= C <= 10
```

Each non-empty character in W is either a lowercase or an uppercase alphabet only

###Output Format###

Print each line that satisfies the constraint as mentioned in the problem statement.

###Sample Input###

```
5
Hi Alex how are you doing
hI dave how are you doing
Good by Alex
hidden agenda
Alex greeted Martha by saying Hi Martha
```

###Sample Output###
```
Hi Alex how are you doing
The first line satisfies the constraint mentioned in the problem statement.
Second line fails as it has d following hi<blank>
Third line fails as it doesn’t start with h
Fourth fails as the third character in the line is not empty ( BLANK )
Fifth is not included in the answer as Hi Martha doesn’t appear at the beginning of the line.
```