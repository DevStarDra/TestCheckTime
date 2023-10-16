using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryAllowDeductGroup
    {
        public int Id { get; set; }
        public long? GroupId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public long? AllowDeductId { get; set; } = 0;
        public string AllowDeductType { get; set; } = "";
        public DateTime Date { get; set; }= DateTime.Now;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
