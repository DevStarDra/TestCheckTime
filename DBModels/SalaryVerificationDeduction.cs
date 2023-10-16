using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryVerificationDeduction
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public long? Month { get; set; } = 0;
        public long? Year { get; set; } = 0;
        public long? AllowanceId { get; set; } = 0;
        public string AllowanceName { get; set; } = "";
        public string AllowanceAmount { get; set; } = "";
        public string AllowanceType { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
