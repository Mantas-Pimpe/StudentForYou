using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

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

        public int questionID;
        public string questionLikes;
        public string questionViews;
        public string questionAnswers;
        public string question;
        public string answersForQuestion;
        public DateTime currentDate;

        public QuestionDetails(int questionID, string questionLikes, string questionViews, string questionAnswers, string question, string answerForQuestion, DateTime currentDate)
        {
            this.questionID = questionID;
            this.questionLikes = questionLikes;
            this.questionViews = questionViews;
            this.questionAnswers = questionAnswers;
            this.question = question;
            this.answersForQuestion = answerForQuestion;
            this.currentDate = currentDate;
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

        public List<QuestionDetails> SearchQuestion(List<QuestionDetails> questionList, string questionKey)
        {
            List<QuestionDetails> tempList = new List<QuestionDetails>();
            foreach (var s in questionList)
            {
                if (Regex.IsMatch(s.question, questionKey, RegexOptions.IgnoreCase))
                {
                    tempList.Add(s);
                }
            }
            return tempList;
        }

    }

}