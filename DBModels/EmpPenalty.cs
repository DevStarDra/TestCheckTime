using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpPenalty
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public long? PenaltyId { get; set; } = 0;
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }= DateTime.Now;
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
