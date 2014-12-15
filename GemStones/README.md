Gem Stones
==========
John has discovered various rocks. Each rock is composed of various elements, and each element is represented by a lowercase latin letter from 'a' to 'z'. An element can be present multiple times in a rock. An element is called a 'gem-element' if it occurs at least once in each of the rocks.

Given the list of rocks with their compositions, you have to print how many different kinds of gem-elements he has.

###Input Format###
The first line consists of N, the number of rocks. 
Each of the next N lines contain rocks' composition. Each composition consists of small alphabets of English language.

###Output Format###
Print the number of different kinds of gem-elements he has.

###Constraints###

```
1 ≤ N ≤ 100 
Each composition consists of only small latin letters ('a'-'z'). 
1 ≤ Length of each composition ≤ 100
```

###Sample Input###

```
3
abcdde
baccd
eeabg
```

###Sample Output###

```
2
```

###Explanation###
Only "a", "b" are the two kind of gem-elements, since these characters occur in each of the rocks' composition.