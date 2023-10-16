using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class TimetableReport
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";
        public DateTime TempDate { get; set; }= DateTime.Now;
        public string TimeTable { get; set; } = "";
        public string ColorFormat { get; set; } = "";
        public string Color { get; set; } = "";
        public string CheckIn { get; set; } = "";
        public string CheckOut { get; set; } = "";
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
