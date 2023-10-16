using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmpOtSplitting
    {
        public int Id { get; set; }
        public long UserId { get; set; } = 0;
        public long OtSplittingId { get; set; } = 0;
        [Column(TypeName = "date")]
        public DateTime Ondate { get; set; }= DateTime.Now;
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
