using consoleapp;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MyApp.test;

public class UnitTest1
{
    [Fact]
    public void IsLeapYear_Given_INT_Divisible_By_4_Return_True()
    {
       Assert.True(new LeapYear().IsLeapYear(4));
    }
}