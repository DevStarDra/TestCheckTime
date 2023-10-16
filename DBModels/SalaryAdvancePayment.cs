using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryAdvancePayment
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Amount { get; set; } = "";
        public long? Flag { get; set; } = 0;
        public DateTime Date { get; set; }=DateTime.Now;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
