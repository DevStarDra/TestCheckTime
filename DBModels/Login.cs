using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = "";
        public string Status { get; set; } = "";
        public string Emailid { get; set; } = "";
        public string ComapnyName { get; set; } = "";
        public string Name { get; set; } = "";
        public string Contactno { get; set; } = "";
        public string ComapnyAddress { get; set; } = "";
        public string CompanyWebsite { get; set; } = "";
        public string Image { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
