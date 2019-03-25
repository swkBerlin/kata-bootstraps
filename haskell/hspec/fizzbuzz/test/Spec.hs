import Test.Hspec
import Test.QuickCheck
import Lib (fizzBuzz)



main :: IO ()
main = hspec $ do
  describe "3->Fizz" $ do
    it "(excluding multiple of 5) multiple of 3 should be Fizz" $ do
      property $ \x -> x`mod`5==0 || fizzBuzz (x*3) == "Fizz"
  describe "5->Buzz" $ do
    it "(excluding multiple of 3) multiple of 5 should be Buzz" $ do
      property $ \x -> x`mod`3==0 || fizzBuzz (x*5) == "Buzz"
  describe "15->FizzBuzz" $ do
    it "multiple of 3 and 5 should be FizzBuzz" $ do
      property $ \x -> fizzBuzz (x*15) == "FizzBuzz"
  describe "other->shown" $ do
    it "if neither multiple of 3 nor 5 then number shall be shown" $ do
      property $ \x -> x`mod`3==0 || x`mod`5==0 || fizzBuzz x == show x


