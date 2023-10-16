using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class FixTimetable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string OnDutyTime { get; set; } = "";
        public string OffDutyTime { get; set; } = "";
        public long? LateTimeAllow { get; set; } = 0;
        public long? LeaveEarlyAllow { get; set; } = 0;
        public string Color { get; set; } = "";
        public string BeginningIn { get; set; } = "";
        public string BeginningOut { get; set; } = "";
        public string EndingIn { get; set; } = "";
        public string EndingOut { get; set; } = "";
        public long? MaxOt { get; set; } = 0;
        public string Break1Start { get; set; } = "";
        public string Break1End { get; set; } = "";
        public long? Break1Max { get; set; } = 0;
        public long? OtBeforeWork { get; set; } = 0;
        public long? OtBeforeWorkMinuteMin { get; set; } = 0;
        public long? OtBeforeWorkMinuteMax { get; set; } = 0;
        public long? Ot1Check { get; set; } = 0;
        public long? Ot2Check { get; set; } = 0;
        public long? Ot3Check { get; set; } = 0;
        public string Ot1Value { get; set; } = "";
        public string Ot2Value { get; set; } = "";
        public string Ot3Value { get; set; } = "";
        public long? BreakBeforeOtCheck { get; set; } =0;
        public long? BreakBeforeOtMin { get; set; } = 0;
        public long? Break2Check { get; set; } = 0;
        public string Break2Start { get; set; } = "";
        public string Break2End { get; set; } = "";
        public long? Break2Max { get; set; } = 0;
        public long? AdvanceRuleCheck { get; set; }=0;
        public long? RoundOption { get; set; } = 0;
        public long? LateDeductOption { get; set; } = 0;
        public long? EarlyDeductOption { get; set; } = 0;
        public long? Break1OptionCheck { get; set; } = 0;
        public long? Break1DeductOption { get; set; } = 0;
        public long? Break2OptionCheck { get; set; } = 0;
        public long? Break2DeductOption { get; set; } = 0;
        public long? BreakCheck { get; set; } = 0;
        public long? Break3Check { get; set; } = 0;
        public string Break3Start { get; set; } = "";
        public string Break3End { get; set; } = "";
        public long? Break3Max { get; set; } = 0;
        public long? Break4Check { get; set; } = 0;
        public string Break4Start { get; set; } = "";
        public string Break4End { get; set; } = "";
        public long? Break4Max { get; set; } = 0;
        public long? Break3OptionCheck { get; set; } = 0;
        public long? Break3DeductOption { get; set; } = 0;
        public long? Break4OptionCheck { get; set; } = 0;
        public long? Break4DeductOption { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
