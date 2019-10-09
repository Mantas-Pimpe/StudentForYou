using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public class listviewinfosetter
    {
        List<string> items=new List<string>();

        public List<string> Readfileinfo()
        {
            
            List<string> data = System.IO.File.ReadAllLines(@"Resources\allcourses.txt").ToList();
            foreach (string d in data)
            {
                items.AddRange(d.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
            }
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
            return items;

        }
    }
}