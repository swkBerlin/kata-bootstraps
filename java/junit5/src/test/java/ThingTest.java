import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;

public class ThingTest {

    @Test
    public void it_should_call_for_action() {
        Thing thing = new Thing();
        String value = thing.callForAction();
        assertEquals(value, "Food");
    }
}
