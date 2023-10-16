using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class AllowanceSetting
    {
        public int Id { get; set; }
        public string AllowanceName { get; set; } = "";
        public string AllowanceType { get; set; } = "";
        public string AllowTypeName { get; set; } = "";
        public string AllowTypeCode { get; set; } = "";
        public string AllowTypeAmount { get; set; } = "";
        public int CId { get; set; } = 0;
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
