using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class PayrollView
    {
        public int Id { get; set; }
        public long? SqlCheck { get; set; } = 0;
        public long? MillionCheck { get; set; } = 0;
        public long? PandaCheck { get; set; } = 0;
        public long? RymnetCheck { get; set; } = 0;
        public long? Hr2000Check { get; set; } = 0;
        public long? AutocountCheck { get; set; } = 0;
        public long? FtpCheck { get; set; } = 0;
        public long? BossnetCheck { get; set; } = 0;
        public long? TdCheck { get; set; } = 0;
        public long? HrmsCheck { get; set; } = 0;
        public long? ActpayCheck { get; set; } = 0;
        public long? UbslCheck { get; set; } = 0;
        public long? MCheck { get; set; } = 0;
        public long? HrmsflexiCheck { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
