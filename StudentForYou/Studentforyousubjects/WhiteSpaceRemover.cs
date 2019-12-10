using StudentForYou.DB;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentForYou
{
    public class WhiteSpaceRemover
    {
        public async static Task<Tuple<string, string>> CleanCourseBeforePost(string name, string description)
        {
            var a = await RemoveMultipleWhiteSpaces(name);
            var b = await RemoveMultipleWhiteSpaces(description);
            return Tuple.Create(a, b);
        }
        public async static Task<string> CleanReviewBeforePost(string review)
        {
            var a = await Task.Run(() => RemoveMultipleWhiteSpaces(review));
            return a;
        }
        public async static Task<string> RemoveMultipleWhiteSpaces(string notCleanText)
        {
            var cleanedText = Regex.Replace(notCleanText, "\\s+", " ");
            return cleanedText;
        }
    }
}
