using System.Collections.Generic;

namespace StudentForYou.WebApp.Controllers
{
   public interface IListManager<T>
    {
      public  List<T> GetList();
      
    }
}
