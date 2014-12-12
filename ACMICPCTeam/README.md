###Problem Statement###

You are given a list of N people who are attending ACM-ICPC World Finals. Each of them are either well versed in a topic or they are not. Find out the maximum number of topics a 2-person team can know. And also find out how many teams can know that maximum number of topics.

###Input Format###

The first line contains two integers N and M separated by a single space, where N represents the number of people, and M represents the number of topics. N lines follow.

Each line contains a binary string of length M. In this string, 1 indicates that the ith person knows a particular topic, and 0 indicates that the ith person does not know the topic.

###Output Format###

On the first line, print the maximum number of topics a 2-person team can know. 
On the second line, print the number of 2-person teams that can know the maximum number of topics. 

###Constraints###

```
2 ≤ N ≤ 500 

1 ≤ M ≤ 500
```

###Sample Input###

```
4 5
10101
11100
11010
00101
```

###Sample Output###

```
5
2
```

###Explanation###

(1, 3) and (3, 4) know all the 5 topics. So the maximal topics a 2-person team knows is 5, and only 2 teams can achieve this.