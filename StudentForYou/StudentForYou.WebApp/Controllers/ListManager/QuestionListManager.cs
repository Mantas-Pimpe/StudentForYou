using StudentForYou.DB;
using StudentForYou.WebApp.Models;
using System.Collections.Generic;

namespace StudentForYou.WebApp.Controllers
{
 
    public class QuestionListManager : IListManager<Question>
    {
        
        DataTableDB db;
        public QuestionListManager()
        {
         db = new DataTableDB();
        }
        public List<Question> GetList()
         {

        var query = "select qns.qns_id QuestionID, qns.qns_likes QuestionLikes, qns.qns_views QuestionViews, qns.qns_comments QuestionAnswers, qns.qns_text QuestionText, qns.qns_name QuestionName, qns.qns_creation_date QuestionCreationDate from questions qns";
        var list = db.GetList<Question>(query);
 
            return list;
            
            }
}
}
  
    
