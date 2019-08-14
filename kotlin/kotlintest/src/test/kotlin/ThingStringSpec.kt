import io.kotlintest.shouldBe
import io.kotlintest.specs.StringSpec
import io.kotlintest.tables.forAll
import io.kotlintest.tables.headers
import io.kotlintest.tables.row
import io.kotlintest.tables.table

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
