using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class FixShift
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public long? Unit { get; set; } = 0;
        public long? AlternateSatCheck { get; set; } = 0;
        public long? FirstSat { get; set; } = 0;
        public long? SecondSat { get; set; }= 0;
        public long? ThirdSat { get; set; }=0;
        public long? FourthSat { get; set; } = 0;
        public long? FifthSat { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public long? SelectedId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
