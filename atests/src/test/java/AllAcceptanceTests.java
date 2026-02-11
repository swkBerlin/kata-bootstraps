import fitnesse.junit.*;
import fitnesse.junit.FitNesseRunner.*;
import org.junit.runner.*;

@RunWith(FitNesseRunner.class)
@FitNesseRunner.Suite("MyApp")
@FitnesseDir("./fitnesse")
@OutputDir("./fitnesse/results/")
public class AllAcceptanceTests {

}
