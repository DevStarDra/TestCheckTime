using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Autocount
    {
        public int Id { get; set; }
        public string BranchId { get; set; } = "0";
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public string Badgenumber { get; set; } = "";
        public long? UserId { get; set; } = 0;
        public string WorkingDays { get; set; } = "";
        public string Leave { get; set; } = "";
        public string Absent { get; set; } = "";
        public string Holiday { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string WorkingHours { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
