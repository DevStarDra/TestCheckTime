using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserCardnoPassword
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public string CardNo { get; set; } = "";
        public string Password { get; set; } = "";
        public string Sdk { get; set; } = "";
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
