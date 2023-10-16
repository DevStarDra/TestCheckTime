using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Overtimerule
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Code { get; set; } = "";
        public int? Normalotcheck { get; set; } = 0;
        public int? Normalworktime { get; set; } = 0;
        public int? Normalot { get; set; } = 0;
        public int? Restdayotcheck { get; set; } = 0;
        public int? Restdayworktime { get; set; } = 0;
        public int? Restdayot { get; set; } = 0;
        public int? Holidayotcheck { get; set; } = 0;
        public int? Holidayworktime { get; set; } = 0;
        public int? Holidayot { get; set; } = 0;

        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
