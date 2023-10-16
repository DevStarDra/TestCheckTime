using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpOtApproval
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public long? UserOvertimeMin { get; set; } = 0;
        public long? Level1ApproveStatus { get; set; } = 0;
        public string Level1Approveby { get; set; } = "";
        public long? Level2ApproveStatus { get; set; } = 0;
        public string Level2Approveby { get; set; } = "";
        public long? Level3ApproveStatus { get; set; } = 0;
        public string Level3Approveby { get; set; } = "";
        public long? ApproveStatus { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
        public int NoOfLevel { get; set; } = 0;
        public int ApproverGroupId { get; set; } = 0;
        public string NotesApprover1 { get; set; } = "";
        public string NotesApprover2 { get; set; } = "";
        public string NotesApprover3 { get; set; } = "";
    }
}
