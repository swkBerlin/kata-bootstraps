import Test.Hspec
import Lib (double, half)

main :: IO ()
main = hspec $ do
  describe "double" $ do
    it "doubling makes numbers bigger" $ do
      (double 4) `shouldBe` (8 :: Int)

  describe "half" $ do
    it "halving makes numbers smaller SHOULD FAIL" $ do
      (double 4) `shouldBe` (4 :: Int)
