package features;

import io.cucumber.java.en.*;

import static java.time.Year.*;
import static org.junit.jupiter.api.Assertions.*;

public class LeapYearStepdefs {

	private Integer year;

	@Given("the year {int}")
	public void the_year(Integer year) {
		this.year = year;
	}

	@When("I check for leap year")
	public void i_check_for_leap_year() {
	}

	@Then("the check result is {word}")
	public void the_result_is_no(String isLeap) {
		if (isLeap.equals("no")) {
			assertFalse(isLeap(year));
		} else {
			assertTrue(isLeap(year));
		}
	}


}
