using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class CheckList
    {
        public static List<T> ReplaceList<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j != i)
                    {
                        if (list[i].Equals(list[j]))
                        {
                            list.Remove(list[j]);
                        }
                    }
                }
            }
            return list;
        }
    }
}
