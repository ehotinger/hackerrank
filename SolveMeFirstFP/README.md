# Solve Me First FP
- HackerRank link: [hackerrank.com/challenges/fp-solve-me-first](https://www.hackerrank.com/challenges/fp-solve-me-first)
- Difficulty: **Easy**
- Solution added: **Haskell**, **Fsharp**

# Solution
## Haskell
```haskell
main = do
    a <- readLn :: IO Int
    b <- readLn :: IO Int
    print (a + b)
```
### Explanation
```haskell
main = do
```
We first create a block of main program.

```haskell
    a <- readLn :: IO Int
    b <- readLn :: IO Int
```
Then, we ask user input. Both `a` and `b` read Integer from the IO.

```haskell
    print (a + b)
```
Last, we simply `print` the sum of `a` and `b`. Why we use `print` instead of `putStrLn`? Because it's a **number**. That's it!

## Fsharp
You may explain here...

# EOF
You may add your own solution with your own favorite language.
Apologize for my bad English, I'm really glad if you want to correct it.
