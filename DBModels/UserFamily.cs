using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserFamily
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public string GovtId { get; set; } = "";
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }= DateTime.Now;
        public string Condition { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
