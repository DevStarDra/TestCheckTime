using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryRecheck
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Name { get; set; } = "";
        public DateTime Date { get; set; }= DateTime.Now;
        public string Credit { get; set; } = "";
        public string Days { get; set; } = "";
        public string TotalHour { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string PaidLeave { get; set; } = "";
        public string UnpaidLeave { get; set; } = "";
        public string AllowanceAmount { get; set; } = "";
        public long? DeptId { get; set; } = 0;
        public string DeptName { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
