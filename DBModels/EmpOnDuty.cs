using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpOnDuty
    {
        public int Id { get; set; }
        public string DeptName { get; set; } = "";
        public long? UserId { get; set; } = 0;
        [Column(TypeName = "date")]
        public DateTime CurrentDate { get; set; }=DateTime.Now;
        public string CheckIn { get; set; } = "";
        public string CheckOut { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
