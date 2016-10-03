# Simple Array Sum
- HackerRank link: [hackerrank.com/challenges/simple-array-sum](https://www.hackerrank.com/challenges/simple-array-sum)
- Difficulty: Easy
- Solution(s) added in: Haskell

# Solution(s)
## Haskell
```haskell
main = do
  n <- readLn :: IO Int
  line <- getLine
  let list = map read $ words line :: [Int]
  print $ sum list
```
### Explanation
```haskell
main = do
```
We first create a block of main program.

```haskell
  n <- readLn :: IO Int
```
Then, we ask user to input N for denoting the size of array.
We just ask it, because `n` is useless here.
You'll know why in the bottom. But, what happens with `readLn :: IO Int`?
It's read user's input to `IO Int` (Integer) form.

```haskell
  line <- getLine
  let list = map read $ words line :: [Int]
```
After that, we ask for the next line. This line contain the "real" data for sum the array (in Haskell we call it List).
First, we take the input as String. Last, we transform it into List of Integer.
How? With `words` that transform String into List of String, we can read every value and transform it into Integer.
But, we need `map` to do that. Okay, we got `map read $ words line :: [Int]`.
If you don't know `$` sign, it's for replace the brackets. Example? You may replace `print (1 + 2)` with `print $ 1 + 2`.
Like that.

```haskell
  print $ sum list
```
Last, we print sum of the array (List in Haskell). The `sum` function summing all the value of the List.

# EOF
You may add your own solution with your own favorite language.
Apologize for my bad English, I'm really glad if you want to correct it.
