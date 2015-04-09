import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.runners.MockitoJUnitRunner;

import static org.hamcrest.CoreMatchers.equalTo;
import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.assertThat;
import static org.mockito.Mockito.never;
import static org.mockito.Mockito.verify;
import static org.mockito.Mockito.when;

@RunWith(MockitoJUnitRunner.class)
public class ThingTest {

    @Mock
    private AnotherThing anotherThing;

    private Thing thing;

    @Before
    public void setUp() throws Exception {
        thing = new Thing(anotherThing);
    }

    @Test
    public void it_not_should_use_another_things_data() {
        when(anotherThing.callForData()).thenReturn("Cat");
        String result = thing.callForAction();
        assertThat(result, is(equalTo("Food")));
    }

    @Test
    public void it_should_not_call_another_thing() {
        thing.callForAction();
        verify(anotherThing, never()).callForData();
    }
}