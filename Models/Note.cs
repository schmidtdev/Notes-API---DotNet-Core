using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_API.Models
{
    public class Note
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedAt { get; set; }
        public string DeadLine { get; set; }
        public bool IsComplete { get; set; }
        public int UserID { get; set; }
    }
}
