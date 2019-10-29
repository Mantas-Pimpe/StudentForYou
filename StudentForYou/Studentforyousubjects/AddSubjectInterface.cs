using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public interface IAddSubjectInterface
    {
        string ReturnAllInfo();
        void WriteToFile();
        void GetInfo(string nameInfo, string courseInfo, string difficultyInfo);
        
    }
}
