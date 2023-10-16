using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryVerification
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Name { get; set; } = "";
        public long? DeptId { get; set; } = 0;
        public string DeptName { get; set; } = "";
        public long? Month { get; set; } = 0;
        public long? Year { get; set; } = 0;
        public string Basic { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string ReportAllowance { get; set; } = "";
        public string Allowance { get; set; } = "";
        public string Deduction { get; set; } = "";
        public string Advance { get; set; } = "";
        public string Loan { get; set; } = "";
        public string Total { get; set; } = "";
        public long? Flag { get; set; } = 0;
        public string SalaryGroups { get; set; } = "";
        public long? PastPayrollId { get; set; } = 0;
        public string PaidLeave { get; set; } = "";
        public string SalaryRate { get; set; } = "";
        public string SalaryUnit { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
