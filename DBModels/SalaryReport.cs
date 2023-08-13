﻿using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class SalaryReport
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
        public string Punch1In { get; set; } = "";
        public string Punch1Out { get; set; } = "";
        public string Punch1Total { get; set; } = "";
        public string Punch2In { get; set; } = "";
        public string Punch2Out { get; set; } = "";
        public string Punch2Total { get; set; } = "";
        public string Punch3In { get; set; } = "";
        public string Punch3Out { get; set; } = "";
        public string Punch3Total { get; set; } = "";
        public string Punch4In { get; set; } = "";
        public string Punch4Out { get; set; } = "";
        public string Punch4Total { get; set; } = "";
        public string Punch5In { get; set; } = "";
        public string Punch5Out { get; set; } = "";
        public string Punch5Total { get; set; } = "";
        public string PunchAllTotal { get; set; } = "";
        public string WorkTimeSalary { get; set; } = "";
        public string Ot1Salary { get; set; } = "";
        public string Ot2Salary { get; set; } = "";
        public string Ot3Salary { get; set; } = "";
        public string BonusPoint { get; set; } = "";
        public string AllowanceCode { get; set; } = "";
        public string AllowanceCodeName { get; set; } = "";
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
        public long? LatePenalty { get; set; } = 0;
        public long? EarlyPenalty { get; set; } = 0;
        public string OtApproveStatus { get; set; } = "";
        public string OtApprovedBy { get; set; } = "";
        public long? SalaryMonth { get; set; } = 0;
        public long? SalaryYear { get; set; } = 0;
        public long? PastPayrollId { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}