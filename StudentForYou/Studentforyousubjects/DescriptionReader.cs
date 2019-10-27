using System.IO;

namespace Studentforyousubjects
{
    public class DescriptionReader
    {
        string filePath;
       public DescriptionReader(string coursename)
        {
            filePath="Resources\\";
            filePath = filePath + coursename;
            filePath = filePath + ".txt";
        }


       public string ReadDescription()
        {
            if(File.Exists(filePath).Equals(false))
            {
                File.Create(filePath);
            }
            var text = File.ReadAllText(filePath);
            var whiteSpaceRemover = new StudentForYou.WhiteSpaceRemover();
            text = whiteSpaceRemover.RemoveMultipleWhiteSpaces(text);
            return text;

        }
       public void UploadToFile(string texttoupload)
        {
            File.AppendAllText(filePath, texttoupload);
        }
    }
}
