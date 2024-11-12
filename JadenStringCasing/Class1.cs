namespace JadenStringCasing;

public class Class1
{
    public static string ToJadenCase(string phrase)
    {
        var words = phrase.Split(' ');
        var result = "";
        foreach (var word in words)
        {
            result += word[0].ToString().ToUpper() + word.Substring(1) + " ";
        }

        return result.TrimEnd();
    }
}
