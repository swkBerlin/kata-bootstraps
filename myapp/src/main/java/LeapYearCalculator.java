public class LeapYearCalculator {

	public boolean isLeap(int year) {
		return java.time.Year.isLeap(year);
	}
}
