using System.Collections.Generic;
/*
 * This file would be used if we converted to use the Entity Framework
 */
namespace StudentForYou.DB
{
    public interface IEntityFrameworkDB<T> where T : class
    {
        IEnumerable<T> GetModelList();

        T GetModelByID(int id);

        void InsertModel(T entity);

        void UpdateModel(T entity);

        void DeleteModel(int id);

        void Save();
    }
}
