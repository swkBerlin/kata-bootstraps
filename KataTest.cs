using NUnit.Framework;

public class KataTest
{

    [Test]
    public void Passing()
    {
        Assert.Pass();
    }

    [Test]
    [Category("Failing")]
    public void Life_the_Universe_and_Everything()
    {
        Assert.That(Kata.Answer(), Is.EqualTo(42));
    }
}
