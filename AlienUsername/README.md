Alien Username
==============
In a galaxy far far away, a planet different from ours, computer usernames follow a different format.

- It has to begin with either an underscore ‘_’ (ascii value 95) or a dot ‘.’ (ascii value 46)
- It has to be immediately followed by one or more occurrences of digits numbered 0-9
- It can then have letters, either uppercase or lowercase, 0 or more in number
- It can then end with an optional ‘_’ (ascii value 95)

Your task is to validate whether a username is valid or not

###Input Format###

First line contains N, N usernames follow each in a newline.

###Constraints###

```
1 <= N <= 100
```

###Output Format###

For every username, print

###VALID###

if you think the username is correct and print

###INVALID###

otherwise.

###Sample Input###

```
3
_0898989811abced_
_abce
_09090909abcD0
```

###Sample Output###

```
VALID
INVALID
INVALID
```

###Explanation###

- The first username is valid as it passes all the 3 constraints as mentioned above.
- The second username is invalid as ‘_’ is not immediately followed by a number.
- The third username is also invalid as letters are immediately followed by a number which is not a valid format.