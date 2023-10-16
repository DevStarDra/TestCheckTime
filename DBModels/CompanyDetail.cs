using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class CompanyDetail
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = "";
        public string Address { get; set; } = "";
        public string State { get; set; } = "";
        public string City { get; set; } = "";
        public string Zip { get; set; } = "";
        public string Country { get; set; } = "";
        public string PersonName { get; set; } = "";
        public string EmailId { get; set; } = "";
        public string ContactNo { get; set; } = "";
        public string? Image { get; set; } = "";
        public int CId { get; set; } = 0;
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int ServerFlag { get; set; } = 0;
        public int Flag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
