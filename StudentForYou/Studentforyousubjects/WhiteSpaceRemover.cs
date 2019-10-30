using System.Text.RegularExpressions;

namespace StudentForYou
{
    class WhiteSpaceRemover
    {
        public string RemoveMultipleWhiteSpaces(string notCleanText)
        {
            var cleanedText = Regex.Replace(notCleanText, "\\s+", " ");
            return cleanedText;
        }


    }
}
