using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpAllowance
    {
        public int Id { get; set; }
        public int UserId { get; set; } = 0;
        public int AllowanceId { get; set; } = 0;
        public DateTime StartDate { get; set; }= DateTime.Now;
        public DateTime EndDate { get; set; }=DateTime.Now;
        public int CId { get; set; } = 0;
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
