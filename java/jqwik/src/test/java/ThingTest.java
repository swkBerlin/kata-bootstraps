import net.jqwik.api.*;

public class ThingTest {

	@Example
	boolean it_should_call_for_action() {
		Thing thing = new Thing();
		String value = thing.callForAction();
		return value.equals("Food");
	}
}
