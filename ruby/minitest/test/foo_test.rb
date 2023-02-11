require "minitest/autorun"
require_relative "../foo"

class FooTest < Minitest::Test
  def test_ask_returns_an_answer
    foo = Foo.new
    assert_equal "42", foo.ask("What is the meaning of life?")
  end

  def test_pass
    foo = Foo.new
    assert_equal "13", foo.ask("What is 12 + 1 ?")
  end
end