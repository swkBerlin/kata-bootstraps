import fit.*;

public class LeapYear extends ColumnFixture {
	public int year;

	public void setYear(int year) {
		this.year = year;
	}

	public boolean isLeap() {
		return new LeapYearCalculator().isLeap(year);
	}
}
