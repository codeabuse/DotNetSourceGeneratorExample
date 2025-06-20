using generator;

namespace tests;

public class ToStringGenerator_Tests
{
    [Fact]
    public void Test1()
    {
        var p = new Person {
            Name = "John",
            Age = 30,
            Email = "john@example.com"
        };
        
        Assert.Equal(p.ToString(), "Generated ToString for Person");
    }
}
