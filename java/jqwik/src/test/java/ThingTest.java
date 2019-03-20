import net.jqwik.api.Example;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ThingTest {

    @Example
    void it_should_call_for_action() {
        Thing thing = new Thing();
        String value = thing.callForAction();
        assertEquals("Food", value);
    }
}
