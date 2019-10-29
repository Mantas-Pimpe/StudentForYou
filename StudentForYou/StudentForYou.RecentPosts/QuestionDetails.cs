using System;
using System.IO;
using System.Collections.Generic;

namespace StudentForYou.RecentPosts
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

        public QuestionDetails(string QuestionLikes, string QuestionViews, string QuestionAnswers, string Question, string answerForQuestion)
        {
            this.QuestionLikes = QuestionLikes;
            this.QuestionViews = QuestionViews;
            this.QuestionAnswers = QuestionAnswers;
            this.Question = Question;
            this.AnswersForQuestion = answerForQuestion;
        }

        public List<QuestionDetails> getQuestionDetails()
        {
            string likes, views, answers, Question;
            List<QuestionDetails> QuestionList = new List<QuestionDetails>();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentQuestions.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split('`');
                likes = line[0];
                views = line[1];
                answers = line[2];
                Question = line[3];
                QuestionList.Add(new QuestionDetails(likes, views, answers, Question, line[4]));
            }
            return QuestionList;
        }
        public void AddAnswers(List<QuestionDetails> QuestionList, int placeToReplace, string newAnswer)
        {
            int count = Int32.Parse(QuestionList[placeToReplace].QuestionAnswers);
            count++;
            QuestionList[placeToReplace].QuestionAnswers = count.ToString();
            QuestionList[placeToReplace].AnswersForQuestion += "^" + newAnswer;
            var answers = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentQuestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[2] = answers;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "^" + newAnswer;
            lines[placeToReplace] = newLine;
            var writeText = new StreamWriter(@"..\Debug\Resources\recentQuestions.txt");

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
        public void AddLike(List<QuestionDetails> QuestionList, int placeToReplace)
        {
            int count = Int32.Parse(QuestionList[placeToReplace].QuestionLikes);
            count++;
            QuestionList[placeToReplace].QuestionLikes = count.ToString();
            var likes = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentQuestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[0] = likes;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
            lines[placeToReplace] = newLine;
            var writeText = new StreamWriter(@"..\Debug\Resources\recentQuestions.txt");

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

        public void AddViews(List<QuestionDetails> QuestionList, int placeToReplace)
        {
            int count = Int32.Parse(QuestionList[placeToReplace].QuestionViews);
            count++;
            QuestionList[placeToReplace].QuestionViews = count.ToString();
            var views = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentQuestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[1] = views;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
            lines[placeToReplace] = newLine;
            var writeText = new StreamWriter(@"..\Debug\Resources\recentQuestions.txt");

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
