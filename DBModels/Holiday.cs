using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Holiday
    {
        public int Id { get; set; }
        public string HolidayName { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;
        public long? Duration { get; set; } = 0;
        public long? DeptId { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
