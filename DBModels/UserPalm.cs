using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class UserPalm
    {
        public int Id { get; set; }
        public string Badgenumber { get; set; } = "";
        public long? ValidFlag { get; set; } = 0;
        public long? IsDuress { get; set; } = 0;
        public string TemplateType { get; set; } = "";
        public string Version { get; set; } = "";
        public long? DataFormat { get; set; } = 0;
        public string TemplateNo { get; set; } = "";
        public long? TemplateNoIndex { get; set; } = 0;
        public string TemplateData { get; set; } = "";
        public long? CId { get; set; } = 0;
        public string Sdk { get; set; } = "";
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
