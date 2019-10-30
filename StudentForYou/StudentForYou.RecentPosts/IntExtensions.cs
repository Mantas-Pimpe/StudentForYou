
namespace StudentForYou.RecentPosts
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool IsLessThan(this int i, int value)
        {
            return i < value;
        }
    }
}
