import org.scalatest._

abstract class UnitSpec extends FunSpec with Matchers

class TodoProjectNameSpec extends UnitSpec {

    describe("example test") {

        it("shows that scalatest works") {
            42 shouldBe 43
        }
    }
}
