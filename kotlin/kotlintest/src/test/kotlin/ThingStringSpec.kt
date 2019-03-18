import io.kotlintest.matchers.shouldBe
import io.kotlintest.properties.forAll
import io.kotlintest.properties.headers
import io.kotlintest.properties.row
import io.kotlintest.properties.table
import io.kotlintest.specs.StringSpec

class ThingStringSpec : StringSpec() { init {
    "it should callForAction" {
        val thing = Thing()
        val value = thing.callForAction()
        value shouldBe "Food"
    }

    "table callForAction" {
        val thing = Thing()

        val testTable = table(
            headers("food",      "result"),
            //-----|-----------|------------------------
            row    ("chocolate", "Dog eats chocolate."),
            row    ("bone",      "Dog eats fish.")
        )
        forAll(testTable) { food, result ->
            thing.callForAction(food) shouldBe result
        }
    }

}}
