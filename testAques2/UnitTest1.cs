using Aques2;
using Xunit;


namespace testAques2;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[]{3,2},3,6)]
    [InlineData(new int[] {3,5,6,2 },5,20)]
    public void TestGetMaximumPoints(int[] days, int k, int expectedResult)
    {
        //Act
        Aquestion item = new Aquestion();

        //Assert
        int result = item.GetMaximumPoints(days, k);

        Assert.Equal(expectedResult, result);
    }
}
