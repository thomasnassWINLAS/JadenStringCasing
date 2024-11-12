using static JadenStringCasing.Class1;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "ToJadenCase should capitalize first letter")]
    public void ToJadenCase_CapitalizesFirstLetter()
    {
        Assert.Equal("Hej", ToJadenCase("hej"));
    }
    
    [Fact(DisplayName = "ToJadenCase should capitalize first letter of multiple words")]
    public void ToJadenCase_CapitalizesFirstOfMultipleWords()
    {
        Assert.Equal("Hej Där", ToJadenCase("hej där"));
    }
}