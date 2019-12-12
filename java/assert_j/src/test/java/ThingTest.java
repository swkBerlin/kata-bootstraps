
import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.*;

public class ThingTest {

    @Test
    void it_should_call_for_action() {
        Thing thing = new Thing();
        String value = thing.callForAction();
        assertThat(value).isEqualTo("Food");
    }

    @Test
    void it_should_not_fail() {
        assertThat(true).isTrue();
    }
}
