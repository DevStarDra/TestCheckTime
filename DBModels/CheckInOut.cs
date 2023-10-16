using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class CheckInOut
    {
        public string BadgeNumber { get; set; } = "0";
        public DateTime CheckTime { get; set; }= DateTime.Now;
        public int CId { get; set; } = 0;
        public int Id { get; set; }
        public string CheckType { get; set; } = "";
        public string VerifyCode { get; set; } = "";
        public int WorkCode { get; set; } = 0;
        public string SerialNo { get; set; } = "0";
        public int MaskValue { get; set; } = 0;
        public string TempratureValue { get; set; } = "0";
        public string GpsData { get; set; } = "0";
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public string SDK { get; set; } = "Manual";
    }
}
