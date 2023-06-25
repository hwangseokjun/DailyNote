﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public bool IsFavored { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
