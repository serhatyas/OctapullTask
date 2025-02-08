using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctapullTask.Repositroy.Entities
{
    public class Meeting
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DocumentPath { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
