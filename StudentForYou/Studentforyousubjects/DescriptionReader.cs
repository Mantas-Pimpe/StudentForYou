using System.IO;

namespace Studentforyousubjects
{
    public class DescriptionReader
    {
        string filePath;
        string reviewsFilePath;
       public DescriptionReader(string coursename)
        {
            filePath="Resources\\";
            reviewsFilePath = filePath + coursename + " " + "reviews.txt";
            filePath = filePath + coursename;
            filePath = filePath + ".txt";
            
        }


       public string ReadDescription()
        {
            if(File.Exists(filePath).Equals(false))
            {
               var myFile = File.Create(filePath);
                myFile.Close();

            }
            var text = File.ReadAllText(filePath);
            var whiteSpaceRemover = new StudentForYou.WhiteSpaceRemover();
            text = whiteSpaceRemover.RemoveMultipleWhiteSpaces(text);
            return text;

        }

        public string[] ReadReviews()
        {
            if (File.Exists(reviewsFilePath).Equals(false))
            {
                var myFile = File.Create(reviewsFilePath);
                myFile.Close();
            }
            var text = File.ReadAllLines(reviewsFilePath);
            var whiteSpaceRemover = new StudentForYou.WhiteSpaceRemover();
          //  text = whiteSpaceRemover.RemoveMultipleWhiteSpaces(text);
            return text;

        }
       public void UploadToFile(string texttoupload)
        {
            File.WriteAllText(filePath, texttoupload);
        }

        public void UploadReviews(string texttoupload)
        {
            File.AppendAllText(reviewsFilePath, texttoupload);
        }
    }
}
