using System.Collections.Generic;

namespace StudentForYou.DB
{
    interface IEntityFrameworkDB<T> where T: class
    {
        IEnumerable<T> GetModelList();
        T GetModelByID(int id);
        void InsertModel(T model);
        void DeleteModel(int id);
        void UpdateModel(T model);
        void Save();
    }
}
