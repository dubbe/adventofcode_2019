using Xunit;

public class Tests
{
    [Fact]
    public void Calculate_1and2_Returns3()
    {

        Assert.Equal(5, Program.Calculate(1,2,3));

    }

    [Fact]
    public void Operate_example()
    {
        int[] input = {1,9,10,3,2,3,11,0,99,30,40,50};
        int[] expectedOutput = {3500,9,10,70,2,3,11,0,99,30,40,50};
        Assert.Equal(string.Join(",", expectedOutput), Program.Operate(input));

    }

    [Fact]
    public void Operate_example2()
    {
        int[] input = {1,1,1,4,99,5,6,0,99};
        int[] expectedOutput = {30,1,1,4,2,5,6,0,99};
        Assert.Equal(string.Join(",", expectedOutput), Program.Operate(input));

    }
}
