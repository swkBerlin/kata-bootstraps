module Lib( fizzBuzz ) where

fizzBuzz :: Int -> String
fizzBuzz i | i`mod`15 == 0 = "FizzBuzz"
           | i`mod`3 == 0 = "Fizz"
           | i`mod`5 == 0 = "Buzz"
           | otherwise = show i


