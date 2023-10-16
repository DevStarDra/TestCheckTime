using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpLeaveApproval
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public long? LeaveClassId { get; set; } = 0;
        public string? LeaveClassName { get; set; } = "";
        public string Reason { get; set; } = "";
        public string PaidUnpaid { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public long? CatagoryId { get; set; } = 0;
        public string? CatagoryName { get; set; } = "";
        public string LeaveUnit { get; set; } = "";
        public string HourFrom { get; set; } = "";
        public string HourTo { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int NoOfLevel { get; set; } = 0;
        public int ApproverGroupId { get; set; } = 0;
        public long? ApproveStatus { get; set; } = 0;
        public long? Level1ApproveStatus { get; set; } = 0;
        public string Level1Approveby { get; set; } = "";
        public long? Level2ApproveStatus { get; set; } = 0;
        public string Level2Approveby { get; set; } = "";
        public long? Level3ApproveStatus { get; set; } = 0;
        public string Level3Approveby { get; set; } = "";
        public string NotesApprover1 { get; set; } = "";
        public string NotesApprover2 { get; set; } = "";
        public string NotesApprover3 { get; set; } = "";
        public string Approver1Date { get; set; } = "";
        public string Approver2Date { get; set; } = "";
        public string Approver3Date { get; set; } = "";
    }
}
