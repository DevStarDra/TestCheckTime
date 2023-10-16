using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class PunchReport
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public string Name { get; set; } = "";
        public DateTime CurrentDate { get; set; }= DateTime.Now;
        public string CheckIn { get; set; } = "";
        public string CheckOut { get; set; } = "";
        public string BreakIn { get; set; } = "";
        public string BreakOut { get; set; } = "";
        public string OtIn { get; set; } = "";
        public string OtOut { get; set; } = "";
        public string DinnerIn { get; set; } = "";
        public string DinnerOut { get; set; } = "";
        public string TotalDays { get; set; } = "";
        public string Overtime { get; set; } = "";
        public DateTime StartDate { get; set; }=DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public string TotalOvertime { get; set; } = "";
        public string TotalTime { get; set; } = "";
        public string TotalWorkTime { get; set; } = "";
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
