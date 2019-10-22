using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForYou
{
    public class QuestionDetails
    {
        public string QuestionLikes;
        public string QuestionViews;
        public string QuestionAnswers;
        public string Question;
        public string AnswersForQuestion;
        
        public QuestionDetails()
        {

        }

        public QuestionDetails(string questionLikes, string questionViews, string questionAnswers, string question, string answerForQuestion)
        {
            QuestionLikes = questionLikes;
            QuestionViews = questionViews;
            QuestionAnswers = questionAnswers;
            Question = question;
            AnswersForQuestion = answerForQuestion;
        }

        public List<QuestionDetails> getQuestionDetails()
        {
            string likes, views, answers, question;
            List<QuestionDetails> questionList = new List<QuestionDetails>();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split('`');
                likes = line[0];
                views = line[1];
                answers = line[2];
                question = line[3];
                questionList.Add(new QuestionDetails(likes, views, answers, question, line[4]));
            }
            return questionList;
        }
        public void AddAnswers(List<QuestionDetails> questionList, int placeToReplace, string newAnswer)
        {
            int count = Int32.Parse(questionList[placeToReplace].QuestionAnswers);
            count++;
            questionList[placeToReplace].QuestionAnswers = count.ToString();
            questionList[placeToReplace].AnswersForQuestion += "^" + newAnswer;
            String answers = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[2] = answers;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "^" + newAnswer;
            lines[placeToReplace] = newLine;
            StreamWriter writeText = new StreamWriter(@"..\Debug\Resources\recentquestions.txt");

            for (int currentLine = 0; currentLine < lines.Length; ++currentLine)
            {
                if (currentLine == placeToReplace)
                {
                    writeText.WriteLine(lines[placeToReplace]);
                }
                else
                {
                    writeText.WriteLine(lines[currentLine]);
                }
            }
            writeText.Close();
        }
        public void AddLike (List<QuestionDetails> questionList, int placeToReplace)
        {
            int count = Int32.Parse(questionList[placeToReplace].QuestionLikes);
            count++;
            questionList[placeToReplace].QuestionLikes = count.ToString();
            String likes = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[0] = likes;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
            lines[placeToReplace] = newLine;
            StreamWriter writeText = new StreamWriter(@"..\Debug\Resources\recentquestions.txt");

            for (int currentLine = 0; currentLine < lines.Length; ++currentLine)
            {
                if (currentLine == placeToReplace)
                {
                    writeText.WriteLine(lines[placeToReplace]);
                }
                else
                {
                    writeText.WriteLine(lines[currentLine]);
                }
            }
            writeText.Close();
        }

        public void AddViews (List<QuestionDetails> questionList, int placeToReplace)
        {
            int count = Int32.Parse(questionList[placeToReplace].QuestionViews);
            count++;
            questionList[placeToReplace].QuestionViews = count.ToString();
            String views = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[1] = views;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
            lines[placeToReplace] = newLine;
            StreamWriter writeText = new StreamWriter(@"..\Debug\Resources\recentquestions.txt");

            for (int currentLine = 0; currentLine < lines.Length; ++currentLine)
            {
                if (currentLine == placeToReplace)
                {
                    writeText.WriteLine(lines[placeToReplace]);
                }
                else
                {
                    writeText.WriteLine(lines[currentLine]);
                }
            }
            writeText.Close();
        }
    }
}
