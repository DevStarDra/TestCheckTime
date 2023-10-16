using CheckTimeAttendanceManagementSoftware.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.ViewModels
{
    internal class signinvm
    {
        public List<Signin> signin_get_signin_data(string username, string password,int cid)
        {
            List<Signin> signin_ = new List<Signin>();
            using (CheckTimeDBContext context = new CheckTimeDBContext())
            {
                var data = context.CompanyDetails.Where(x => x.CId == cid).ToList();
                if (data.Count == 0)
                {
                    //      int messageboxflag = SplashScreen.Messagebox_Data.messagebox_View("info", "SignIn", "Please select company name first");
                }
                else
                {
                    signin_ = (from i in context.Signins
                               where i.Username == username &&
                               i.Password == password &&
                               i.Status == "Active" && i.CId == data[0].CId
                               select i).ToList();
                }
            }
            return signin_;

        }
                        
    }
}
