using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserFinger
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public long? FingerId { get; set; } = 0;
        public string Template { get; set; } = "";
        public long? Length { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public string Sdk { get; set; } = "";
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
