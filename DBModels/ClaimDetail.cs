using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class ClaimDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; } = 0;
        public string ClaimName { get; set; } = "";
        public string ClaimReason { get; set; } = "";
        public string ClaimProjectforName { get; set; } = "";
        public string ClaimAmount { get; set; } = "";
        public DateTime ClaimDate { get; set; }= DateTime.Now;
        public int CId { get; set; } = 0;
        public string ClaimImage { get; set; } = "";
        public int ClaimNameId { get; set; } = 0;
        public int ClaimProjectforNameId { get; set; } = 0;
        public int ClaimStatus { get; set; } = 0;
        public int? ClaimApprovedByAdmin { get; set; } = 0;
        public int? ClaimApprovedByDep { get; set; }
        public int? ClaimApprovedDepManagerId { get; set; }=0;
        public int ServerFlag { get; set; } = 0;
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
