using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class FixShiftDay
    {
        public int Id { get; set; }
        public long? FixShiftId { get; set; } = 0;
        public TimeSpan StartTime { get; set; } = TimeSpan.Zero;
        public TimeSpan EndTime { get; set; }= TimeSpan.Zero;
        public string Days { get; set; } = "";
        public long? RestDayCheck { get; set; } = 0;
        public long? FixTimetableId { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
