using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class ServerLog
    {
        public int Id { get; set; }
        public string SubmitType { get; set; } = "";
        public string SubmitId { get; set; } = "";
        public string TableName { get; set; } = "";
        public DateTime ServerDate { get; set; }= DateTime.Now;
        public string UserId { get; set; } = "";
        public string UserType { get; set; } = "";
        public long? PcId { get; set; } = 0;
        public long? ServerId { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
