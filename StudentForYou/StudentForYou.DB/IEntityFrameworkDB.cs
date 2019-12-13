using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.DB
{
    public interface IEntityFrameworkDB<T> where T : class
    {
        //IEnumerable<T> GetModelList();
        //T GetModelByID(int id);
        //void InsertModel(T model);
        //void DeleteModel(int id);
        //void UpdateModel(T model);
        //void Save();
        IEnumerable<T> GetModelList();

        T GetModelByID(int id);

        void InsertModel(T entity);

        void UpdateModel(T entity);

        void DeleteModel(int id);
    }
}
