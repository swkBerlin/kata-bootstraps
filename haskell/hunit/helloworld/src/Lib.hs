module Lib
    ( someFunc, double, half
    ) where


import Data.Text.Titlecase

greet :: String -> String
greet who =
  "Hello, " <> who <> "!"

double x = x * 2

half x = x / 2

someFunc :: IO ()
someFunc = putStrLn "someFunc"
