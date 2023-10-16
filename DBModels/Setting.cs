using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Setting
    {
        public int Id { get; set; }
        public long? CId { get; set; } = 0;
        public string CompanyName { get; set; } = "";
        public string WagesCheck { get; set; } = "0";
        public string UploadCheck { get; set; } = "0";
        public string DownloadCheck { get; set; } = "0";
        public string UploadMinutesInverval { get; set; } = "0";
        public string DeleteRecord { get; set; } = "0";
        public string ChooseLanguage { get; set; } = "en";
        public long? PayrollCheck { get; set; } = 0;
        public long? ImportCheck { get; set; } = 0;
        public long? OnlineCheck { get; set; } = 0;
        public long? TeaBreakCheck { get; set; } = 0;
        public string BackupFolder { get; set; } = "";
        public long? BackupCheck { get; set; } = 0;
        public string DeviceType { get; set; } = "";
        public long? MultiBranchCheck { get; set; } = 0;
        public long? OvertimeApprovelCheck { get; set; } = 0;
        public long? OvertimeApprovelLevel { get; set; }= 0;
        public long? Leavelevel { get; set; } = 0;
        public long? SinglePunch { get; set; } = 0;
        public string LeaveRule { get; set; } = "0";
        public long? VoiceCheck { get; set; } = 0;
        public string VoiceGender { get; set; } = "";
        public string VoiceAge { get; set; } = "";
        public string SpeakRate { get; set; } = "";
        public string TextToSpeak { get; set; } = "";
        public long? WelcomeTrial { get; set; } = 0;
        public long? Days { get; set; } = 0;
        public string OtIntervalCheck { get; set; } = "0";
        public string OtInterval { get; set; } = "0";
        public string Break1DeductionSelect { get; set; } = "0";
        public string Break1DeductionCheck { get; set; } = "0";
        public string DbVersion { get; set; } = "1.0";
        public string EarlyDeductionCheck { get; set; } = "0";
        public string LateDeductionCheck { get; set; } = "0";
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public int OtRoundOption { get; set; } = 0;
        public string SoftwareVersion { get; set; } = "1.0";
        public string WeekendDays { get; set; } = "0";
        public long? ServerFlag { get; set; } = 0;
        public string ViewDatetime { get; set; } = "dd/MM/yyyy HH:mm:ss";
        public string ViewDate { get; set; } = "dd/MM/yyyy";
        public string ViewTime { get; set; } = "HH:mm:ss";
        public string NoOfEmployee { get; set; } = "9999";
        public string ConnectionDatasource { get; set; } = "";
        public long? ShiftCheck { get; set; } = 0;
        public string ShiftStartTime { get; set; } = "";
        public string ShiftEndTime { get; set; } = "";
        public string ShiftMinHour { get; set; } = "0";
        public string ShiftMaxOt { get; set; } = "0";
        public long? WorkHourLeave { get; set; } = 480;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;

        public int? NepaliCalendar { get; set; }
        public long? TimetableId { get; set; }
        public int HolidayMerge { get; set; }
        public int RestdayMerge { get; set; }

    }
}
