module Lib
    ( someFunc, double, half
    ) where

double x = x * 2

half x = x / 2

someFunc :: IO ()
someFunc = putStrLn "someFunc"
