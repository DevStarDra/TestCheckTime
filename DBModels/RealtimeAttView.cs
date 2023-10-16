using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class RealtimeAttView
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public string EmpName { get; set; } = "";
        public DateTime CheckTime { get; set; }= DateTime.Now;
        public string MachineNo { get; set; } = "";
        public string VerifyMode { get; set; } = "";
        public string SerialNo { get; set; } = "";
        public long? CId { get; set; } = 0;
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
