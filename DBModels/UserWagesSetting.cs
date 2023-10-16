using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserWagesSetting
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string BankName { get; set; } = "";
        public string BankAccount { get; set; } = "";
        public long? Ifsc { get; set; } = 0;
        public long? TransferType { get; set; } = 0;
        public long? WagesType { get; set; } = 0;
        public string WagesAmount { get; set; } = "";
        public long? OtType { get; set; } = 0;
        public string Ot1Amt { get; set; } = "";
        public string Ot2Amt { get; set; } = "";
        public string Ot3Amt { get; set; } = "";
        public string UserGroup { get; set; } = "";
        public long? WagesTypeValue { get; set; } = 0;
        public long? MonthlyOrScheduleDay { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
