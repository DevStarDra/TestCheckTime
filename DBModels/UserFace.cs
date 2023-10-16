using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserFace
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public long? FaceId { get; set; } = 0;
        public string Template { get; set; } = "";
        public string Length { get; set; } = "";
        public string FaceUrl { get; set; } = "";
        public string ModelData { get; set; } = "";
        public long? CId { get; set; } = 0;
        public string Sdk { get; set; } = "";
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
