using System;
using System.Collections.Generic;
using System.IO;

namespace StudentForYou.RecentPosts
{
    public struct QuestionDetails : IComparable<QuestionDetails>
    {
        public int CompareTo(QuestionDetails other)
        {
            if (this.question == other.question)
            {
                return this.questionViews.CompareTo(other.questionViews);
            }
            return other.question.CompareTo(this.question);
        }
        public class SortAnswersAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                var xAnswers = Int32.Parse(x.questionAnswers);
                var yAnswers = Int32.Parse(y.questionAnswers);
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
                var xAnswers = Int32.Parse(x.questionAnswers);
                var yAnswers = Int32.Parse(y.questionAnswers);
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
                var xLikes = Int32.Parse(x.questionLikes);
                var yLikes = Int32.Parse(y.questionLikes);
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
                var xLikes = Int32.Parse(x.questionLikes);
                var yLikes = Int32.Parse(y.questionLikes);
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
                var xViews = Int32.Parse(x.questionViews);
                var yViews = Int32.Parse(y.questionViews);
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
                var xViews = Int32.Parse(x.questionViews);
                var yViews = Int32.Parse(y.questionViews);
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
        public string questionLikes;
        public string questionViews;
        public string questionAnswers;
        public string question;
        public string answersForQuestion;
        public DateTime currentDate;

        public QuestionDetails(string questionLikes, string questionViews, string questionAnswers, string question, string answerForQuestion, DateTime currentDate)
        {
            this.questionLikes = questionLikes;
            this.questionViews = questionViews;
            this.questionAnswers = questionAnswers;
            this.question = question;
            this.answersForQuestion = answerForQuestion;
            this.currentDate = currentDate;
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
            //questionList.Sort();
            return questionList;
        }
        public void AddAnswers(List<QuestionDetails> questionList, ref int placeToReplace, string newAnswer, ref string answerCount)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.questionAnswers);
            count++;
            temp.questionAnswers = count.ToString();
            temp.answersForQuestion += "^" + newAnswer;
            questionList[placeToReplace] = temp;
            var answers = count.ToString();
            answerCount = answers;
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[2] = answers;
            var newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "^" + newAnswer + "`" + line[5];
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
        public void AddLike(List<QuestionDetails> questionList, ref int placeToReplace, ref string newLikes)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.questionLikes);
            count++;
            temp.questionLikes = count.ToString();
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

        public void AddViews(List<QuestionDetails> questionList, ref int placeToReplace)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.questionViews);
            count++;
            temp.questionViews = count.ToString();
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

        public void AddDislike(List<QuestionDetails> questionList, ref int placeToReplace, ref string newLikes)
        {
            QuestionDetails temp = questionList[placeToReplace];
            var count = Int32.Parse(temp.questionLikes);
            count--;
            temp.questionLikes = count.ToString();
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

        public List<QuestionDetails> SearchQuestion(List<QuestionDetails> questionList, string questionKey)
        {
            List<QuestionDetails> tempList = new List<QuestionDetails>();
            foreach (var s in questionList)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(s.question, questionKey, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    tempList.Add(s);
                }
            }
            return tempList;
        }

    }
}