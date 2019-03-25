module Main where

import Lib

main :: IO ()
main = do
  traverse (putStrLn . fizzBuzz) [1..100]
  return ()
