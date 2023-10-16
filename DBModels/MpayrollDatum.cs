using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class MpayrollDatum
    {
        public int Id { get; set; }
        public string PayId { get; set; } = "";
        public string PublicHoliday { get; set; } = "";
        public string DaysWorked { get; set; } = "";
        public string HoursWorked { get; set; } = "";
        public string Lateness { get; set; } = "";
        public string EarlyDeparture { get; set; } = "";
        public string NoPayHour { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string Ot4 { get; set; } = "";
        public string Ot5 { get; set; } = "";
        public string Ot6 { get; set; } = "";
        public string Absence { get; set; } = "";
        public string AnnualLeave { get; set; } = "";
        public string CompassionateLeave { get; set; } = "";
        public string ExaminationLeave { get; set; } = "";
        public string HospitalLeave { get; set; } = "";
        public string LineShutdownLeave { get; set; } = "";
        public string MedicalLeave { get; set; } = "";
        public string MarriageLeave { get; set; } = "";
        public string MaternityLeave { get; set; } = "";
        public string NonPayLeave { get; set; } = "";
        public string OutOfBound { get; set; } = "";
        public string PaternityLeave { get; set; } = "";
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
