using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.DataAccess.Models
{
    [Table("diaries")]
    public class Diary
    {
        [Key]
        public int Id { get; set; }
        public string Contents { get; set; }
        public string RegisteredAt { get; set; }
        public string CreatedAt { get; set; }
        public string ModifiedAt { get; set; }
        public int IsFavored { get; set; }
        public string CategoryCode { get; set; }
    }
}
