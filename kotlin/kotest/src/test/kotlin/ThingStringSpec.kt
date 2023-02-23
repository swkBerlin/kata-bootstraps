import io.kotest.core.spec.style.StringSpec
import io.kotest.data.forAll
import io.kotest.data.headers
import io.kotest.data.row
import io.kotest.data.table
import io.kotest.matchers.shouldBe

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
            row    ("bone",      "Dog eats bone.")
        )
        forAll(testTable) { food, result ->
            thing.callForAction(food) shouldBe result
        }
    }

}}
