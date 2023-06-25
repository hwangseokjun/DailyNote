using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Values
{
    public struct NodePathKey
    {
        public int Ancestor { get; set; }
        public int Descendant { get; set; }
    }
}
