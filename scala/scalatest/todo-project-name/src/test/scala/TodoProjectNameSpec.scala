import org.scalatest._

abstract class UnitSpec extends FlatSpec with Matchers

class TodoProjectNameSpec extends UnitSpec {

  behavior of "TODO system"

  it should "show that scalatest works" in {
    42 shouldBe 43
  }
}
