using System.Text.RegularExpressions;


namespace StudentForYou
{
    class WhiteSpaceRemover
    {
        string RemoveMultipleWhiteSpaces(string notCleanText )
        {
        var cleanedString = Regex.Replace(notCleanText, "\\s+", " ");
            return cleanedString;
        }
        

    }
}
