using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Models
{
    [Table("tree_paths")]
    public class TreePath
    {
        public int Ancestor { get; set; }
        public int Descendant { get; set; }
        public int Depth { get; set; }
    }
}
