﻿using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class LeaveBonu
    {
        public int Id { get; set; }
        public long? UserId { get; set; } = 0;
        public DateTime LeaveDate { get; set; }= DateTime.Now;
        public long? NoOfLeave { get; set; } = 0;
        public long? LeaveYear { get; set; } = 0;
        public string Description { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
