using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class LeaveCatagory
    {
        public int Id { get; set; }
        public string Catagory { get; set; } = "";
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
