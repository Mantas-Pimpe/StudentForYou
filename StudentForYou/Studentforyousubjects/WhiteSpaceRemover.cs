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
      var cleanedText = Regex.Replace(notCleanText, "\\s+", " ");
            return cleanedText;
        }
        

    }
}
