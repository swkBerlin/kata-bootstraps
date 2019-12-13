import static org.junit.Assert.*;
import org.junit.Test;

public class ThingTest {

    @Test
    public void it_should_call_for_action() {
        Thing thing = new Thing();
        String value = thing.callForAction();
        assertEquals("Food", value);
    }

    @Test
    public void it_should_not_fail() {
        assertTrue(true);
    }
}
