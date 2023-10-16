using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class EmployeeOtrule
    {
        public int Id { get; set; }
        public int UserId { get; set; }=0;
        public int OtruleId { get; set; } = 0;
        public long? CId { get; set; } = 0;
        public int? Status { get; set; } = 0;
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
