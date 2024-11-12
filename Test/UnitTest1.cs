using static JadenStringCasing.Class1;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "ToJadenCase should return a string")]
    public void ToJadenCase_ReturnsString()
    {
        Assert.Equal("hej", ToJadenCase("hej"));
    }
    
}