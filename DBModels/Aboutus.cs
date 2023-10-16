using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Aboutus
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public string WebsiteLink { get; set; } = "";
        public string SocialLink1 { get; set; } = "";
        public string SocialLink2 { get; set; } = "";
        public string SocialLink3 { get; set; } = "";
        public string ServerConnectionString { get; set; } = "";
        public int CId { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }= DateTime.Now;

    }
}
