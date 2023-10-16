using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class ApproverGroup
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? NoOfLevel { get; set; } = 0;
        public int? Level1Approver { get; set; } = 0;
        public int? Level2Approver { get; set; } = 0;
        public int? Level3Approver { get; set; } = 0;
        public int? LeaveApproval { get; set; } = 0;
        public int? OtApproval { get; set; } = 0;
        public int CId { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int? NormalOt { get; set; } = 0;
        public int? RestdayOt { get; set; } = 0;
        public int? HolidayOt { get; set; } = 0;

    }
}
