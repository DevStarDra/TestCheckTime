using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmailSetting
    {
        public int Id { get; set; }
        public string IP { get; set; } = "";
        public int? Port { get; set; } = 0;
        public string EmailId { get; set; } = "";
        public string Password { get; set; } = "";
        public int? SslCheck { get; set; } = 0;
        public int? CredentialsCheck { get; set; } = 0;
        public int? Schedule { get; set; } = 0;
        public string ScheduleDay { get; set; } = "";
        public string ScheduleTime { get; set; } = "";
        public int? AdminCheck { get; set; } = 0;
        public int? DeptManagerCheck { get; set; } = 0;
        public int? EmpCheck { get; set; } = 0;
        public string ExtraEmail { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
