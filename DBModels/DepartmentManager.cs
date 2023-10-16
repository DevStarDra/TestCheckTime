using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class DepartmentManager
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string EmailId { get; set; } = "";
        public string SelectedDepartment { get; set; } = "";
        public int CId { get; set; } = 0;
        public int CHK { get; set; } = 0;
        public string Token { get; set; } = "";
        public int UserId { get; set; } = 0;
        public string DepartmentManagerLevel { get; set; } = "";
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
