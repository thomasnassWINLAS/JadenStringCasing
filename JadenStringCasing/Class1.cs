namespace JadenStringCasing;

public class Class1
{
    public static string ToJadenCase(string phrase)
    {
        var words = phrase.Split(' ').Select(CapitalizeWord);
        return string.Join(" ", words);
    }

    private static string CapitalizeWord(string word)
    {
        return word[0].ToString().ToUpper() + word.Substring(1);
    }
}
