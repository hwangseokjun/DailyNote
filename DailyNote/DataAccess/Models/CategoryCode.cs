using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Models
{
    [Table("category_codes")]
    public class CategoryCode
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
