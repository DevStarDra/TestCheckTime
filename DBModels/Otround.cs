using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Otround
    {
        public int Id { get; set; }
        public string Otname { get; set; }= "";
        public string Ot1roundvalue { get; set; } = "";
        public long? Ot1roundtype { get; set; } = 0;
        public string Ot2roundvalue { get; set; } = "";
        public long? Ot2roundtype { get; set; } = 0;
        public string Ot3roundvalue { get; set; } = "";
        public long? Ot3roundtype { get; set; } = 0;

        public int CId { get; set; }=0;
        public DateTime Createdat { get; set; } = DateTime.Now;
        public DateTime Updatedat { get; set; } = DateTime.Now;
    }
}
