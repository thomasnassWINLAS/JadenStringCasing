namespace JadenStringCasing;

public class Class1
{
    public static string ToJadenCase(string phrase)
    {
        return phrase[0].ToString().ToUpper() + phrase.Substring(1);
    }
}
