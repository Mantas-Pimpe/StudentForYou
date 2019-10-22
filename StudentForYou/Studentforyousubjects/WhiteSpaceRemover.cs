using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentForYou
{
    class WhiteSpaceRemover
    {
       public string RemoveMultipleWhiteSpaces(string notCleanText )
        {
        var cleanedString = Regex.Replace(badString, "\\s+", " ");
            return cleanedString;
        }
        

    }
}
