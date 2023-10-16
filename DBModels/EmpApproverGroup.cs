using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpApproverGroup
    {
        public int Id { get; set; }
        public int UserId { get; set; }=0;
        public int ApproverGroupId { get; set; } = 0;
        [Column(TypeName = "date")]
        public DateTime Ondate { get; set; }=DateTime.Now;
        public int CId { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
