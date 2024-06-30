using NUnit.Framework;

namespace SumOfEvenNumbersTests;

public class SumOfEvenNumbersTests
{
    [Test]
    public void Test1()
    {
        var input = Enumerable.Empty<int>();
        var result = input.Calculate();
        Assert.AreEqual(0, result);
    }
}
