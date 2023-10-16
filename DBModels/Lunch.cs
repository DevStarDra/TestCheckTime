using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Lunch
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public long? TotalLeave { get; set; } = 0;
        public long? Days { get; set; } = 0;
        public long? RestTime { get; set; } = 0;
        public string StartTime { get; set; } = "";
        public string EndTime { get; set; } = "";
        public long? Minute { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
