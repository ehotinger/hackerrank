Utopian Tree
=============================
The Utopian tree goes through 2 cycles of growth every year. The first growth cycle of the tree is during the monsoon season when it doubles in height. The second growth cycle is during the summer when it increases in height by 1 meter. If a new Utopian tree sapling of height 1 meter is planted just before the onset of the monsoon season, can you find the height of the tree after N cycles?

###Input Format###
The first line of the input contains an integer T, the number of testcases. 
T lines follow each line containing the integer N, indicating the number of cycles.

###Constraints###

```
1 <= T <= 10
0 <= N <= 60
```

###Output Format###
Print the height of the Utopian tree after N cycles.

###Sample Input #00:###

```
2
0
1
```

###Sample Output #00:###

```
1
2
```

###Explanation #00:###

There are 2 testcases. When N = 0, the height of the tree remains unchanged. When N = 1, the tree doubles its height as it’s planted just before the onset of monsoon.

###Sample Input: #01:###

```
2
3
4
```

###Sample Output: #01:###

```
6
7
```

###Explanation: #01:###

There are 2 testcases. When N = 3, the height of the tree at the end of the 1st cycle doubles to 2, at the end of the 2nd cycle it increases by 1 and at the end of the 3rd cycle, it doubles its height to 6. When N = 4, the height of the tree increases from 6 to 7.