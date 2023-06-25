using DailyNote.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Repositories
{
    public interface IDiaryRepository : IRepository<Diary, int>
    {
        Diary GetByRegisteredAt(string registeredAt);
    }
}
