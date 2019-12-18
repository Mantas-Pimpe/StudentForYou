using StudentForYou.DB;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentForYou
{
    public class WhiteSpaceRemover
    {
        public Tuple<string, string> CleanCourseBeforePost(string name, string description)
        {
            var a = RemoveMultipleWhiteSpaces(name);
            var b = RemoveMultipleWhiteSpaces(description);
            return Tuple.Create(a, b);
        }
        public string CleanReviewBeforePost(string review)
        {
            var a = RemoveMultipleWhiteSpaces(review);
            return a;
        }
        public string RemoveMultipleWhiteSpaces(string notCleanText)
        {
            var cleanedText = Regex.Replace(notCleanText, "\\s+", " ");
            return cleanedText;
        }
    }
}
