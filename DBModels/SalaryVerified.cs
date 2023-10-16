using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryVerified
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Name { get; set; } = "";
        public long? DeptId { get; set; } = 0;
        public string DeptName { get; set; } = "";
        public DateTime StartDate { get; set; }= DateTime.Now;
        public DateTime EndDate { get; set; }=DateTime.Now;
        public string TotalHour { get; set; } = "";
        public string TotalDays { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string PaidLeave { get; set; } = "";
        public string BasicSalary { get; set; } = "";
        public string Ot1Salary { get; set; } = "";
        public string Ot2Salary { get; set; } = "";
        public string Ot3Salary { get; set; } = "";
        public string PaidLeaveAmount { get; set; } = "";
        public string Allowance { get; set; } = "";
        public string Claim { get; set; } = "";
        public string Bonus { get; set; } = "";
        public string AllowanceOther1 { get; set; } = "";
        public string AllowanceOther2 { get; set; } = "";
        public string AllowanceOther3 { get; set; } = "";
        public string TotalAllowance { get; set; } = "";
        public string Advance { get; set; } = "";
        public string Loan { get; set; } = "";
        public string DeductionOther1 { get; set; } = "";
        public string DeductionOther2 { get; set; } = "";
        public string DeductionOther3 { get; set; } = "";
        public string TotalDeduction { get; set; } = "";
        public string TotalSalary { get; set; } = "";
        public string Notes { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
