using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StudentForYou.RecentPosts
{
    public struct Question : IComparable<Question>
    {
        public int CompareTo(Question other)
        {
            if (this.questionText == other.questionText)
            {
                return this.questionViews.CompareTo(other.questionViews);
            }
            return other.questionText.CompareTo(this.questionText);
        }
        public class SortAnswersAscending : IComparer<Question>
        {
            public int Compare(Question x, Question y)
            {
                var xAnswers = x.questionAnswers;
                var yAnswers = y.questionAnswers;
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

        public class SortAnswersDescending : IComparer<Question>
        {
            public int Compare(Question x, Question y)
            {
                var xAnswers = x.questionAnswers;
                var yAnswers = y.questionAnswers;
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

        public class SortLikesAscending : IComparer<Question>
        {
            public int Compare(Question x, Question y)
            {
                var xLikes = x.questionLikes;
                var yLikes = y.questionLikes;
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

        public class SortLikesDescending : IComparer<Question>
        {
            public int Compare(Question x, Question y)
            {
                var xLikes = x.questionLikes;
                var yLikes = y.questionLikes;
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

        public class SortViewAscending : IComparer<Question>
        {
            public int Compare(Question x, Question y)
            {
                var xViews = x.questionViews;
                var yViews = y.questionViews;
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

        public class SortViewDescending : IComparer<Question>
        {
            public int Compare(Question x, Question y)
            {
                var xViews = x.questionViews;
                var yViews = y.questionViews;
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
        public int questionLikes;
        public int questionViews;
        public int questionAnswers;
        public string questionText;
        public string questionName;
        public DateTime questionCreationDate;

        public Question(int questionID, int questionLikes, int questionViews, int questionAnswers, string questionText, string questionName, DateTime questionCreationDate)
        {
            this.questionID = questionID;
            this.questionLikes = questionLikes;
            this.questionViews = questionViews;
            this.questionAnswers = questionAnswers;
            this.questionText = questionText;
            this.questionName = questionName;
            this.questionName = questionName;
            this.questionCreationDate = questionCreationDate;
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

        public List<Question> SearchQuestion(List<Question> questionList, string questionKey)
        {
            List<Question> tempList = new List<Question>();
            foreach (var s in questionList)
            {
                if (Regex.IsMatch(s.questionName, questionKey, RegexOptions.IgnoreCase))
                {
                    tempList.Add(s);
                }
            }
            return tempList;
        }

    }

}