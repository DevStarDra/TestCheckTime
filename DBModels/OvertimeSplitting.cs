using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class OvertimeSplitting
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? NormalotCheck { get; set; } = 0;
        public int? NormalotRestotMin { get; set; } = 0;
        public int? NormalotRestotMax { get; set; } = 0;
        public int? NormalotHolidayotMin { get; set; } = 0;
        public int? NormalotHolidayotMax { get; set; } = 0;
        public int? ResttoCheck { get; set; } = 0;
        public int? RestotNormalotMin { get; set; } = 0;
        public int? RestotNormalotMax { get; set; } = 0;
        public int? ResttoHolidayotMin { get; set; } = 0;
        public int? ResttoHolidayotMax { get; set; } = 0;
        public int? HolidayotCheck { get; set; } = 0;
        public int? HolidayotNormalotMin { get; set; } = 0;
        public int? HolidayotNormalotMax { get; set; } = 0;
        public int? HolidayotRestotMin { get; set; } = 0;
        public int? HolidayotRestotMax { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
