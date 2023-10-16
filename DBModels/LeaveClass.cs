using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class LeaveClass
    {
        public int Id { get; set; }
        public string LeaveName { get; set; } = "";
        public string Duration { get; set; } = "";
        public string Code { get; set; } = "";
        public long? LeaveCatagoryId { get; set; } = 0;
        public string LeaveCatagoryName { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
