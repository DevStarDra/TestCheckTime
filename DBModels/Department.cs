using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Department
    {
        public int Id { get; set; }
        public int DeptId { get; set; } = 1;
        public string DeptName { get; set; } = "";
        public int SubDeptId { get; set; } = 0;
        public int CId { get; set; } = 0;
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
