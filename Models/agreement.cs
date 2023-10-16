using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.Models
{
    public class agreement
    {
        public int id { get; set; }
        public string cid { get; set; }
        public string company_name { get; set; }
        public string key { get; set; }
        public string re_key { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string status { get; set; }
        public string license_type { get; set; }
        public int flag { get; set; }
        public DateTime online_date { get; set; }
        public DateTime process_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
