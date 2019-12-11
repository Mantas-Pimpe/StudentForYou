using System.Collections.Generic;
using System.Data.Entity;

namespace StudentForYou.DB
{
    public class EntityFrameworkDB<T> : IEntityFrameworkDB<T> where T : class
    {
        private StudentForYouEntities db;
        private IDbSet<T> dbEntity;

        public EntityFrameworkDB()
        {
            db = new StudentForYouEntities();
            dbEntity = db.Set<T>();
        }

        public IEnumerable<T> GetModelList()
        {
            return dbEntity;
        }

        public T GetModelByID(int id)
        {
            return dbEntity.Find(id);
        }

        public void InsertModel(T model)
        {
            dbEntity.Add(model);
        }

        public void DeleteModel(int id)
        {
            T model = dbEntity.Find(id);
            dbEntity.Remove(model);
        }

        public void UpdateModel(T model)
        {
            db.Entry(model).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
