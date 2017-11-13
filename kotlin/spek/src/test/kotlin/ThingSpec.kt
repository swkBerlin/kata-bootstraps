import org.amshove.kluent.*
import org.jetbrains.spek.api.Spek
import org.jetbrains.spek.api.dsl.describe
import org.jetbrains.spek.api.dsl.it
import org.jetbrains.spek.api.dsl.on

class ThingSpec: Spek({
    describe("a thing") {
        val thing = Thing()

        on("call for action") {
            val value = thing.callForAction()

            it("should return dog") {
                value `should equal` "Food"
            }
        }

        on("call for action with bone") {
            val value = thing.callForAction("bone")

            it("should return bone") {
                value `should equal` "fish"
            }
        }
    }
})
