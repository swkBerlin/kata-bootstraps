module kata;

version (unittest)
{
    import unit_threaded;
}
else
{
    private enum ShouldFail;
} // so production builds compile

@("Dummy test") unittest
{
    auto kata = new Kata();
    true.should == false;
}

/** 
 * A Kata
 */
class Kata
{

}
