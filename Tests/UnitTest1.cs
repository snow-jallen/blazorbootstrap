using BlazorWeb;
using FluentAssertions;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var actual = GpaCalculator.Calculate([new Course("C1", 4, 3), new Course("C2", 3.5M, 1)]);
        actual.Should().Be(((4 * 3) + (3.5M * 1)) / 4);
    }
}