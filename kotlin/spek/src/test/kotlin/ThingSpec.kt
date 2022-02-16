import org.junit.jupiter.api.Assertions.assertEquals
import org.spekframework.spek2.Spek
import org.spekframework.spek2.style.gherkin.Feature

class ThingSpec: Spek({
    Feature("a thing") {
        val thing by memoized { Thing() }

        Scenario("call for action") {
            lateinit var value: String

            When("calling for action") {
                value = thing.callForAction()
            }

            Then("should return dog") {
                assertEquals("Food", value)
            }
        }

        Scenario("call for action with bone") {

            lateinit var value: String

            When("calling for action with bone") {
                value = thing.callForAction("bone")
            }

            Then("should return bone") {
                assertEquals("fish", value)
            }
        }
    }
})
