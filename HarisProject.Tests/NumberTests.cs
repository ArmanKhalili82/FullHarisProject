using Xunit;
using HarisProject.Business;

namespace HarisProject.Tests;

public class NumberTests
{
    [Theory]
    [InlineData(956, "nohsad panjah shish")]
    [InlineData(34530, "si chahar hezar pansad si")]
    [InlineData(64324127, "shast chahar milion sisad bist chahar hezar sad bist haft")]
    [InlineData(11, "yazdah")]
    [InlineData(7385, "haft hezar sisad hashtad pang")]
    [InlineData(10000000, "dah milion")]
    [InlineData(25785212, "bist pang milion haftsad hashtad pang hezar dvist davazdah")]
    [InlineData(711, "haftsad yazdah")]

    public void TestOutput(int number, string output)
    {
        var p = new HarisNumber();

        var result = p.Convert(number);

        Assert.Equal(output, result);
    }
}