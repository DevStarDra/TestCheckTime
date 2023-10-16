using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class ReportTotal
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Badgenumber { get; set; } = "";
        public string Name { get; set; } = "";
        public DateTime StartDate { get; set; }=DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public long? DeptId { get; set; } = 0;
        public string DeptName { get; set; } = "";
        public string CompanyName { get; set; } = "";
        public string CompanyAddress { get; set; } = "";
        public string PresentDays { get; set; } = "";
        public string Late { get; set; } = "";
        public string Early { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string Absent { get; set; } = "";
        public string Leave { get; set; } = "";
        public string SumOt { get; set; } = "";
        public string ScheduleName { get; set; } = "";
        public string TotalScheduleDay { get; set; } = "";
        public string TotalSchHour { get; set; } = "";
        public string TotalSalary { get; set; } = "";
        public string TotalNormalHour { get; set; } = "";
        public string TotalPaidLeave { get; set; } = "";
        public string TotalUnpaidLeave { get; set; } = "";
        public string Holiday { get; set; } = "";
        public string MedicalLeave { get; set; } = "";
        public string MaternityLeave { get; set; } = "";
        public string AnnualLeave { get; set; } = "";
        public string EarlyPenaltyTotal { get; set; } = "";
        public string LatePenaltyTotal { get; set; } = "";
        public string LessHourTotal { get; set; } = "";
        public string LessHourTotalDays { get; set; } = "";
        public long? Flag { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
        public int SessionId { get; set; } = 0;
        public string nepali_start_date { get; set; } = "1990-01-01";
        public string nepali_end_date { get; set; } = "1990-01-01";
        public int NepaliFlag { get; set; } = 0;
        public string TotalScheduleDeduction { get; set; } = "";
        public string Break1Total { get; set; } = "";
        public string Break1MaxTotal { get; set; } = "";
        public string Break2Total { get; set; } = "";
        public string Break2MaxTotal { get; set; } = "";
        public string Break3Total { get; set; } = "";
        public string Break3MaxTotal { get; set; } = "";
        public string Break4Total { get; set; } = "";
        public string Break4MaxTotal { get; set; } = "";
        public string AllowanceDaysNo { get; set; } = "";
        public string AllowanceDaysAmount { get; set; } = "";
        public string AllowanceTimetableNo { get; set; } = "";
        public string AllowanceTimetableAmount { get; set; } = "";
        public string AllowanceHourNo { get; set; } = "";
        public string AllowanceHourAmount { get; set; } = "";
        public string AllowanceEarlyNo { get; set; } = "";
        public string AllowanceEarlyAmount { get; set; } = "";
        public string AllowanceOvertimeNo { get; set; } = "";
        public string AllowanceOvertimeAmount { get; set; } = "";
        public string PayId { get; set; } = "";
    }
}
