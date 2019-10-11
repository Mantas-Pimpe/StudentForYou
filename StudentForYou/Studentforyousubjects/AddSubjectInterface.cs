using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public interface AddSubjectInterface
    {
        string returnallinfo();

        void writetofile();
         void getinfo(string nameinfo, string courseinfo, string difficultyinfo);
        


    }
}
