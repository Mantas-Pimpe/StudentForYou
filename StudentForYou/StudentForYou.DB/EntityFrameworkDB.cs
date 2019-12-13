using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.DB
{
    public class EntityFrameworkDB<T> : IEntityFrameworkDB<T> where T : class
    {
        private StudentForYouEntities db;

        public EntityFrameworkDB(StudentForYouEntities context)
        {
            db = context;
        }

        public IEnumerable<T> GetModelList()
        {
            return db.Set<T>().AsNoTracking();
        }
        
        public T GetModelByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void InsertModel(T model)
        {
            db.Set<T>().Add(model);
        }

        public void DeleteModel(int id)
        {
            var entity = GetModelByID(id);
            db.Set<T>().Remove(entity);
        }

        public void UpdateModel(T model)
        {
            db.Set<T>().Update(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
