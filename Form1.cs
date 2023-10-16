using Org.BouncyCastle.Crypto.Agreement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Security.Cryptography;
using CheckTimeAttendanceManagementSoftware.ViewModels ;
using CheckTimeAttendanceManagementSoftware.DBModels;
using CheckTimeAttendanceManagementSoftware.Models;

namespace TestCheckTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (CheckTimeDBContext context = new CheckTimeDBContext())
                {
                    signinvm signinvms = new signinvm();     
                    List<Signin> signin_ = signinvms.signin_get_signin_data("admin", "admin", 1009);
                    if (signin_.Count != 0)
                    {
                        int loginFlag = 0;
                        if (signin_[0].UserType.Trim() == "Admin")
                        {
                            loginFlag = 1;
                        }
                        else if (signin_[0].UserType.Trim() == "Supervisor")
                        {
                            loginFlag = 1;
                        }
                        else if (signin_[0].UserType.Trim() == "User")
                        {
                            loginFlag = 1;
                        }
                        else if (signin_[0].UserType.Trim() == "Department Manager")
                        {
                            loginFlag = 1;
                        }
                        if (loginFlag == 1)
                        {
                            MessageBox.Show("success");
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}