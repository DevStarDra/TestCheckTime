using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryLoanStatement
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Credit { get; set; } = "";
        public string Debit { get; set; } = "";
        public string Balance { get; set; } = "";
        public DateTime StartDate { get; set; }= DateTime.Now;
        public string Emi { get; set; } = "";
        public string DueBalance { get; set; } = "";
        public long? Month { get; set; } = 0;
        public long? Year { get; set; } = 0;
        public DateTime Date { get; set; }=DateTime.Now;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
