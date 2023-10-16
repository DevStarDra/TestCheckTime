using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class PenaltySetting
    {
        public int Id { get; set; }
        public long? PenaltyId { get; set; } = 0;
        public string PenaltyName { get; set; } = "";
        public string PenaltyType { get; set; } = "";
        public string PenaltyCode { get; set; } = "";
        public long? PenaltyDedutFrom { get; set; } = 0;
        public long? MaxDeduct { get; set; } = 0;
        public long? PenaltyFrom { get; set; } = 0;
        public long? PenaltyTo { get; set; } = 0;
        public long? PenaltyDeduct { get; set; } = 0;
        public DateTime PenaltyDate { get; set; } = DateTime.Now;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public string AbsentDays { get; set; } = "";
        public long? AbsentContinue { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
