import io.kotest.core.spec.style.BehaviorSpec
import io.kotest.matchers.shouldBe

class ThingBehaviorSpec : BehaviorSpec() { init {

    given("a thing") {
        val thing = Thing()

        `when`("call for action") {
            val value = thing.callForAction()

            then("result should be dog") {
                value shouldBe "Food"
            }
        }

        `when`("call for action with bone") {
            val value = thing.callForAction("bone")

            then("result should be: Dog eats bone.") {
                value shouldBe "Dog eats fish."
            }
        }
    }
}}
