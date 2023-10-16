using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Test
    {
        public long Id { get; set; }
        public string Description { get; set; } = "";
        public string WebsiteLink { get; set; } = "";
        public string SocialLink1 { get; set; } = "";
        public string SocialLink2 { get; set; } = "";
        public string SocialLink3 { get; set; } = "";
        public string ServerConnectionString { get; set; } = "";
        public long? CId { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public long? CIds { get; set; }
        public long? CIdss { get; set; }
    }
}
