using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Repositories
{
    public interface IRepository<T, ID> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(ID id);
        IEnumerable<T> GetAll();
        T GetById(ID id);
    }
}
