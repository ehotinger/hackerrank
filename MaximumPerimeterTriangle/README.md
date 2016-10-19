# Maximum Perimeter Triangle ([HackerRank Page](https://www.hackerrank.com/challenges/maximum-perimeter-triangle))
Given *n* sticks of lengths *l<sub>0</sub> ,l<sub>1</sub> , ... l<sub>n-1</sub>* , use 3 of the sticks to construct a non-[degenerate](https://en.wikipedia.org/wiki/Degeneracy_(mathematics)) triangle with the maximum possible perimeter. Then print the lengths of its sides as 3 space-separated integers in non-decreasing order.

If there are several valid triangles having the maximum perimeter:

1. Choose the one with the *longest maximum side* (i.e., the largest value for the longest side of any valid triangle having the maximum perimeter).
2. If more than one such triangle meets the first criterion, choose the one with the *longest minimum side* (i.e., the largest value for the shortest side of any valid triangle having the maximum perimeter).
3. If more than one such triangle meets the second criterion, print any one of the qualifying triangles.

If no non-degenerate triangle exists, print -1.

###Input Format
The first line contains single integer, *n*, denoting the number of sticks.
The second line contains *n* space-separated integers, *l<sub>0</sub> ,l<sub>1</sub> , ... l<sub>n-1</sub>* , describing the respective stick lengths.

###Constraints
* 3 <= *n* <= 50
* 1 <= *l<sub>i</sub>* <= 10<sup>9</sup>

###Output Format
Print 3 non-decreasing space-separated integers, *a*, *b*, and *c* (where *a* <= *b* <= *c*) describing the respective lengths of a triangle meeting the criteria in the above *Problem Statement*.

If no non-degenerate triangle can be constructed, print -1.

###Sample Input 0
```
5
1 1 1 3 3
```
###Sample Output 0
```
1 3 3
```
###Sample Input 1
```
3
1 2 3
```
###Sample Output 1
```
-1
```

###Explanation

*Sample Case 0:*

There are 2 possible unique triangles:

1. (1,1,1)
2. (1,3,3)

The second triangle has the largest perimeter, so we print its side lengths on a new line in non-decreasing order.

*Sample Case 1:*

The triangle (1,2,3) is degenerate and thus can't be constructed, so we print -1 on a new line.
