main = do
  n <- readLn :: IO Int
  line <- getLine
  let list = map read $ words line :: [Int]
  print $ sum list
