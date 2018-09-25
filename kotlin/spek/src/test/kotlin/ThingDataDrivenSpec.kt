import org.amshove.kluent.`should equal`
import org.jetbrains.spek.api.Spek
import org.jetbrains.spek.api.dsl.given
import org.jetbrains.spek.api.dsl.it
import org.jetbrains.spek.data_driven.data
import org.jetbrains.spek.data_driven.on

class ThingDataDrivenSpec : Spek({

    given("a thing") {

        val thing = Thing()

        val testData = arrayOf(
                //         food          result
                //------|-----------|------------------------
                data("chocolate", "Dog eats chocolate."),
                data("bone",      "Dog eats fish.")
        )

        on("call for action %s", with = *testData) { food, expected ->
            val value = thing.callForAction(food)

            it("returns $expected") {
                value `should equal` expected
            }
        }
    }
})
