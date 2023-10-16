using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserLeave
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public long? LeaveClassId { get; set; } = 0;
        public string? LeaveClassName { get; set; } = "";
        public string Reason { get; set; } = "";
        public string PaidUnpaid { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public long? CatagoryId { get; set; } = 0;
        public string? CatagoryName { get; set; } = "";
        public string LeaveUnit { get; set; } = "";
        public string HourForm { get; set; } = "";
        public string HourTo { get; set; } = "";
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
