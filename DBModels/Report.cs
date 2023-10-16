using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Report
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public long? UserId { get; set; } = 0;
        public string Badgenumber { get; set; } = "";
        public string Name { get; set; } = "";
        public string ScheduleIn { get; set; } = "";
        public string ScheduleOut { get; set; } = "";
        public string ScheduleName { get; set; } = "";
        public string CheckIn { get; set; } = "";
        public string CheckOut { get; set; } = "";
        public string Late { get; set; } = "";
        public string Early { get; set; } = "";
        public string TotalHour { get; set; } = "";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public string TimeStatus { get; set; } = "";
        public string Remarks { get; set; } = "";
        public string WorkStatus { get; set; } = "";
        public string DeptName { get; set; } = "";
        public DateTime StartDate { get; set; }= DateTime.Now;
        public DateTime EndDate { get; set; }=DateTime.Now;
        public string CheckIn2 { get; set; } = "";
        public string CheckOut2 { get; set; } = "";
        public string CheckIn3 { get; set; } = "";
        public string CheckOut3 { get; set; } = "";
        public string CheckIn4 { get; set; } = "";
        public string CheckOut4 { get; set; } = "";
        public string Break1In { get; set; } = "";
        public string Break1Out { get; set; } = "";
        public string Break1Time { get; set; } = "";
        public string Break1MaxTime { get; set; } = "";
        public string Break1RemainingTime { get; set; } = "";
        public string Break2In { get; set; } = "";
        public string Break2Out { get; set; } = "";
        public string Break2Time { get; set; } = "";
        public string Break2MaxTime { get; set; } = "";
        public string Break2RemainingTime { get; set; } = "";
        public string Break3In { get; set; } = "";
        public string Break3Out { get; set; } = "";
        public string Break3Time { get; set; } = "";
        public string Break3MaxTime { get; set; } = "";
        public string Break3RemainingTime { get; set; } = "";
        public string Break4In { get; set; } = "";
        public string Break4Out { get; set; } = "";
        public string Break4Time { get; set; } = "";
        public string Break4MaxTime { get; set; } = "";
        public string Break4RemainingTime { get; set; } = "";
        public string WorkTimeSalary { get; set; } = "";
        public string Ot1Salary { get; set; } = "";
        public string Ot2Salary { get; set; } = "";
        public string Ot3Salary { get; set; } = "";
        public string BonusPoint { get; set; } = "";
        public string AllowanceCode { get; set; } = "";
        public string AllowanceName { get; set; } = "";

        public string AllowanceType { get; set; } = "";
        public string AllowanceAmount { get; set; } = "";
        public string CheckInTemprature { get; set; } = "";
        public string CheckOutTemprature { get; set; } = "";
        public string LeaveName { get; set; } = "";
        public string LeaveCode { get; set; } = "";
        public string LeaveUnit { get; set; } = "";
        public string HolidayName { get; set; } = "";
        public string LessHour { get; set; } = "";
        public string SumBasicOt { get; set; } = "";
        public string ScheduleHour { get; set; } = "";
        public string ScheduleDays { get; set; } = "";
        public string ActualDays { get; set; } = "";
        public string ActualOt1 { get; set; } = "";
        public string AppliedOt1 { get; set; } = "";
        public string RemainOt1 { get; set; } = "";
        public string ActualOt2 { get; set; } = "";
        public string AppliedOt2 { get; set; } = "";
        public string RemainOt2 { get; set; } = "";
        public string ActualOt3 { get; set; } = "";
        public string AppliedOt3 { get; set; } = "";
        public string RemainOt3 { get; set; } = "";
        public DateTime CurrentDate { get; set; } = DateTime.Now ;
        public long? LatePenalty { get; set; } = 0;
        public long? EarlyPenalty { get; set; } = 0;
        public string OtApproveStatus { get; set; } = "";
        public string OtApprovedBy { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
        public string? NepaliDate { get; set; } = "";
        public string CurrentDay { get; set; } = "";
        public string LatePenaltyCode { get; set; } = "";
        public string EarlyPenaltyCode { get; set; } = "";
        public string LatePenaltyName { get; set; } = "";
        public string EarlyPenaltyName { get; set; } = "";
        public string OtsplittingName { get; set; } = "";
        public string OtroundName { get; set; } = "";
        public string OtruleName { get; set; } = "";
        public string OtruleCode { get; set; } = "";
        public int SessionId { get; set; } = 0;
        public string ScheduleDeduction { get; set; } = "";

        public string PayId { get; set; } = "";
        public string LeavePaidUnpaid { get; set; } = "";

        public string Ot1Code { get; set; } = "";
        public string Ot2Code { get; set; } = "";
        public string Ot3Code { get; set; } = "";
    }
}
