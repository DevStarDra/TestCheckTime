using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Signin
    {
        public int Id { get; set; } = 0;
        public string Username { get; set; }  = "";
        public string Password { get; set; }= "";
        public string UserType { get; set; } = "";
        public string Contactno { get; set; }= "";
        public string Emailid { get; set; } = "";
        public string Status { get; set; } = "";
        public string Departments { get; set; } = "";
        public string Levels { get; set; } = "";
        public long? LeaveApprove { get; set; } = 0;
        public long? OtApply { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public long? UserId { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string ProcessorId { get; set; } = "";
        public int LoginFlag { get; set; } = 0;
        public int RoleId { get; set; } = 0;
    }
}
