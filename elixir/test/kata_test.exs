defmodule KataTest do
  use ExUnit.Case
  doctest Kata

  test "greets the world" do
    assert Kata.hello() == :universe
  end
end
