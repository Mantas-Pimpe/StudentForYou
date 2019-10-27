using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace StudentForYou.RecentPosts
{
    public struct QuestionDetails: IComparable<QuestionDetails>
    {
        class SortAnswersAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                int xAnswers = Int32.Parse(x.QuestionAnswers);
                int yAnswers = Int32.Parse(y.QuestionAnswers);
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

        class SortAnswersDescending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                int xAnswers = Int32.Parse(x.QuestionAnswers);
                int yAnswers = Int32.Parse(y.QuestionAnswers);
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

        class SortLikesAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                int xLikes = Int32.Parse(x.QuestionLikes);
                int yLikes = Int32.Parse(y.QuestionLikes);
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

        class SortLikesDescending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                int xLikes = Int32.Parse(x.QuestionLikes);
                int yLikes = Int32.Parse(y.QuestionLikes);
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

        class SortViewAscending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                int xViews = Int32.Parse(x.QuestionViews);
                int yViews = Int32.Parse(y.QuestionViews);
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

        class SortViewDescending : IComparer<QuestionDetails>
        {
            public int Compare(QuestionDetails x, QuestionDetails y)
            {
                int xViews = Int32.Parse(x.QuestionViews);
                int yViews = Int32.Parse(y.QuestionViews);
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
        private class sortViewAscendingHelper: IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                QuestionDetails q1 = (QuestionDetails)x;
                QuestionDetails q2 = (QuestionDetails)y;
                int q1Views = Int32.Parse(q1.QuestionViews);
                int q2Views = Int32.Parse(q2.QuestionViews);
                if (q1Views > q2Views)
                {
                    return 1;
                }
                if (q1Views < q2Views)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private class sortViewDescendingHelper: IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                QuestionDetails q1 = (QuestionDetails)x;
                QuestionDetails q2 = (QuestionDetails)y;
                int q1Views = Int32.Parse(q1.QuestionViews);
                int q2Views = Int32.Parse(q2.QuestionViews);
                if (q1Views < q2Views)
                {
                    return 1;
                }
                if (q1Views > q2Views)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string QuestionLikes;
        public string QuestionViews;
        public string QuestionAnswers;
        public string Question;
        public string AnswersForQuestion;
        public DateTime CurrentDate;

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
            string likes, views, answers, Question;
            List<QuestionDetails> QuestionList = new List<QuestionDetails>();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentQuestions.txt");
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
            int count = Int32.Parse(QuestionList[placeToReplace].QuestionAnswers);
            count++;
            questionList[placeToReplace].QuestionAnswers = count.ToString();
            questionList[placeToReplace].AnswersForQuestion += "^" + newAnswer;
            String answers = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[2] = answers;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4] + "^" + newAnswer + "`" + line[5];
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
            questionList[placeToReplace].QuestionLikes = count.ToString();
            String likes = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[0] = likes;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
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
            questionList[placeToReplace].QuestionViews = count.ToString();
            String views = count.ToString();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            line[1] = views;
            string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
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

    }
}