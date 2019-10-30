using System.IO;

namespace Studentforyousubjects
{
    public class DescriptionReader
    {
        string filePath;
        string reviewsFilePath;
        public DescriptionReader(string courseName)
        {
            filePath = "Resources\\";
            reviewsFilePath = filePath + courseName + " " + "reviews.txt";
            filePath = filePath + courseName;
            filePath = filePath + ".txt";

        }


        public string ReadDescription()
        {
            if (File.Exists(filePath).Equals(false))
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
        public void UploadToFile(string textToUpload)
        {
            File.WriteAllText(filePath, textToUpload);
        }

        public void UploadReviews(string textToUpload)
        {
            File.AppendAllText(reviewsFilePath, textToUpload);
        }
    }
}
