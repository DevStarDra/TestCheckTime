using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Userinfo
    {
        [Key]
        public int UserId { get; set; }
        public string Badgenumber { get; set; } = "";
        public string Payid { get; set; } = "";
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Title { get; set; } = "";
        public DateTime BirthDay { get; set; } =DateTime.Now;
        public DateTime HireDay { get; set; }=DateTime.Now;
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Nationality { get; set; } = "";
        public string Zip { get; set; } = "";
        public string Emailid { get; set; } = "";
        public string Contactno { get; set; } = "";
        public long? VerifyFlag { get; set; } = 0;
        public long? DeptId { get; set; } = 1;
        public string Password { get; set; }= "";
        public string Image { get; set; } = "";
        public string Privilege { get; set; } = "";
        public string CardNo { get; set; } = "";
        public long? Flag { get; set; } = 0;
        public string Timezone1 { get; set; } = "";
        public string Timezone2 { get; set; } = "";
        public string Timezone3 { get; set; } = "";
        public string Pin { get; set; } = "";
        public long? MedicalLeave { get; set; } = 0;
        public long? AnnualLeave { get; set; } = 0;
        public string Ot1 { get; set; } = "";
        public string Ot2 { get; set; } = "";
        public string Ot3 { get; set; } = "";
        public long? WeekendCheck { get; set; } = 0;
        public string WeekendDays { get; set; } = "0";
        public long? RestDayCheck { get; set; } = 0;
        public long? RestDayOtCheck { get; set; } = 0;
        public long? HolidayCheck { get; set; } = 0;
        public long? HolidayOtCheck { get; set; } = 0;
        public long? NormalMaxTotalOt { get; set; } = 0;
        public long? LateDeductCheck { get; set; } = 0;
        public long? LateIn { get; set; } = 0;
        public long? LateTo { get; set; } = 0;
        public long? LateDeduct { get; set; } = 0;
        public long? MaxLateDeduct { get; set; } = 0;
        public long? LateType { get; set; } = 0;
        public string Seprater { get; set; } = "";
        public string CertificateType { get; set; } = "";
        public string GroupId { get; set; } = "";
        public string PersonId { get; set; } = "";
        public string Age { get; set; } = "";
        public long? OvertimeApproval { get; set; } = 0;
        public string GovtId { get; set; } = "";
        public string Condition { get; set; } = "";
        public string CitizenShip { get; set; } = "";
        public string MaritalStatus { get; set; } = "";
        public long? SinglePunchCheck { get; set; } = 0;
        public long? SinglePunch { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public string Sdk { get; set; } = "";
        public long? ServerFlag { get; set; } = 0;
        public long? WorkHourLeave { get; set; } = 480;
        public long? CheckWorkHourLeave { get; set; } = 0;
        public string LoginUsername { get; set; } = "";
        public string LoginPassword { get; set; } = "";
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
