import org.junit.jupiter.api.Assertions.assertEquals
import org.spekframework.spek2.Spek
import org.spekframework.spek2.style.gherkin.Feature

class ThingDataDrivenSpec : Spek({

    Feature("a thing") {

        val thing by memoized { Thing() }

        val testData = mapOf(
                //         food          result
                //------|-----------|------------------------
                Pair("chocolate", "Dog eats chocolate."),
                Pair("bone",      "Dog eats fish.")
        )
        testData.forEach { (food, expected) ->

            Scenario("call for action $food") {

                lateinit var value: String

                When("") {
                    value = thing.callForAction(food)
                }

                Then("returns $expected") {
                    assertEquals( expected, value)
                }
            }
        }
    }
})
