import org.scalatest._

abstract class UnitTest extends FunSuite with Matchers

class TodoProjectNameTest extends UnitTest {

  test("scalatest should work") {
    42 shouldBe 43
  }
}
