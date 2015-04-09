
import org.junit.Test;

import static com.google.common.truth.Truth.assertThat;

public class ThingTest {

    @Test
    public void it_should_call_for_action() {
        Thing thing = new Thing();
        String value = thing.callForAction();
        assertThat(value).isEqualTo("Food");
    }
}
