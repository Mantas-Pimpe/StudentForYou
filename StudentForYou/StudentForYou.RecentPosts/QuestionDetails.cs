using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace StudentForYou.RecentPosts
{
    public struct QuestionDetails : IComparable<QuestionDetails>
    {
        public int CompareTo(QuestionDetails other)
        {
            if (this.Question == other.Question)
            {
                return this.QuestionViews.CompareTo(other.QuestionViews);
            }
            return other.Question.CompareTo(this.Question);
        }
        public class SortAnswersAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xAnswers = Int32.Parse(x.QuestionAnswers);
                var yAnswers = Int32.Parse(y.QuestionAnswers);
                if (xAnswers > yAnswers)
                {
                    return 1;
                }
                else if (xAnswers < yAnswers)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class SortAnswersDescending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xAnswers = Int32.Parse(x.QuestionAnswers);
                var yAnswers = Int32.Parse(y.QuestionAnswers);
                if (xAnswers < yAnswers)
                {
                    return 1;
                }
                else if (xAnswers > yAnswers)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class SortLikesAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xLikes = Int32.Parse(x.QuestionLikes);
                var yLikes = Int32.Parse(y.QuestionLikes);
                if (xLikes > yLikes)
                {
                    return 1;
                }
                else if (xLikes < yLikes)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class SortLikesDescending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xLikes = Int32.Parse(x.QuestionLikes);
                var yLikes = Int32.Parse(y.QuestionLikes);
                if (xLikes < yLikes)
                {
                    return 1;
                }
                else if (xLikes > yLikes)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public class SortViewAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xViews = Int32.Parse(x.QuestionViews);
                var yViews = Int32.Parse(y.QuestionViews);
                if (xViews > yViews)
                {
                    return 1;
                }
                else if (xViews < yViews)
                {
                    return -1;
                }
                else return 0;
            }
        }

        public class SortViewDescending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xViews = Int32.Parse(x.QuestionViews);
                var yViews = Int32.Parse(y.QuestionViews);
                if (xViews < yViews)
                {
                    return 1;
                }
                else if (xViews > yViews)
                {
                    return -1;
                }
                else return 0;
            }
        }

        public string QuestionLikes;
        public string QuestionViews;
        public string QuestionAnswers;
        public string Question;
        public string AnswersForQuestion;
        public DateTime CurrentDate;

        public QuestionDetails(string questionLikes, string questionViews, string questionAnswers, string question, string answerForQuestion, DateTime currentDate)
        {
            QuestionLikes = questionLikes;
            QuestionViews = questionViews;
            QuestionAnswers = questionAnswers;
            Question = question;
            AnswersForQuestion = answerForQuestion;
            CurrentDate = currentDate;
        }


        public List<QuestionDetails> getQuestionDetails()
        {
            string likes, views, answers, question;
            DateTime currentDate;
            List<QuestionDetails> questionList = new List<QuestionDetails>();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentQuestions.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split('`');
                likes = line[0];
                views = line[1];
                answers = line[2];
                question = line[3];
                currentDate = Convert.ToDateTime(line[5]);
                questionList.Add(new QuestionDetails(likes, views, answers, question, line[4], currentDate));
            }
            questionList.Sort();
            return questionList;
        }
        public void AddAnswers(List<QuestionDetails> questionList, int placeToReplace, string newAnswer, ref string answerCount)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.QuestionAnswers);
            count++;
            temp.QuestionAnswers = count.ToString();
            temp.AnswersForQuestion += "^" + newAnswer;
            questionList[placeToReplace] = temp;
            var answers = count.ToString();
            answerCount = answers;
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[2] = answers;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "^" + newAnswer + "`" + line[5];
            Console.WriteLine(newLine);
            lines[placeToReplace] = newLine;
            var writeText = new StreamWriter(@"..\Debug\Resources\recentquestions.txt");

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
        public void AddLike(List<QuestionDetails> questionList, int placeToReplace, ref string newLikes)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.QuestionLikes);
            count++;
            temp.QuestionLikes = count.ToString();
            questionList[placeToReplace] = temp;
            var likes = count.ToString();
            newLikes = likes;
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[0] = likes;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "`" + line[5];
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

        public void AddViews(List<QuestionDetails> questionList, int placeToReplace)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.QuestionViews);
            count++;
            temp.QuestionViews = count.ToString();
            questionList[placeToReplace] = temp;
            var views = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[1] = views;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "`" + line[5];
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

        public enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };

        public void AddDislike(List<QuestionDetails> questionList, int placeToReplace, ref string newLikes)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.QuestionLikes);
            count--;
            temp.QuestionLikes = count.ToString();
            questionList[placeToReplace] = temp;
            var likes = count.ToString();
            newLikes = likes;
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[0] = likes;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "`" + line[5];
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

        public List<QuestionDetails> SearchQuestion (List<QuestionDetails> questionList, string questionKey)
        {
            List<QuestionDetails> tempList = new List<QuestionDetails>(); 
            foreach (var s in questionList)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(s.Question, questionKey, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    tempList.Add(s);
                }
            }
            return tempList;
        }

    }
}