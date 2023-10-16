using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class AuditLog
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public DateTime AuditDate { get; set; }=DateTime.Now;
        public string InsertBy { get; set; } = "";
        public int CId { get; set; } = 0;
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
