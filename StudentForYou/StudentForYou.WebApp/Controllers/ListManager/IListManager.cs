using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Controllers
{
   public interface IListManager<T>
    {
      public  List<T> GetList();
      
    }
}
