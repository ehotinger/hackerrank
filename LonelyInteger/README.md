# Lonely Integer

There are N integers in an array A. All but one integer occurs in pairs. Your task is to find out that number that occurs only once.

## Input Format

The first line of the input contains an integer N indicating N integers in the array A. Next line contains N integers each separated by a single space.

## Constraints

```
1 <= N < 100
N % 2 = 1 ( N is an odd number )
0 <= i <= 100, ∀ i ∈ A
```

## Output Format

Output (S) which is the number that occurs only once.

## Examples

### 1 element

**Input**

```
1
```

**Output**

```
1
```

**Explanation**

We see only one element making it the answer (1).

### 3 elements

**Input**

```
1 1 2
```

**Output**

```
2
```

**Explanation**

We see three elements. 1 is repeated twice, 2 only appears once making the element 2 the answer.


### 5 elements

**Input**

```
0 0 1 2 1
```

**Output**

```
2
```

**Explanation**

We see five elements. 1 and 0 are repeated twice, 2 only appears once making the element 2 the answer.
