using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class FlexTimetable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string OnDutyTime { get; set; } = "";
        public string OffDutyTime { get; set; } = "";
        public string WorkHourMin { get; set; } = "0";
        public long? MaxOt { get; set; } = 0;
        public string Color { get; set; } = "";
        public string Break1Start { get; set; } = "";
        public string Break1End { get; set; } = "";
        public long? Break1Max { get; set; } = 0;
        public long? Ot1Check { get; set; } = 0;
        public long? Ot2Check { get; set; } = 0;
        public long? Ot3Check { get; set; } = 0;
        public string Ot1Value { get; set; } = "";
        public string Ot2Value { get; set; } = "";
        public string Ot3Value { get; set; } = "";
        public long? Break1OptionCheck { get; set; } = 0;
        public long? Break1DeductOption { get; set; } = 0;
        public long? WorktimeRule { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;

        public int? RoundOption { get; set; }=0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
        public long? AdvanceRuleCheck { get; set; } = 0;
        public long? CheckFlexBeginningIn { get; set; } = 0;
        public string FlexBeginningIn { get; set; } = "";
    }
}
