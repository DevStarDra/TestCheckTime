using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string DeptName { get; set; } = "";
        public long? UserId { get; set; } = 0;
        public string EmpName { get; set; } = "";
        public DateTime CurrentDate { get; set; }= DateTime.Now;
        public string CurrentTime { get; set; } = "";
        public string Description { get; set; } = "";
        public long? Status { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? SelectedId { get; set; } = 0;
        public long? ApiDepartmentFlag { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
