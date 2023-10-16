using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class TemporarySchedule
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public DateTime TempDate { get; set; }= DateTime.Now;
        public long? TimetableId { get; set; } = 0;

        public string TimetableType { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
