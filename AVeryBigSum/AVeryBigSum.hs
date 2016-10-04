main = do
  n <- readLn :: IO Int
  line <- getLine
  let a = map read $ words line :: [Int]

  print $ sum a
