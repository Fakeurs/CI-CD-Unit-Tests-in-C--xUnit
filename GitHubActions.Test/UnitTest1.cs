namespace GitHubActions.Test;
using GitHubActions;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 3,5)]
    [InlineData(5, 7,12)]
    [InlineData(2, 0,20)]
    public void Sum_Of_Two_Numbers(int num1, int num2, int sum)
    {
        // Act
        var result = Program.Add(num1, num2);
        
        // Assert
        Assert.Equal(sum,result); // Expected, Actual
    }
}