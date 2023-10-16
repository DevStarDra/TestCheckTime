using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Branch
    {
        public int Id { get; set; }
        public int BranchAutoId { get; set; }=0;
        public string BranchId { get; set; } = "";
        public string BranchName { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public string Question1 { get; set; } = "";
        public string Annswer1 { get; set; } = "";
        public string Question2 { get; set; } = "";
        public string Annswer2 { get; set; } = "";
        public int? UseFlag { get; set; } = 0;
        public int CId { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
