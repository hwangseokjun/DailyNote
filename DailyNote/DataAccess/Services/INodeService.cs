using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Services
{
    public interface INodeService
    {
        void Add();
        void RemoveById(int id);
        void Modify();
    }
}
