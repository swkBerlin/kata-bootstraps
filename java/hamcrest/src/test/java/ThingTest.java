import org.hamcrest.*;
import org.junit.jupiter.api.Test;

import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.equalTo;
import static org.hamcrest.Matchers.is;

public class ThingTest {

    @Test
    void it_should_call_for_action() {
        Thing thing = new Thing();
        String value = thing.callForAction();
        assertThat(value, is(equalTo("Food")));
    }

    @Test
    void it_should_not_fail() {
        assertThat(true, is(true));
    }
}
