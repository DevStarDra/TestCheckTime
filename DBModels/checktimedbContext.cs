using System;
using System.Collections.Generic;
using CheckTimeAttendanceManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class CheckTimeDBContext : DbContext
    {
        public CheckTimeDBContext()
        {
        }

        public CheckTimeDBContext(DbContextOptions<CheckTimeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutus> Aboutus { get; set; }

        public virtual DbSet<Test> Tests { get; set; }

        public virtual DbSet<ApproverGroup> ApproverGroups { get; set; }
        public virtual DbSet<AllowanceSetting> AllowanceSettings { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<AutoSchedule> AutoSchedules { get; set; }
        public virtual DbSet<Autocount> Autocounts { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<CheckInOut> CheckInOuts { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<ClaimDetail> ClaimDetails { get; set; }
        public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentManager> DepartmentManagers { get; set; }
        public virtual DbSet<EmailSetting> EmailSettings { get; set; }
        public virtual DbSet<EmpAllowance> EmpAllowances { get; set; }
        public virtual DbSet<EmpOnDuty> EmpOnDuties { get; set; }
        public virtual DbSet<EmpOtApproval> EmpOtApprovals { get; set; }
        public virtual DbSet<EmpApproverGroup> EmpApproverGroups { get; set; }
        public virtual DbSet<EmpOtSplitting> EmpOtSplittings { get; set; }
        public virtual DbSet<EmpPenalty> EmpPenalties { get; set; }
        public virtual DbSet<EmployeeOtrule> EmployeeOtrules { get; set; }
        public virtual DbSet<FixSchedule> FixSchedules { get; set; }
        public virtual DbSet<Timezone> Timezones { get; set; }
        public virtual DbSet<FixShift> FixShifts { get; set; }
        public virtual DbSet<FixShiftDay> FixShiftDays { get; set; }
        public virtual DbSet<FixTimetable> FixTimetables { get; set; }
        public virtual DbSet<FlexSchedule> FlexSchedules { get; set; }
        public virtual DbSet<FlexShift> FlexShifts { get; set; }
        public virtual DbSet<FlexShiftDay> FlexShiftDays { get; set; }
        public virtual DbSet<FlexTimetable> FlexTimetables { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<LeaveBonu> LeaveBonus { get; set; }
        public virtual DbSet<LeaveCatagory> LeaveCatagories { get; set; }
        public virtual DbSet<LeaveClass> LeaveClasses { get; set; }
        public virtual DbSet<LeaveEntitlement> LeaveEntitlements { get; set; }
        public virtual DbSet<LeaveMonthly> LeaveMonthlies { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Lunch> Lunches { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MpayrollDatum> MpayrollData { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Otround> Otrounds { get; set; }
        public virtual DbSet<Overtimerule> Overtimerules { get; set; }
        public virtual DbSet<OvertimeSplitting> OvertimeSplittings { get; set; }
        public virtual DbSet<PastPayroll> PastPayrolls { get; set; }
        public virtual DbSet<PayrollView> PayrollViews { get; set; }
        public virtual DbSet<PenaltySetting> PenaltySettings { get; set; }
        public virtual DbSet<PunchReport> PunchReports { get; set; }
        public virtual DbSet<PunchState> PunchStates { get; set; }
        public virtual DbSet<RealtimeAttView> RealtimeAttViews { get; set; }
        public virtual DbSet<Remark> Remarks { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportTotal> ReportTotals { get; set; }
        public virtual DbSet<RestDay> RestDays { get; set; }
        public virtual DbSet<SalaryAdvancePayment> SalaryAdvancePayments { get; set; }
        public virtual DbSet<SalaryAdvanceStatement> SalaryAdvanceStatements { get; set; }
        public virtual DbSet<SalaryAllowDeductGroup> SalaryAllowDeductGroups { get; set; }
        public virtual DbSet<SalaryAllowance> SalaryAllowances { get; set; }
        public virtual DbSet<SalaryDeduction> SalaryDeductions { get; set; }
        public virtual DbSet<SalaryLoan> SalaryLoans { get; set; }
        public virtual DbSet<SalaryLoanStatement> SalaryLoanStatements { get; set; }
        public virtual DbSet<SalaryRecheck> SalaryRechecks { get; set; }
        public virtual DbSet<SalaryReport> SalaryReports { get; set; }
        public virtual DbSet<SalaryReportTotal> SalaryReportTotals { get; set; }
        public virtual DbSet<SalaryVerification> SalaryVerifications { get; set; }
        public virtual DbSet<SalaryVerificationAllowance> SalaryVerificationAllowances { get; set; }
        public virtual DbSet<SalaryVerificationDeduction> SalaryVerificationDeductions { get; set; }
        public virtual DbSet<SalaryVerified> SalaryVerifieds { get; set; }
        public virtual DbSet<ServerLog> ServerLogs { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Signin> Signins { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TemporarySchedule> TemporarySchedules { get; set; }
        public virtual DbSet<TimetableReport> TimetableReports { get; set; }
        public virtual DbSet<UserCardnoPassword> UserCardnoPasswords { get; set; }
        public virtual DbSet<UserFace> UserFaces { get; set; }
        public virtual DbSet<UserFamily> UserFamilies { get; set; }
        public virtual DbSet<UserFinger> UserFingers { get; set; }
        public virtual DbSet<UserLeave> UserLeaves { get; set; }
        public virtual DbSet<EmpLeaveApproval> EmpLeaveApprovals { get; set; }
        public virtual DbSet<UserPalm> UserPalms { get; set; }
        public virtual DbSet<UserWagesSetting> UserWagesSettings { get; set; }
        public virtual DbSet<Userinfo> Userinfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=192.168.0.192,1433;Initial Catalog=checktimev888;User ID=sohi;Password=12345678");
                    
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aboutus>(entity =>
            {
                entity.ToTable("aboutus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ServerConnectionString).HasColumnName("server_connection_string");

                entity.Property(e => e.SocialLink1).HasColumnName("social_link1");

                entity.Property(e => e.SocialLink2).HasColumnName("social_link2");

                entity.Property(e => e.SocialLink3).HasColumnName("social_link3");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.WebsiteLink).HasColumnName("website_link");
            });

            modelBuilder.Entity<Timezone>(entity =>
            {
                entity.ToTable("timezone");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.CountryCode).HasColumnName("country_code");

                entity.Property(e => e.CountryName).HasColumnName("country_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Gmt).HasColumnName("gmt");

                entity.Property(e => e.Timezone1).HasColumnName("timezone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ApproverGroup>(entity =>
            {
                entity.ToTable("approver_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NoOfLevel).HasColumnName("no_of_level");

                entity.Property(e => e.Level1Approver).HasColumnName("level1_approver");

                entity.Property(e => e.Level2Approver).HasColumnName("level2_approver");

                entity.Property(e => e.Level3Approver).HasColumnName("level3_approver");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LeaveApproval).HasColumnName("leave_approval");
                entity.Property(e => e.OtApproval).HasColumnName("ot_approval");
                entity.Property(e => e.NormalOt).HasColumnName("Normalot");
                entity.Property(e => e.RestdayOt).HasColumnName("Restdayot");
                entity.Property(e => e.HolidayOt).HasColumnName("Holidayot");
            });

            modelBuilder.Entity<Overtimerule>(entity =>
            {
                entity.ToTable("overtimerule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Normalot).HasColumnName("normalot");

                entity.Property(e => e.Normalotcheck).HasColumnName("normalotcheck");

                entity.Property(e => e.Normalworktime).HasColumnName("normalworktime");

                entity.Property(e => e.Restdayot).HasColumnName("restdayot");

                entity.Property(e => e.Restdayotcheck).HasColumnName("restdayotcheck");

                entity.Property(e => e.Restdayworktime).HasColumnName("restdayworktime");
             
                entity.Property(e => e.Holidayot).HasColumnName("holidayot");

                entity.Property(e => e.Holidayotcheck).HasColumnName("holidayotcheck");

                entity.Property(e => e.Holidayworktime).HasColumnName("holidayworktime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            });

            modelBuilder.Entity<EmployeeOtrule>(entity =>
            {
                entity.ToTable("employee_otrule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.OtruleId).HasColumnName("otrule_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            });

            modelBuilder.Entity<EmpApproverGroup>(entity =>
            {
                entity.ToTable("emp_approver_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.ApproverGroupId).HasColumnName("approver_group_id");


                entity.Property(e => e.Ondate)
                   .HasColumnType("datetime")
                   .HasColumnName("ondate");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            });

            modelBuilder.Entity<OvertimeSplitting>(entity =>
            {
                entity.ToTable("overtime_splitting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NormalotCheck).HasColumnName("normalot_check");

                entity.Property(e => e.NormalotRestotMin).HasColumnName("normalot_restot_min");
                
                entity.Property(e => e.NormalotRestotMax).HasColumnName("normalot_restot_max");
                
                entity.Property(e => e.NormalotHolidayotMin).HasColumnName("normalot_holidayot_min");

                entity.Property(e => e.NormalotHolidayotMax).HasColumnName("normalot_holidayot_max");

                entity.Property(e => e.ResttoCheck).HasColumnName("restto_check");

                entity.Property(e => e.RestotNormalotMin).HasColumnName("restot_normalot_min");

                entity.Property(e => e.RestotNormalotMax).HasColumnName("restot_normalot_max");

                entity.Property(e => e.ResttoHolidayotMin).HasColumnName("restto_holidayot_min");

                entity.Property(e => e.ResttoHolidayotMax).HasColumnName("restto_holidayot_max");

                entity.Property(e => e.HolidayotCheck).HasColumnName("holidayot_check");

                entity.Property(e => e.HolidayotNormalotMin).HasColumnName("holidayot_normalot_min");

                entity.Property(e => e.HolidayotNormalotMax).HasColumnName("holidayot_normalot_max");
                
                entity.Property(e => e.HolidayotRestotMin).HasColumnName("holidayot_restot_min");

                entity.Property(e => e.HolidayotRestotMax).HasColumnName("holidayot_restot_max");
                
                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            });

            modelBuilder.Entity<EmpOtSplitting>(entity =>
            {
                entity.ToTable("emp_ot_splitting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.OtSplittingId).HasColumnName("ot_splitting_id");


                entity.Property(e => e.Ondate)
                   .HasColumnType("datetime")
                   .HasColumnName("ondate");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            });

    

            modelBuilder.Entity<AllowanceSetting>(entity =>
            {
                entity.ToTable("allowance_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowTypeAmount).HasColumnName("allow_type_amount");

                entity.Property(e => e.AllowTypeCode).HasColumnName("allow_type_code");

                entity.Property(e => e.AllowTypeName).HasColumnName("allow_type_name");

                entity.Property(e => e.AllowanceName).HasColumnName("allowance_name");

                entity.Property(e => e.AllowanceType).HasColumnName("allowance_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("audit_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("audit_date");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.InsertBy).HasColumnName("insert_by");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<AutoSchedule>(entity =>
            {
                entity.ToTable("auto_schedule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimetableId).HasColumnName("timetable_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<Autocount>(entity =>
            {
                entity.ToTable("autocount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Absent).HasColumnName("absent");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Holiday).HasColumnName("holiday");

                entity.Property(e => e.Leave).HasColumnName("leave");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.WorkingDays).HasColumnName("working_days");

                entity.Property(e => e.WorkingHours).HasColumnName("working_hours");
            });

      
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Annswer1).HasColumnName("annswer1");

                entity.Property(e => e.Annswer2).HasColumnName("annswer2");

                entity.Property(e => e.BranchAutoId).HasColumnName("branch_auto_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.BranchName).HasColumnName("branch_name");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Question1).HasColumnName("question1");

                entity.Property(e => e.Question2).HasColumnName("question2");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UseFlag).HasColumnName("use_flag");

                entity.Property(e => e.Username).HasColumnName("username");
            });

        
            modelBuilder.Entity<CheckInOut>(entity =>
            {
                entity.ToTable("check_in_out");

                entity.HasIndex(e => new { e.BadgeNumber, e.CId, e.CheckTime }, "pk_index")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BadgeNumber).HasColumnName("badgenumber");

                entity.Property(e => e.CheckTime)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasColumnName("check_time");

                entity.Property(e => e.CheckType).HasColumnName("check_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.GpsData).HasColumnName("gps_data");

                entity.Property(e => e.MaskValue)
                    .HasColumnName("mask_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SDK).HasColumnName("sdk");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempratureValue).HasColumnName("temprature_value");

                entity.Property(e => e.VerifyCode).HasColumnName("verify_code");

                entity.Property(e => e.WorkCode).HasColumnName("work_code");
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("claim");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.ClaimCode).HasColumnName("claim_code");

                entity.Property(e => e.ClaimName).HasColumnName("claim_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ClaimDetail>(entity =>
            {
                entity.ToTable("claim_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.ClaimAmount).HasColumnName("claim_amount");

                entity.Property(e => e.ClaimApprovedByAdmin).HasColumnName("claim_approved_by_admin");

                entity.Property(e => e.ClaimApprovedByDep).HasColumnName("claim_approved_by_dep");

                entity.Property(e => e.ClaimApprovedDepManagerId).HasColumnName("claim_approved_dep_manager_id");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("datetime")
                    .HasColumnName("claim_date");

                entity.Property(e => e.ClaimImage).HasColumnName("claim_image");

                entity.Property(e => e.ClaimName).HasColumnName("claim_name");

                entity.Property(e => e.ClaimNameId).HasColumnName("claim_name_id");

                entity.Property(e => e.ClaimProjectforName).HasColumnName("claim_projectfor_name");

                entity.Property(e => e.ClaimProjectforNameId).HasColumnName("claim_projectfor_name_id");

                entity.Property(e => e.ClaimReason).HasColumnName("claim_reason");

                entity.Property(e => e.ClaimStatus).HasColumnName("claim_status");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<CompanyDetail>(entity =>
            {
                entity.ToTable("company_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name");

                entity.Property(e => e.ContactNo).HasColumnName("contactno");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmailId).HasColumnName("emailid");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag");
                  //  .HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.PersonName).HasColumnName("person_name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag");
                //    .HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

       
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

              
             
                entity.Property(e => e.Name).HasColumnName("name");

            });

      
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag");
               //     .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubDeptId).HasColumnName("sub_dept_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<DepartmentManager>(entity =>
            {
                entity.ToTable("department_manager");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CHK).HasColumnName("chk");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DepartmentManagerLevel).HasColumnName("department_manager_level");

                entity.Property(e => e.EmailId).HasColumnName("emailid");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.SelectedDepartment).HasColumnName("selected_department");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<EmailSetting>(entity =>
            {
                entity.ToTable("email_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminCheck).HasColumnName("admin_check");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CredentialsCheck).HasColumnName("credentials_check");

                entity.Property(e => e.DeptManagerCheck).HasColumnName("dept_manager_check");

                entity.Property(e => e.EmailId).HasColumnName("emailid");

                entity.Property(e => e.EmpCheck).HasColumnName("emp_check");

                entity.Property(e => e.ExtraEmail)
                    .HasColumnType("text")
                    .HasColumnName("extra_email");

                entity.Property(e => e.IP).HasColumnName("ip");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Schedule).HasColumnName("schedule");

                entity.Property(e => e.ScheduleDay).HasColumnName("schedule_day");

                entity.Property(e => e.ScheduleTime).HasColumnName("schedule_time");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SslCheck).HasColumnName("ssl_check");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<EmpAllowance>(entity =>
            {
                entity.ToTable("emp_allowance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceId).HasColumnName("allowance_id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<EmpOnDuty>(entity =>
            {
                entity.ToTable("emp_on_duty");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckIn).HasColumnName("check_in");

                entity.Property(e => e.CheckOut).HasColumnName("check_out");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_date");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<EmpOtApproval>(entity =>
            {
                entity.ToTable("emp_ot_approval");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproveStatus).HasColumnName("approve_status");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_date");

                entity.Property(e => e.Level1ApproveStatus).HasColumnName("level1_approve_status");

                entity.Property(e => e.Level1Approveby).HasColumnName("level1_approveby");

                entity.Property(e => e.Level2ApproveStatus).HasColumnName("level2_approve_status");

                entity.Property(e => e.Level2Approveby).HasColumnName("level2_approveby");

                entity.Property(e => e.Level3ApproveStatus).HasColumnName("level3_approve_status");

                entity.Property(e => e.Level3Approveby).HasColumnName("level3_approveby");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserOvertimeMin).HasColumnName("user_overtime_min");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.NoOfLevel).HasColumnName("no_of_level");

                entity.Property(e => e.ApproverGroupId).HasColumnName("approver_group_id");
                entity.Property(e => e.NotesApprover1).HasColumnName("notes_approver1");
                entity.Property(e => e.NotesApprover2).HasColumnName("notes_approver2");
                entity.Property(e => e.NotesApprover3).HasColumnName("notes_approver3");
            });

            modelBuilder.Entity<EmpPenalty>(entity =>
            {
                entity.ToTable("emp_penalty");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PenaltyId).HasColumnName("penalty_id");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<FixSchedule>(entity =>
            {
                entity.ToTable("fix_schedule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.FixShiftId).HasColumnName("fix_shift_id");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<FixShift>(entity =>
            {
                entity.ToTable("fix_shift");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlternateSatCheck).HasColumnName("alternate_sat_check");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.FifthSat).HasColumnName("fifth_sat");

                entity.Property(e => e.FirstSat).HasColumnName("first_sat");

                entity.Property(e => e.FourthSat).HasColumnName("fourth_sat");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SecondSat).HasColumnName("second_sat");

                entity.Property(e => e.SelectedId).HasColumnName("selected_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.ThirdSat).HasColumnName("third_sat");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<FixShiftDay>(entity =>
            {
                entity.ToTable("fix_shift_days");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FixShiftId).HasColumnName("fix_shift_id");

                entity.Property(e => e.FixTimetableId).HasColumnName("fix_timetable_id");

                entity.Property(e => e.RestDayCheck).HasColumnName("rest_day_check");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<FixTimetable>(entity =>
            {
                entity.ToTable("fix_timetable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdvanceRuleCheck).HasColumnName("advance_rule_check");

                entity.Property(e => e.BeginningIn).HasColumnName("beginning_in");

                entity.Property(e => e.BeginningOut).HasColumnName("beginning_out");

                entity.Property(e => e.Break1DeductOption).HasColumnName("break1_deduct_option");

                entity.Property(e => e.Break1End).HasColumnName("break1_end");

                entity.Property(e => e.Break1Max).HasColumnName("break1_max");

                entity.Property(e => e.Break1OptionCheck).HasColumnName("break1_option_check");

                entity.Property(e => e.Break1Start).HasColumnName("break1_start");

                entity.Property(e => e.Break2Check).HasColumnName("break2_check");

                entity.Property(e => e.Break2DeductOption).HasColumnName("break2_deduct_option");

                entity.Property(e => e.Break2End).HasColumnName("break2_end");

                entity.Property(e => e.Break2Max).HasColumnName("break2_max");

                entity.Property(e => e.Break2OptionCheck).HasColumnName("break2_option_check");

                entity.Property(e => e.Break2Start).HasColumnName("break2_start");

                entity.Property(e => e.Break3Check).HasColumnName("break3_check");

                entity.Property(e => e.Break3DeductOption).HasColumnName("break3_deduct_option");

                entity.Property(e => e.Break3End).HasColumnName("break3_end");

                entity.Property(e => e.Break3Max).HasColumnName("break3_max");

                entity.Property(e => e.Break3OptionCheck).HasColumnName("break3_option_check");

                entity.Property(e => e.Break3Start).HasColumnName("break3_start");

                entity.Property(e => e.Break4Check).HasColumnName("break4_check");

                entity.Property(e => e.Break4DeductOption).HasColumnName("break4_deduct_option");

                entity.Property(e => e.Break4End).HasColumnName("break4_end");

                entity.Property(e => e.Break4Max).HasColumnName("break4_max");

                entity.Property(e => e.Break4OptionCheck).HasColumnName("break4_option_check");

                entity.Property(e => e.Break4Start).HasColumnName("break4_start");

                entity.Property(e => e.BreakBeforeOtCheck).HasColumnName("break_before_ot_check");

                entity.Property(e => e.BreakBeforeOtMin).HasColumnName("break_before_ot_min");

                entity.Property(e => e.BreakCheck).HasColumnName("break_check");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EarlyDeductOption).HasColumnName("early_deduct_option");

                entity.Property(e => e.EndingIn).HasColumnName("ending_in");

                entity.Property(e => e.EndingOut).HasColumnName("ending_out");

                entity.Property(e => e.LateDeductOption).HasColumnName("late_deduct_option");

                entity.Property(e => e.LateTimeAllow).HasColumnName("late_time_allow");

                entity.Property(e => e.LeaveEarlyAllow).HasColumnName("leave_early_allow");

                entity.Property(e => e.MaxOt).HasColumnName("max_ot");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OffDutyTime).HasColumnName("off_duty_time");

                entity.Property(e => e.OnDutyTime).HasColumnName("on_duty_time");

                entity.Property(e => e.Ot1Check).HasColumnName("ot1_check");

                entity.Property(e => e.Ot1Value).HasColumnName("ot1_value");

                entity.Property(e => e.Ot2Check).HasColumnName("ot2_check");

                entity.Property(e => e.Ot2Value).HasColumnName("ot2_value");

                entity.Property(e => e.Ot3Check).HasColumnName("ot3_check");

                entity.Property(e => e.Ot3Value).HasColumnName("ot3_value");

                entity.Property(e => e.OtBeforeWork).HasColumnName("ot_before_work");

                entity.Property(e => e.OtBeforeWorkMinuteMax).HasColumnName("ot_before_work_minute_max");

                entity.Property(e => e.OtBeforeWorkMinuteMin).HasColumnName("ot_before_work_minute_min");

                entity.Property(e => e.RoundOption).HasColumnName("round_option");
    
                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<FlexSchedule>(entity =>
            {
                entity.ToTable("flex_schedule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.FlexShiftId).HasColumnName("flex_shift_id");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<FlexShift>(entity =>
            {
                entity.ToTable("flex_shift");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<FlexShiftDay>(entity =>
            {
                entity.ToTable("flex_shift_days");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FlexShiftId).HasColumnName("flex_shift_id");

                entity.Property(e => e.FlexTimetableId).HasColumnName("flex_timetable_id");

                entity.Property(e => e.RestDayCheck).HasColumnName("rest_day_check");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<FlexTimetable>(entity =>
            {
                entity.ToTable("flex_timetable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Break1DeductOption).HasColumnName("break1_deduct_option");

                entity.Property(e => e.Break1End).HasColumnName("break1_end");

                entity.Property(e => e.Break1Max).HasColumnName("break1_max");

                entity.Property(e => e.Break1OptionCheck).HasColumnName("break1_option_check");

                entity.Property(e => e.Break1Start).HasColumnName("break1_start");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Color)
                    .HasColumnType("text")
                    .HasColumnName("color");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MaxOt).HasColumnName("max_ot");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OffDutyTime).HasColumnName("off_duty_time");

                entity.Property(e => e.OnDutyTime).HasColumnName("on_duty_time");

                entity.Property(e => e.Ot1Check).HasColumnName("ot1_check");

                entity.Property(e => e.Ot1Value).HasColumnName("ot1_value");

                entity.Property(e => e.Ot2Check).HasColumnName("ot2_check");

                entity.Property(e => e.Ot2Value).HasColumnName("ot2_value");

                entity.Property(e => e.Ot3Check).HasColumnName("ot3_check");

                entity.Property(e => e.Ot3Value).HasColumnName("ot3_value");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.WorkHourMin).HasColumnName("work_hour_min");

                entity.Property(e => e.WorktimeRule).HasColumnName("worktime_rule");

                entity.Property(e => e.RoundOption).HasColumnName("round_option");

                entity.Property(e => e.AdvanceRuleCheck).HasColumnName("advance_rule_check");
                entity.Property(e => e.CheckFlexBeginningIn).HasColumnName("check_flex_beginning_in");
                entity.Property(e => e.FlexBeginningIn).HasColumnName("flex_beginning_in");
            });

      
            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("holiday");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.HolidayName).HasColumnName("holiday_name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<LeaveBonu>(entity =>
            {
                entity.ToTable("leave_bonus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("date")
                    .HasColumnName("leave_date");

                entity.Property(e => e.LeaveYear).HasColumnName("leave_year");

                entity.Property(e => e.NoOfLeave).HasColumnName("no_of_leave");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<LeaveCatagory>(entity =>
            {
                entity.ToTable("leave_catagory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Catagory).HasColumnName("catagory");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<LeaveClass>(entity =>
            {
                entity.ToTable("leave_class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.LeaveCatagoryId).HasColumnName("leave_catagory_id");
                entity.Property(e => e.LeaveCatagoryName).HasColumnName("leave_catagory_name");

                entity.Property(e => e.LeaveName).HasColumnName("leave_name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<LeaveEntitlement>(entity =>
            {
                entity.ToTable("leave_entitlement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarryLeaveCheck).HasColumnName("carry_leave_check");

                entity.Property(e => e.CatagoryId).HasColumnName("catagory_id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("date")
                    .HasColumnName("leave_date");

                entity.Property(e => e.LeaveYear).HasColumnName("leave_year");

                entity.Property(e => e.NoOfCarryLeave).HasColumnName("no_of_carry_leave");

                entity.Property(e => e.NoOfLeave).HasColumnName("no_of_leave");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<LeaveMonthly>(entity =>
            {
                entity.ToTable("leave_monthly");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatagoryId).HasColumnName("catagory_id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("date")
                    .HasColumnName("leave_date");

                entity.Property(e => e.LeaveYear).HasColumnName("leave_year");

                entity.Property(e => e.NoOfLeave).HasColumnName("no_of_leave");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

        
            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComapnyAddress).HasColumnName("comapny_address");

                entity.Property(e => e.ComapnyName).HasColumnName("comapny_name");

                entity.Property(e => e.CompanyWebsite).HasColumnName("company_website");

                entity.Property(e => e.Contactno).HasColumnName("contactno");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Emailid).HasColumnName("emailid");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<Lunch>(entity =>
            {
                entity.ToTable("lunch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Minute).HasColumnName("minute");

                entity.Property(e => e.RestTime).HasColumnName("rest_time");

                entity.Property(e => e.ServerFlag).HasColumnName("server_flag");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TotalLeave).HasColumnName("total_leave");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.ToTable("machine");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand).HasColumnName("brand");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CommPassword).HasColumnName("comm_password");

                entity.Property(e => e.ConnectType).HasColumnName("connect_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DeviceActivation).HasColumnName("device_activation");

                entity.Property(e => e.DeviceName).HasColumnName("device_name");

                entity.Property(e => e.DevicePassword).HasColumnName("device_password");

                entity.Property(e => e.DeviceType).HasColumnName("device_type");

                entity.Property(e => e.DeviceUrl).HasColumnName("device_url");

                entity.Property(e => e.DeviceUsername).HasColumnName("device_username");

                entity.Property(e => e.FingerCount).HasColumnName("finger_count");

                entity.Property(e => e.FirmwareVersion).HasColumnName("firmware_version");

                entity.Property(e => e.Ip).HasColumnName("ip");

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.MachineNo).HasColumnName("machine_no");

                entity.Property(e => e.ManagerCount).HasColumnName("manager_count");

                entity.Property(e => e.ModelCode).HasColumnName("model_code");

                entity.Property(e => e.ModelNo)
                    .HasColumnType("text")
                    .HasColumnName("model_no");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.ProductKey).HasColumnName("product_key");

                entity.Property(e => e.Sdk).HasColumnName("sdk");

                entity.Property(e => e.SecretCount).HasColumnName("secret_count");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.ServerFlag).HasColumnName("server_flag");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserCount).HasColumnName("user_count");
            });

            modelBuilder.Entity<MpayrollDatum>(entity =>
            {
                entity.ToTable("mpayroll_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Absence).HasColumnName("absence");

                entity.Property(e => e.AnnualLeave).HasColumnName("annual_leave");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CompassionateLeave).HasColumnName("compassionate_leave");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DaysWorked).HasColumnName("days_worked");

                entity.Property(e => e.EarlyDeparture).HasColumnName("early_departure");

                entity.Property(e => e.ExaminationLeave).HasColumnName("examination_leave");

                entity.Property(e => e.HospitalLeave).HasColumnName("hospital_leave");

                entity.Property(e => e.HoursWorked).HasColumnName("hours_worked");

                entity.Property(e => e.Lateness).HasColumnName("lateness");

                entity.Property(e => e.LineShutdownLeave).HasColumnName("line_shutdown_leave");

                entity.Property(e => e.MarriageLeave).HasColumnName("marriage_leave");

                entity.Property(e => e.MaternityLeave).HasColumnName("maternity_leave");

                entity.Property(e => e.MedicalLeave).HasColumnName("medical_leave");

                entity.Property(e => e.NoPayHour).HasColumnName("no_pay_hour");

                entity.Property(e => e.NonPayLeave).HasColumnName("non_pay_leave");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.Ot4).HasColumnName("ot4");

                entity.Property(e => e.Ot5).HasColumnName("ot5");

                entity.Property(e => e.Ot6).HasColumnName("ot6");

                entity.Property(e => e.OutOfBound).HasColumnName("out_of_bound");

                entity.Property(e => e.PaternityLeave).HasColumnName("paternity_leave");

                entity.Property(e => e.PayId).HasColumnName("pay_id");

                entity.Property(e => e.PublicHoliday).HasColumnName("public_holiday");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notification");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiDepartmentFlag).HasColumnName("api_department_flag");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("current_date");

                entity.Property(e => e.CurrentTime).HasColumnName("current_time");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmpName).HasColumnName("emp_name");

                entity.Property(e => e.SelectedId).HasColumnName("selected_id");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<Otround>(entity =>
            {
                entity.ToTable("otround");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ot1roundtype).HasColumnName("ot1roundtype");

                entity.Property(e => e.Ot1roundvalue).HasColumnName("ot1roundvalue");

                entity.Property(e => e.Ot2roundtype).HasColumnName("ot2roundtype");

                entity.Property(e => e.Ot2roundvalue).HasColumnName("ot2roundvalue");

                entity.Property(e => e.Ot3roundtype).HasColumnName("ot3roundtype");

                entity.Property(e => e.Ot3roundvalue).HasColumnName("ot3roundvalue");

                entity.Property(e => e.Otname).HasColumnName("otname");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PastPayroll>(entity =>
            {
                entity.ToTable("past_payroll");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<PayrollView>(entity =>
            {
                entity.ToTable("payroll_view");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActpayCheck)
                    .HasColumnName("actpay_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AutocountCheck)
                    .HasColumnName("autocount_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BossnetCheck)
                    .HasColumnName("bossnet_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FtpCheck)
                    .HasColumnName("ftp_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hr2000Check)
                    .HasColumnName("hr2000_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HrmsCheck)
                    .HasColumnName("hrms_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HrmsflexiCheck)
                    .HasColumnName("hrmsflexi_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MCheck)
                    .HasColumnName("m_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MillionCheck)
                    .HasColumnName("million_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PandaCheck)
                    .HasColumnName("panda_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RymnetCheck)
                    .HasColumnName("rymnet_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlCheck)
                    .HasColumnName("sql_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TdCheck)
                    .HasColumnName("td_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UbslCheck)
                    .HasColumnName("ubsl_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PenaltySetting>(entity =>
            {
                entity.ToTable("penalty_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbsentContinue).HasColumnName("absent_continue");

                entity.Property(e => e.AbsentDays).HasColumnName("absent_days");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MaxDeduct).HasColumnName("max_deduct");

                entity.Property(e => e.PenaltyCode).HasColumnName("penalty_code");

                entity.Property(e => e.PenaltyDate)
                    .HasColumnType("date")
                    .HasColumnName("penalty_date");

                entity.Property(e => e.PenaltyDeduct).HasColumnName("penalty_deduct");

                entity.Property(e => e.PenaltyDedutFrom).HasColumnName("penalty_dedut_from");

                entity.Property(e => e.PenaltyFrom).HasColumnName("penalty_from");

                entity.Property(e => e.PenaltyId).HasColumnName("penalty_id");

                entity.Property(e => e.PenaltyName).HasColumnName("penalty_name");

                entity.Property(e => e.PenaltyTo).HasColumnName("penalty_to");

                entity.Property(e => e.PenaltyType).HasColumnName("penalty_type");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PunchReport>(entity =>
            {
                entity.ToTable("punch_report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.BreakIn).HasColumnName("break_in");

                entity.Property(e => e.BreakOut).HasColumnName("break_out");

                entity.Property(e => e.CheckIn).HasColumnName("check_in");

                entity.Property(e => e.CheckOut).HasColumnName("check_out");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("current_date");

                entity.Property(e => e.DinnerIn).HasColumnName("dinner_in");

                entity.Property(e => e.DinnerOut).HasColumnName("dinner_out");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OtIn).HasColumnName("ot_in");

                entity.Property(e => e.OtOut).HasColumnName("ot_out");

                entity.Property(e => e.Overtime).HasColumnName("overtime");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.TotalDays).HasColumnName("total_days");

                entity.Property(e => e.TotalOvertime).HasColumnName("total_overtime");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.TotalWorkTime).HasColumnName("total_work_time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PunchState>(entity =>
            {
                entity.ToTable("punch_state");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PunchId).HasColumnName("punch_id");

                entity.Property(e => e.PunchName).HasColumnName("punch_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<RealtimeAttView>(entity =>
            {
                entity.ToTable("realtime_att_view");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasColumnName("check_time");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("current_date");

                entity.Property(e => e.EmpName).HasColumnName("emp_name");

                entity.Property(e => e.MachineNo).HasColumnName("machine_no");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");
            });

            modelBuilder.Entity<Remark>(entity =>
            {
                entity.ToTable("remarks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Desc).HasColumnName("desc");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualDays).HasColumnName("actual_days");

                entity.Property(e => e.ActualOt1).HasColumnName("actual_ot1");

                entity.Property(e => e.ActualOt2).HasColumnName("actual_ot2");
              
                entity.Property(e => e.ActualOt3).HasColumnName("actual_ot3");

                entity.Property(e => e.AllowanceCode).HasColumnName("allowance_code");

                entity.Property(e => e.AllowanceName).HasColumnName("allowance_name");
                entity.Property(e => e.AllowanceType).HasColumnName("allowance_type");

                entity.Property(e => e.AppliedOt1).HasColumnName("applied_ot1");

                entity.Property(e => e.AppliedOt2).HasColumnName("applied_ot2");

                entity.Property(e => e.AppliedOt3).HasColumnName("applied_ot3");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.BonusPoint).HasColumnName("bonus_point");

                entity.Property(e => e.Break1In).HasColumnName("break1_in");

                entity.Property(e => e.Break1MaxTime).HasColumnName("break1_max_time");

                entity.Property(e => e.Break1Out).HasColumnName("break1_out");

                entity.Property(e => e.Break1RemainingTime).HasColumnName("break1_remaining_time");

                entity.Property(e => e.Break1Time).HasColumnName("break1_time");

                entity.Property(e => e.Break2In).HasColumnName("break2_in");

                entity.Property(e => e.Break2MaxTime).HasColumnName("break2_max_time");

                entity.Property(e => e.Break2Out).HasColumnName("break2_out");

                entity.Property(e => e.Break2RemainingTime).HasColumnName("break2_remaining_time");

                entity.Property(e => e.Break2Time).HasColumnName("break2_time");

                entity.Property(e => e.Break3In).HasColumnName("break3_in");

                entity.Property(e => e.Break3MaxTime).HasColumnName("break3_max_time");

                entity.Property(e => e.Break3Out).HasColumnName("break3_out");

                entity.Property(e => e.Break3RemainingTime).HasColumnName("break3_remaining_time");

                entity.Property(e => e.Break3Time).HasColumnName("break3_time");

                entity.Property(e => e.Break4In).HasColumnName("break4_in");

                entity.Property(e => e.Break4MaxTime).HasColumnName("break4_max_time");

                entity.Property(e => e.Break4Out).HasColumnName("break4_out");

                entity.Property(e => e.Break4RemainingTime).HasColumnName("break4_remaining_time");

                entity.Property(e => e.Break4Time).HasColumnName("break4_time");

                entity.Property(e => e.CheckIn).HasColumnName("check_in");

                entity.Property(e => e.CheckIn2).HasColumnName("check_in2");

                entity.Property(e => e.CheckIn3).HasColumnName("check_in3");

                entity.Property(e => e.CheckIn4).HasColumnName("check_in4");

                entity.Property(e => e.CheckInTemprature).HasColumnName("check_in_temprature");

                entity.Property(e => e.CheckOut).HasColumnName("check_out");

                entity.Property(e => e.CheckOut2).HasColumnName("check_out2");

                entity.Property(e => e.CheckOut3).HasColumnName("check_out3");

                entity.Property(e => e.CheckOut4).HasColumnName("check_out4");

                entity.Property(e => e.CheckOutTemprature).HasColumnName("check_out_temprature");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("current_date");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Early).HasColumnName("early");

                entity.Property(e => e.EarlyPenalty).HasColumnName("early_penalty");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.HolidayName).HasColumnName("holiday_name");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.LatePenalty).HasColumnName("late_penalty");

                entity.Property(e => e.LeaveCode).HasColumnName("leave_code");

                entity.Property(e => e.LeaveName).HasColumnName("leave_name");

                entity.Property(e => e.LeaveUnit).HasColumnName("leave_unit");

                entity.Property(e => e.LessHour).HasColumnName("less_hour");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot1Salary).HasColumnName("ot1_salary");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot2Salary).HasColumnName("ot2_salary");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.Ot3Salary).HasColumnName("ot3_salary");

                entity.Property(e => e.OtApproveStatus).HasColumnName("ot_approve_status");

                entity.Property(e => e.OtApprovedBy).HasColumnName("ot_approved_by");

                entity.Property(e => e.RemainOt1).HasColumnName("remain_ot1");

                entity.Property(e => e.RemainOt2).HasColumnName("remain_ot2");

                entity.Property(e => e.RemainOt3).HasColumnName("remain_ot3");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.ScheduleDays).HasColumnName("schedule_days");

                entity.Property(e => e.ScheduleHour).HasColumnName("schedule_hour");

                entity.Property(e => e.ScheduleIn).HasColumnName("schedule_in");

                entity.Property(e => e.ScheduleName).HasColumnName("schedule_name");

                entity.Property(e => e.ScheduleOut).HasColumnName("schedule_out");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.SumBasicOt).HasColumnName("sum_basic_ot");

                entity.Property(e => e.TimeStatus).HasColumnName("time_status");

                entity.Property(e => e.TotalHour).HasColumnName("total_hour");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.WorkStatus).HasColumnName("work_status");

                entity.Property(e => e.WorkTimeSalary).HasColumnName("work_time_salary");

                entity.Property(e => e.NepaliDate).HasColumnName("nepali_date");
                entity.Property(e => e.CurrentDay).HasColumnName("current_day");
                entity.Property(e => e.LatePenaltyCode).HasColumnName("late_penalty_code");
                entity.Property(e => e.EarlyPenaltyCode).HasColumnName("early_penalty_code");
                entity.Property(e => e.LatePenaltyName).HasColumnName("late_penalty_name");
                entity.Property(e => e.EarlyPenaltyName).HasColumnName("early_penalty_name");
                entity.Property(e => e.OtsplittingName).HasColumnName("otsplitting_name");
                entity.Property(e => e.OtroundName).HasColumnName("otround_name");
                entity.Property(e => e.OtruleName).HasColumnName("otrule_name");
                entity.Property(e => e.OtruleCode).HasColumnName("otrule_code");
                entity.Property(e => e.AllowanceAmount).HasColumnName("allowance_amount");
                entity.Property(e => e.ScheduleDeduction).HasColumnName("schedule_deduction");
                entity.Property(e => e.PayId).HasColumnName("pay_id");
                entity.Property(e => e.LeavePaidUnpaid).HasColumnName("leave_paid_unpaid");
                entity.Property(e => e.Ot1Code).HasColumnName("ot1_code");
                entity.Property(e => e.Ot2Code).HasColumnName("ot2_code");
                entity.Property(e => e.Ot3Code).HasColumnName("ot3_code");
            });

            modelBuilder.Entity<ReportTotal>(entity =>
            {
                entity.ToTable("report_total");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Absent).HasColumnName("absent");

                entity.Property(e => e.AnnualLeave).HasColumnName("annual_leave");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CompanyAddress).HasColumnName("company_address");

                entity.Property(e => e.CompanyName).HasColumnName("company_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Early).HasColumnName("early");

                entity.Property(e => e.EarlyPenaltyTotal).HasColumnName("early_penalty_total");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Holiday).HasColumnName("holiday");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.LatePenaltyTotal).HasColumnName("late_penalty_total");

                entity.Property(e => e.Leave).HasColumnName("leave");

                entity.Property(e => e.LessHourTotal).HasColumnName("less_hour_total");

                entity.Property(e => e.LessHourTotalDays).HasColumnName("less_hour_total_days");

                entity.Property(e => e.MaternityLeave).HasColumnName("maternity_leave");

                entity.Property(e => e.MedicalLeave).HasColumnName("medical_leave");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.PresentDays).HasColumnName("present_days");

                entity.Property(e => e.ScheduleName).HasColumnName("schedule_name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.SumOt).HasColumnName("sum_ot");

               

                entity.Property(e => e.TotalNormalHour).HasColumnName("total_normal_hour");

                entity.Property(e => e.TotalPaidLeave).HasColumnName("total_paid_leave");

                entity.Property(e => e.TotalSalary).HasColumnName("total_salary");

                entity.Property(e => e.TotalSchHour).HasColumnName("total_sch_hour");

                entity.Property(e => e.TotalScheduleDay).HasColumnName("total_schedule_day");

                entity.Property(e => e.TotalUnpaidLeave).HasColumnName("total_unpaid_leave");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
                entity.Property(e => e.TotalScheduleDeduction).HasColumnName("total_schedule_deduction");
                entity.Property(e => e.Break1Total).HasColumnName("break1_total");
                entity.Property(e => e.Break2Total).HasColumnName("break2_total");
                entity.Property(e => e.Break3Total).HasColumnName("break3_total");
                entity.Property(e => e.Break4Total).HasColumnName("break4_total");
                entity.Property(e => e.Break1MaxTotal).HasColumnName("break1_max_total");
                entity.Property(e => e.Break2MaxTotal).HasColumnName("break2_max_total");
                entity.Property(e => e.Break3MaxTotal).HasColumnName("break3_max_total");
                entity.Property(e => e.Break4MaxTotal).HasColumnName("break4_max_total");
                entity.Property(e => e.NepaliFlag).HasColumnName("nepali_flag");
                entity.Property(e => e.AllowanceTimetableNo).HasColumnName("allowance_timetable_no");
                entity.Property(e => e.AllowanceTimetableAmount).HasColumnName("allowance_timetable_amount");
                entity.Property(e => e.AllowanceDaysNo).HasColumnName("allowance_days_no");
                entity.Property(e => e.AllowanceDaysAmount).HasColumnName("allowance_days_amount");
                entity.Property(e => e.AllowanceHourNo).HasColumnName("allowance_hour_no");
                entity.Property(e => e.AllowanceHourAmount).HasColumnName("allowance_hour_amount");
                entity.Property(e => e.AllowanceEarlyNo).HasColumnName("allowance_early_no");
                entity.Property(e => e.AllowanceEarlyAmount).HasColumnName("allowance_early_amount");
                entity.Property(e => e.AllowanceOvertimeNo).HasColumnName("allowance_overtime_no");
                entity.Property(e => e.AllowanceOvertimeAmount).HasColumnName("allowance_overtime_amount");
                entity.Property(e => e.PayId).HasColumnName("pay_id");
                entity.Property(e => e.nepali_start_date).HasColumnName("nepali_start_date");
                entity.Property(e => e.nepali_end_date).HasColumnName("nepali_end_date");
            });

            modelBuilder.Entity<RestDay>(entity =>
            {
                entity.ToTable("rest_day");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RestDate)
                    .HasColumnType("date")
                    .HasColumnName("rest_date");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<SalaryAdvancePayment>(entity =>
            {
                entity.ToTable("salary_advance_payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<SalaryAdvanceStatement>(entity =>
            {
                entity.ToTable("salary_advance_statement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.DueBalance).HasColumnName("due_balance");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SalaryAllowDeductGroup>(entity =>
            {
                entity.ToTable("salary_allow_deduct_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowDeductId).HasColumnName("allow_deduct_id");

                entity.Property(e => e.AllowDeductType).HasColumnName("allow_deduct_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SalaryAllowance>(entity =>
            {
                entity.ToTable("salary_allowance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountType).HasColumnName("amount_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SalaryDeduction>(entity =>
            {
                entity.HasKey(e => new { e.Id });

                entity.ToTable("salary_deduction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountType).HasColumnName("amount_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<SalaryLoan>(entity =>
            {
                entity.ToTable("salary_loan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Emi).HasColumnName("emi");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<SalaryLoanStatement>(entity =>
            {
                entity.ToTable("salary_loan_statement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.DueBalance).HasColumnName("due_balance");

                entity.Property(e => e.Emi).HasColumnName("emi");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SalaryRecheck>(entity =>
            {
                entity.ToTable("salary_recheck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceAmount).HasColumnName("allowance_amount");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.PaidLeave).HasColumnName("paid_leave");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalHour).HasColumnName("total_hour");

                entity.Property(e => e.UnpaidLeave).HasColumnName("unpaid_leave");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<SalaryReport>(entity =>
            {
                entity.ToTable("salary_report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualDays).HasColumnName("actual_days");

                entity.Property(e => e.ActualOt1).HasColumnName("actual_ot1");

                entity.Property(e => e.AllowanceCode).HasColumnName("allowance_code");

                entity.Property(e => e.AllowanceCodeName).HasColumnName("allowance_code_name");

                entity.Property(e => e.AppliedOt1).HasColumnName("applied_ot1");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.BonusPoint).HasColumnName("bonus_point");

                entity.Property(e => e.Break1In).HasColumnName("break1_in");

                entity.Property(e => e.Break1MaxTime).HasColumnName("break1_max_time");

                entity.Property(e => e.Break1Out).HasColumnName("break1_out");

                entity.Property(e => e.Break1RemainingTime).HasColumnName("break1_remaining_time");

                entity.Property(e => e.Break1Time).HasColumnName("break1_time");

                entity.Property(e => e.Break2In).HasColumnName("break2_in");

                entity.Property(e => e.Break2MaxTime).HasColumnName("break2_max_time");

                entity.Property(e => e.Break2Out).HasColumnName("break2_out");

                entity.Property(e => e.Break2RemainingTime).HasColumnName("break2_remaining_time");

                entity.Property(e => e.Break2Time).HasColumnName("break2_time");

                entity.Property(e => e.Break3In).HasColumnName("break3_in");

                entity.Property(e => e.Break3MaxTime).HasColumnName("break3_max_time");

                entity.Property(e => e.Break3Out).HasColumnName("break3_out");

                entity.Property(e => e.Break3RemainingTime).HasColumnName("break3_remaining_time");

                entity.Property(e => e.Break3Time).HasColumnName("break3_time");

                entity.Property(e => e.Break4In).HasColumnName("break4_in");

                entity.Property(e => e.Break4MaxTime).HasColumnName("break4_max_time");

                entity.Property(e => e.Break4Out).HasColumnName("break4_out");

                entity.Property(e => e.Break4RemainingTime).HasColumnName("break4_remaining_time");

                entity.Property(e => e.Break4Time).HasColumnName("break4_time");

                entity.Property(e => e.CheckIn).HasColumnName("check_in");

                entity.Property(e => e.CheckIn2).HasColumnName("check_in2");

                entity.Property(e => e.CheckIn3).HasColumnName("check_in3");

                entity.Property(e => e.CheckIn4).HasColumnName("check_in4");

                entity.Property(e => e.CheckInTemprature).HasColumnName("check_in_temprature");

                entity.Property(e => e.CheckOut).HasColumnName("check_out");

                entity.Property(e => e.CheckOut2).HasColumnName("check_out2");

                entity.Property(e => e.CheckOut3).HasColumnName("check_out3");

                entity.Property(e => e.CheckOut4).HasColumnName("check_out4");

                entity.Property(e => e.CheckOutTemprature).HasColumnName("check_out_temprature");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Early).HasColumnName("early");

                entity.Property(e => e.EarlyPenalty).HasColumnName("early_penalty");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.HolidayName).HasColumnName("holiday_name");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.LatePenalty).HasColumnName("late_penalty");

                entity.Property(e => e.LeaveCode).HasColumnName("leave_code");

                entity.Property(e => e.LeaveName).HasColumnName("leave_name");

                entity.Property(e => e.LeaveUnit).HasColumnName("leave_unit");

                entity.Property(e => e.LessHour).HasColumnName("less_hour");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot1Salary).HasColumnName("ot1_salary");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot2Salary).HasColumnName("ot2_salary");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.Ot3Salary).HasColumnName("ot3_salary");

                entity.Property(e => e.OtApproveStatus).HasColumnName("ot_approve_status");

                entity.Property(e => e.OtApprovedBy).HasColumnName("ot_approved_by");

                entity.Property(e => e.PastPayrollId).HasColumnName("past_payroll_id");

                entity.Property(e => e.Punch1In).HasColumnName("punch1_in");

                entity.Property(e => e.Punch1Out).HasColumnName("punch1_out");

                entity.Property(e => e.Punch1Total).HasColumnName("punch1_total");

                entity.Property(e => e.Punch2In).HasColumnName("punch2_in");

                entity.Property(e => e.Punch2Out).HasColumnName("punch2_out");

                entity.Property(e => e.Punch2Total).HasColumnName("punch2_total");

                entity.Property(e => e.Punch3In).HasColumnName("punch3_in");

                entity.Property(e => e.Punch3Out).HasColumnName("punch3_out");

                entity.Property(e => e.Punch3Total).HasColumnName("punch3_total");

                entity.Property(e => e.Punch4In).HasColumnName("punch4_in");

                entity.Property(e => e.Punch4Out).HasColumnName("punch4_out");

                entity.Property(e => e.Punch4Total).HasColumnName("punch4_total");

                entity.Property(e => e.Punch5In).HasColumnName("punch5_in");

                entity.Property(e => e.Punch5Out).HasColumnName("punch5_out");

                entity.Property(e => e.Punch5Total).HasColumnName("punch5_total");

                entity.Property(e => e.PunchAllTotal).HasColumnName("punch_all_total");

                entity.Property(e => e.RemainOt1).HasColumnName("remain_ot1");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SalaryMonth).HasColumnName("salary_month");

                entity.Property(e => e.SalaryYear).HasColumnName("salary_year");

                entity.Property(e => e.ScheduleDays).HasColumnName("schedule_days");

                entity.Property(e => e.ScheduleHour).HasColumnName("schedule_hour");

                entity.Property(e => e.ScheduleIn).HasColumnName("schedule_in");

                entity.Property(e => e.ScheduleName).HasColumnName("schedule_name");

                entity.Property(e => e.ScheduleOut).HasColumnName("schedule_out");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.SumBasicOt).HasColumnName("sum_basic_ot");

                entity.Property(e => e.TimeStatus).HasColumnName("time_status");

                entity.Property(e => e.TotalHour).HasColumnName("total_hour");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.WorkStatus).HasColumnName("work_status");

                entity.Property(e => e.WorkTimeSalary).HasColumnName("work_time_salary");
            });

            modelBuilder.Entity<SalaryReportTotal>(entity =>
            {
                entity.ToTable("salary_report_total");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Absent).HasColumnName("absent");

                entity.Property(e => e.AllowanceCode).HasColumnName("allowance_code");

                entity.Property(e => e.AllowanceTotal).HasColumnName("allowance_total");

                entity.Property(e => e.AnnualLeave).HasColumnName("annual_leave");

                entity.Property(e => e.AppliedOt1).HasColumnName("applied_ot1");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CompanyAddress).HasColumnName("company_address");

                entity.Property(e => e.CompanyName).HasColumnName("company_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Early).HasColumnName("early");

                entity.Property(e => e.EarlyPenaltyTotal).HasColumnName("early_penalty_total");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Holiday).HasColumnName("holiday");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.LatePenaltyTotal).HasColumnName("late_penalty_total");

                entity.Property(e => e.Leave).HasColumnName("leave");

                entity.Property(e => e.LessHourTotal).HasColumnName("less_hour_total");

                entity.Property(e => e.LessHourTotalDays).HasColumnName("less_hour_total_days");

                entity.Property(e => e.MaternityLeave).HasColumnName("maternity_leave");

                entity.Property(e => e.MedicalLeave).HasColumnName("medical_leave");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.PastPayrollId).HasColumnName("past_payroll_id");

                entity.Property(e => e.PresentDays).HasColumnName("present_days");

                entity.Property(e => e.SalaryMonth).HasColumnName("salary_month");

                entity.Property(e => e.SalaryYear).HasColumnName("salary_year");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.SumOt).HasColumnName("sum_ot");

                entity.Property(e => e.TotalActualDays).HasColumnName("total_actual_days");

                entity.Property(e => e.TotalAllowanceNo).HasColumnName("total_allowance_no");

                entity.Property(e => e.TotalAllowanceValue).HasColumnName("total_allowance_value");

                entity.Property(e => e.TotalNormalHour).HasColumnName("total_normal_hour");

                entity.Property(e => e.TotalOt1).HasColumnName("total_ot1");

                entity.Property(e => e.TotalPaidLeave).HasColumnName("total_paid_leave");

                entity.Property(e => e.TotalSalary).HasColumnName("total_salary");

                entity.Property(e => e.TotalSchHour).HasColumnName("total_sch_hour");

                entity.Property(e => e.TotalScheduleDay).HasColumnName("total_schedule_day");

                entity.Property(e => e.TotalUnpaidLeave).HasColumnName("total_unpaid_leave");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<SalaryVerification>(entity =>
            {
                entity.ToTable("salary_verification");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Advance).HasColumnName("advance");

                entity.Property(e => e.Allowance).HasColumnName("allowance");

                entity.Property(e => e.Basic).HasColumnName("basic");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Deduction).HasColumnName("deduction");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Loan).HasColumnName("loan");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.PaidLeave).HasColumnName("paid_leave");

                entity.Property(e => e.PastPayrollId).HasColumnName("past_payroll_id");

                entity.Property(e => e.ReportAllowance).HasColumnName("report_allowance");

                entity.Property(e => e.SalaryGroups).HasColumnName("salary_groups");

                entity.Property(e => e.SalaryRate).HasColumnName("salary_rate");

                entity.Property(e => e.SalaryUnit).HasColumnName("salary_unit");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SalaryVerificationAllowance>(entity =>
            {
                entity.ToTable("salary_verification_allowance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceAmount).HasColumnName("allowance_amount");

                entity.Property(e => e.AllowanceId).HasColumnName("allowance_id");

                entity.Property(e => e.AllowanceName).HasColumnName("allowance_name");

                entity.Property(e => e.AllowanceType).HasColumnName("allowance_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SalaryVerificationDeduction>(entity =>
            {
                entity.ToTable("salary_verification_deduction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceAmount).HasColumnName("allowance_amount");

                entity.Property(e => e.AllowanceId).HasColumnName("allowance_id");

                entity.Property(e => e.AllowanceName).HasColumnName("allowance_name");

                entity.Property(e => e.AllowanceType).HasColumnName("allowance_type");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SalaryVerified>(entity =>
            {
                entity.ToTable("salary_verified");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Advance).HasColumnName("advance");

                entity.Property(e => e.Allowance).HasColumnName("allowance");

                entity.Property(e => e.AllowanceOther1).HasColumnName("allowance_other1");

                entity.Property(e => e.AllowanceOther2).HasColumnName("allowance_other2");

                entity.Property(e => e.AllowanceOther3).HasColumnName("allowance_other3");

                entity.Property(e => e.BasicSalary).HasColumnName("basic_salary");

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Claim).HasColumnName("claim");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DeductionOther1).HasColumnName("deduction_other1");

                entity.Property(e => e.DeductionOther2).HasColumnName("deduction_other2");

                entity.Property(e => e.DeductionOther3).HasColumnName("deduction_other3");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Loan).HasColumnName("loan");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot1Salary).HasColumnName("ot1_salary");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot2Salary).HasColumnName("ot2_salary");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.Ot3Salary).HasColumnName("ot3_salary");

                entity.Property(e => e.PaidLeave).HasColumnName("paid_leave");

                entity.Property(e => e.PaidLeaveAmount).HasColumnName("paid_leave_amount");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.TotalAllowance).HasColumnName("total_allowance");

                entity.Property(e => e.TotalDays).HasColumnName("total_days");

                entity.Property(e => e.TotalDeduction).HasColumnName("total_deduction");

                entity.Property(e => e.TotalHour).HasColumnName("total_hour");

                entity.Property(e => e.TotalSalary).HasColumnName("total_salary");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<ServerLog>(entity =>
            {
                entity.ToTable("server_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PcId).HasColumnName("pc_id");

                entity.Property(e => e.ServerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("server_date");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.SubmitId).HasColumnName("submit_id");

                entity.Property(e => e.SubmitType).HasColumnName("submit_type");

                entity.Property(e => e.TableName).HasColumnName("table_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserType).HasColumnName("user_type");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackupCheck).HasColumnName("backup_check");

                entity.Property(e => e.BackupFolder).HasColumnName("backup_folder");

                entity.Property(e => e.Break1DeductionCheck).HasColumnName("break1_deduction_check");

                entity.Property(e => e.Break1DeductionSelect).HasColumnName("break1_deduction_select");

                entity.Property(e => e.ChooseLanguage).HasColumnName("choose_language");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CompanyName).HasColumnName("company_name");

                entity.Property(e => e.ConnectionDatasource).HasColumnName("connection_datasource");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.DbVersion).HasColumnName("db_version");

                entity.Property(e => e.DeleteRecord).HasColumnName("delete_record");

                entity.Property(e => e.DeviceType).HasColumnName("device_type");

                entity.Property(e => e.DownloadCheck).HasColumnName("download_check");

                entity.Property(e => e.EarlyDeductionCheck).HasColumnName("early_deduction_check");

                entity.Property(e => e.ImportCheck)
                    .HasColumnName("import_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LateDeductionCheck).HasColumnName("late_deduction_check");

                entity.Property(e => e.LeaveRule).HasColumnName("leave_rule");

                entity.Property(e => e.Leavelevel).HasColumnName("leavelevel");

                entity.Property(e => e.MultiBranchCheck).HasColumnName("multi_branch_check");

                entity.Property(e => e.NoOfEmployee).HasColumnName("no_of_employee");

                entity.Property(e => e.OnlineCheck)
                    .HasColumnName("online_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.OtInterval).HasColumnName("ot_interval");

                entity.Property(e => e.OtIntervalCheck).HasColumnName("ot_interval_check");

                entity.Property(e => e.OtRoundOption).HasColumnName("ot_round_option");

           
                entity.Property(e => e.OvertimeApprovelCheck).HasColumnName("overtime_approvel_check");

                entity.Property(e => e.OvertimeApprovelLevel).HasColumnName("overtime_approvel_level");

                entity.Property(e => e.PayrollCheck)
                    .HasColumnName("payroll_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftCheck).HasColumnName("shift_check");

                entity.Property(e => e.ShiftEndTime).HasColumnName("shift_end_time");

                entity.Property(e => e.ShiftMaxOt).HasColumnName("shift_max_ot");

                entity.Property(e => e.ShiftMinHour).HasColumnName("shift_min_hour");

                entity.Property(e => e.ShiftStartTime).HasColumnName("shift_start_time");

                entity.Property(e => e.SinglePunch).HasColumnName("single_punch");

                entity.Property(e => e.SoftwareVersion).HasColumnName("software_version");

                entity.Property(e => e.SpeakRate).HasColumnName("speak_rate");

                entity.Property(e => e.TeaBreakCheck).HasColumnName("tea_break_check");

                entity.Property(e => e.TextToSpeak).HasColumnName("text_to_speak");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UploadCheck).HasColumnName("upload_check");

                entity.Property(e => e.UploadMinutesInverval).HasColumnName("upload_minutes_inverval");

                entity.Property(e => e.ViewDate).HasColumnName("view_date");

                entity.Property(e => e.ViewDatetime).HasColumnName("view_datetime");

                entity.Property(e => e.ViewTime).HasColumnName("view_time");

                entity.Property(e => e.VoiceAge).HasColumnName("voice_age");

                entity.Property(e => e.VoiceCheck).HasColumnName("voice_check");

                entity.Property(e => e.VoiceGender).HasColumnName("voice_gender");

                entity.Property(e => e.WagesCheck).HasColumnName("wages_check");

                entity.Property(e => e.WeekendDays).HasColumnName("weekend_days");

                entity.Property(e => e.WelcomeTrial).HasColumnName("welcome_trial");

                entity.Property(e => e.WorkHourLeave).HasColumnName("work_hour_leave");

                entity.Property(e => e.NepaliCalendar).HasColumnName("nepali_calendar");
                entity.Property(e => e.TimetableId).HasColumnName("timetable_id");
                entity.Property(e => e.HolidayMerge).HasColumnName("holiday_merge");
                entity.Property(e => e.RestdayMerge).HasColumnName("restday_merge");
            });

            modelBuilder.Entity<Signin>(entity =>
            {
                entity.ToTable("signin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Contactno).HasColumnName("contactno");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Departments).HasColumnName("departments");

                entity.Property(e => e.Emailid).HasColumnName("emailid");

                entity.Property(e => e.LeaveApprove).HasColumnName("leave_approve");

                entity.Property(e => e.Levels).HasColumnName("levels");

              
                entity.Property(e => e.OtApply).HasColumnName("ot_apply");

                entity.Property(e => e.Password).HasColumnName("password");


                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag");
                 //   .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("status");


                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserType).HasColumnName("user_type");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.Property(e => e.ProcessorId).HasColumnName("processor_id");
                entity.Property(e => e.LoginFlag).HasColumnName("login_flag");
                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.InitializeView).HasColumnName("initialize_view");
                entity.Property(e => e.InitializeDelete).HasColumnName("initialize_delete");
                entity.Property(e => e.ClearDataView).HasColumnName("clear_data_view");
                entity.Property(e => e.ClearDataDelete).HasColumnName("clear_data_delete");
                entity.Property(e => e.BackupView).HasColumnName("backup_view");
                entity.Property(e => e.BackupAdd).HasColumnName("backup_add");
                entity.Property(e => e.RestoreView).HasColumnName("restore_view");
                entity.Property(e => e.RestoreAdd).HasColumnName("restore_add");
                entity.Property(e => e.SyncDataView).HasColumnName("sync_data_view");
                entity.Property(e => e.SyncDataAdd).HasColumnName("sync_data_add");
                entity.Property(e => e.USBDiskManagerView).HasColumnName("usb_disk_manager_view");
                entity.Property(e => e.USBDiskManagerAdd).HasColumnName("usb_disk_manager_add");
                entity.Property(e => e.LeaveView).HasColumnName("leave_view");
                entity.Property(e => e.LeaveAdd).HasColumnName("leave_add");
                entity.Property(e => e.LeaveEdit).HasColumnName("leave_edit");
                entity.Property(e => e.LeaveDelete).HasColumnName("leave_delete");
                entity.Property(e => e.ForgetCheckInView).HasColumnName("forget_check_in_view");
                entity.Property(e => e.ForgetCheckInAdd).HasColumnName("forget_check_in_add");
                entity.Property(e => e.ForgetCheckInDelete).HasColumnName("forget_check_in_delete");
                entity.Property(e => e.RemarksView).HasColumnName("remarks_view");
                entity.Property(e => e.RemarksAdd).HasColumnName("remarks_add");
                entity.Property(e => e.RemarksEdit).HasColumnName("remarks_edit");
                entity.Property(e => e.RemarksDelete).HasColumnName("remarks_delete");
                entity.Property(e => e.YearlyLeaveView).HasColumnName("yearly_leave_view");
                entity.Property(e => e.YearlyLeaveAdd).HasColumnName("yearly_leave_add");
                entity.Property(e => e.YearlyLeaveEdit).HasColumnName("yearly_leave_edit");
                entity.Property(e => e.YearlyLeaveDelete).HasColumnName("yearly_leave_delete");
                entity.Property(e => e.AllowanceView).HasColumnName("allowance_view");
                entity.Property(e => e.AllowanceAdd).HasColumnName("allowance_add");
                entity.Property(e => e.AllowanceEdit).HasColumnName("allowance_edit");
                entity.Property(e => e.AllowanceDelete).HasColumnName("allowance_delete");
                entity.Property(e => e.RestDayView).HasColumnName("restday_view");
                entity.Property(e => e.RestDayAdd).HasColumnName("restday_add");
                entity.Property(e => e.RestDayEdit).HasColumnName("restday_edit");
                entity.Property(e => e.RestDayDelete).HasColumnName("restday_delete");
                entity.Property(e => e.ApproverGroupView).HasColumnName("approver_group_view");
                entity.Property(e => e.ApproverGroupAdd).HasColumnName("approver_group_add");
                entity.Property(e => e.ApproverGroupEdit).HasColumnName("approver_group_edit");
                entity.Property(e => e.ApproverGroupDelete).HasColumnName("approver_group_delete");
                entity.Property(e => e.OverTimeApproverView).HasColumnName("overtime_approver_view");
                entity.Property(e => e.OverTimeApproverAdd).HasColumnName("overtime_approver_add");
                entity.Property(e => e.OverTimeApproverEdit).HasColumnName("overtime_approver_edit");
                entity.Property(e => e.OverTimeApproverDelete).HasColumnName("overtime_approver_delete");
                entity.Property(e => e.LeaveApproverView).HasColumnName("leave_approver_view");
                entity.Property(e => e.LeaveApproverAdd).HasColumnName("leave_approver_add");
                entity.Property(e => e.LeaveApproverEdit).HasColumnName("leave_approver_edit");
                entity.Property(e => e.LeaveApproverDelete).HasColumnName("leave_approver_delete");
                entity.Property(e => e.OverTimeRuleView).HasColumnName("overtime_rule_view");
                entity.Property(e => e.OverTimeRuleAdd).HasColumnName("overtime_rule_add");
                entity.Property(e => e.OverTimeRuleEdit).HasColumnName("overtime_rule_edit");
                entity.Property(e => e.OverTimeRuleDelete).HasColumnName("overtime_rule_delete");
                entity.Property(e => e.OverTimeSplittingView).HasColumnName("overtime_splitting_view");
                entity.Property(e => e.OverTimeSplittingAdd).HasColumnName("overtime_splitting_add");
                entity.Property(e => e.OverTimeSplittingEdit).HasColumnName("overtime_splitting_edit");
                entity.Property(e => e.OverTimeSplittingDelete).HasColumnName("overtime_splitting_delete");
                entity.Property(e => e.ReportView).HasColumnName("report_view");
                entity.Property(e => e.DailyReportView).HasColumnName("daily_report_view");
                entity.Property(e => e.DetailedReportView).HasColumnName("detailed_report_view");
                entity.Property(e => e.SummaryReportView).HasColumnName("summary_report_view");
                entity.Property(e => e.OverTimeReportView).HasColumnName("overtime_report_view");
                entity.Property(e => e.LateEarlyReportView).HasColumnName("late_early_report_view");
                entity.Property(e => e.DailySummaryReportView).HasColumnName("daily_summary_report_view");
                entity.Property(e => e.BasicReportView).HasColumnName("basic_report_view");
                entity.Property(e => e.AbsentReportView).HasColumnName("absent_report_view");
                entity.Property(e => e.AllowanceReportView).HasColumnName("allowance_report_view");
                entity.Property(e => e.LeaveReportView).HasColumnName("leave_report_view");
                entity.Property(e => e.BasicLeaveReportView).HasColumnName("basic_leave_report_view");
                entity.Property(e => e.SummaryLeaveReportView).HasColumnName("summary_leave_report_view");
                entity.Property(e => e.AnnualLeaveReportView).HasColumnName("annual_leave_report_view");
                entity.Property(e => e.InOutReportView).HasColumnName("in_out_report_view");
                entity.Property(e => e.OnDutyReportView).HasColumnName("on_duty_report_view");
                entity.Property(e => e.AttendanceRecordReportView).HasColumnName("attendance_record_report_view");
                entity.Property(e => e.PunchStatusReportView).HasColumnName("punch_status_report_view");
                entity.Property(e => e.TimeTableView).HasColumnName("timetable_view");
                entity.Property(e => e.TimeTableAdd).HasColumnName("timetable_add");
                entity.Property(e => e.TimeTableEdit).HasColumnName("timetable_edit");
                entity.Property(e => e.TimeTableDelete).HasColumnName("timetable_delete");
                entity.Property(e => e.ShiftView).HasColumnName("shift_view");
                entity.Property(e => e.ShiftAdd).HasColumnName("shift_add");
                entity.Property(e => e.ShiftEdit).HasColumnName("shift_edit");
                entity.Property(e => e.ShiftDelete).HasColumnName("shift_delete");
                entity.Property(e => e.ScheduleView).HasColumnName("schedule_view");
                entity.Property(e => e.ScheduleAdd).HasColumnName("schedule_add");
                entity.Property(e => e.ScheduleEdit).HasColumnName("schedule_edit");
                entity.Property(e => e.ScheduleDelete).HasColumnName("schedule_delete");
                entity.Property(e => e.ScheduleReportView).HasColumnName("schedule_report_view");
                entity.Property(e => e.OverTimeRoundingView).HasColumnName("overtime_rounding_view");
                entity.Property(e => e.OverTimeRoundingAdd).HasColumnName("overtime_rounding_add");
                entity.Property(e => e.OverTimeRoundingEdit).HasColumnName("overtime_rounding_edit");
                entity.Property(e => e.OverTimeRoundingDelete).HasColumnName("overtime_rounding_delete");
                entity.Property(e => e.DepartmentView).HasColumnName("department_view");
                entity.Property(e => e.DepartmentAdd).HasColumnName("department_add");
                entity.Property(e => e.DepartmentEdit).HasColumnName("department_edit");
                entity.Property(e => e.DepartmentDelete).HasColumnName("department_delete");
                entity.Property(e => e.DepartmentBranchView).HasColumnName("department_branch_view");
                entity.Property(e => e.DepartmentBranchAdd).HasColumnName("department_branch_add");
                entity.Property(e => e.DepartmentBranchEdit).HasColumnName("department_branch_edit");
                entity.Property(e => e.DepartmentBranchDelete).HasColumnName("department_branch_delete");
                entity.Property(e => e.EmployeeView).HasColumnName("employee_view");
                entity.Property(e => e.EmployeeAdd).HasColumnName("employee_add");
                entity.Property(e => e.EmployeeEdit).HasColumnName("employee_edit");
                entity.Property(e => e.EmployeeDelete).HasColumnName("employee_delete");
                entity.Property(e => e.AdministratorView).HasColumnName("administrator_view");
                entity.Property(e => e.AdministratorAdd).HasColumnName("administrator_add");
                entity.Property(e => e.AdministratorEdit).HasColumnName("administrator_edit");
                entity.Property(e => e.AdministratorDelete).HasColumnName("administrator_delete");
                entity.Property(e => e.HolidayView).HasColumnName("holiday_view");
                entity.Property(e => e.HolidayAdd).HasColumnName("holiday_add");
                entity.Property(e => e.HolidayEdit).HasColumnName("holiday_edit");
                entity.Property(e => e.HolidayDelete).HasColumnName("holiday_delete");
                entity.Property(e => e.LeaveCategoryView).HasColumnName("leave_category_view");
                entity.Property(e => e.LeaveCategoryAdd).HasColumnName("leave_category_add");
                entity.Property(e => e.LeaveCategoryEdit).HasColumnName("leave_category_edit");
                entity.Property(e => e.LeaveCategoryDelete).HasColumnName("leave_category_delete");
                entity.Property(e => e.LeaveClassView).HasColumnName("leave_class_view");
                entity.Property(e => e.LeaveClassAdd).HasColumnName("leave_class_add");
                entity.Property(e => e.LeaveClassEdit).HasColumnName("leave_class_edit");
                entity.Property(e => e.LeaveClassDelete).HasColumnName("leave_class_delete");
                entity.Property(e => e.PunchStateView).HasColumnName("punch_state_view");
                entity.Property(e => e.PunchStateAdd).HasColumnName("punch_state_add");
                entity.Property(e => e.PunchStateEdit).HasColumnName("punch_state_edit");
                entity.Property(e => e.PunchStateDelete).HasColumnName("punch_state_delete");

                entity.Property(e => e.AttendenceRuleView).HasColumnName("attendence_rule_view");
                entity.Property(e => e.AttendenceRuleEdit).HasColumnName("attendence_rule_edit");
                entity.Property(e => e.PenaltyView).HasColumnName("penalty_view");
                entity.Property(e => e.PenaltyAdd).HasColumnName("penalty_add");
                entity.Property(e => e.PenaltyEdit).HasColumnName("penalty_edit");
                entity.Property(e => e.PenaltyDelete).HasColumnName("penalty_delete");
                entity.Property(e => e.DatabaseChangeView).HasColumnName("database_change_view");
                entity.Property(e => e.DatabaseChangeEdit).HasColumnName("database_change_edit");
                entity.Property(e => e.SystemSettingView).HasColumnName("system_setting_view");
                entity.Property(e => e.SystemSettingEdit).HasColumnName("system_setting_edit");
                entity.Property(e => e.ChangePasswordView).HasColumnName("change_password_view");
                entity.Property(e => e.ChangePasswordEdit).HasColumnName("change_password_edit");
                entity.Property(e => e.UpdateDatabaseView).HasColumnName("update_database_view");
                entity.Property(e => e.AuditLogView).HasColumnName("audit_log_view");
                entity.Property(e => e.DeviceView).HasColumnName("device_view");
                entity.Property(e => e.DeviceAdd).HasColumnName("device_add");
                entity.Property(e => e.DeviceEdit).HasColumnName("device_edit");
                entity.Property(e => e.DeviceDelete).HasColumnName("device_delete");
                entity.Property(e => e.ConnectView).HasColumnName("connect_view");
                entity.Property(e => e.DisconnectView).HasColumnName("disconnect_view");
                entity.Property(e => e.AttendanceLogView).HasColumnName("attendance_log_view");
                entity.Property(e => e.UserDownloadView).HasColumnName("user_download_view");
                entity.Property(e => e.UserDownloadAdd).HasColumnName("user_download_add");
                entity.Property(e => e.UserDownloadEdit).HasColumnName("user_download_edit");
                entity.Property(e => e.UserDownloadDelete).HasColumnName("user_download_delete");
                entity.Property(e => e.UserUploadView).HasColumnName("user_upload_view");
                entity.Property(e => e.UserUploadAdd).HasColumnName("user_upload_add");
                entity.Property(e => e.UserUploadEdit).HasColumnName("user_upload_edit");
                entity.Property(e => e.UserUploadDelete).HasColumnName("user_upload_delete");
                entity.Property(e => e.AcManagerView).HasColumnName("acmanager_view");
                entity.Property(e => e.AcManagerEdit).HasColumnName("acmanager_edit");
                entity.Property(e => e.AcManagerDelete).HasColumnName("acmanager_delete");
                entity.Property(e => e.DeviceManagerView).HasColumnName("device_manager_view");
                entity.Property(e => e.DeviceManagerEdit).HasColumnName("device_manager_edit");
                entity.Property(e => e.DeviceManagerDelete).HasColumnName("device_manager_delete");
                entity.Property(e => e.PayrollView).HasColumnName("payroll_view");
                entity.Property(e => e.WagesView).HasColumnName("wages_view");
                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.ServerFlag)
                  .HasColumnName("server_flag")
                  .HasDefaultValueSql("((0))");


                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

            });


            modelBuilder.Entity<TemporarySchedule>(entity =>
            {
                entity.ToTable("temporary_schedule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempDate)
                    .HasColumnType("date")
                    .HasColumnName("temp_date");

                entity.Property(e => e.TimetableId).HasColumnName("timetable_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
                entity.Property(e => e.TimetableType).HasColumnName("timetable_type");
            });

            modelBuilder.Entity<TimetableReport>(entity =>
            {
                entity.ToTable("timetable_report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CheckIn).HasColumnName("check_in");

                entity.Property(e => e.CheckOut).HasColumnName("check_out");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.ColorFormat).HasColumnName("color_format");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.TempDate)
                    .HasColumnType("date")
                    .HasColumnName("temp_date");

                entity.Property(e => e.TimeTable).HasColumnName("time_table");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

        
            modelBuilder.Entity<UserCardnoPassword>(entity =>
            {
                entity.ToTable("user_cardno_password");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CardNo).HasColumnName("card_no");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Sdk).HasColumnName("sdk");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UserFace>(entity =>
            {
                entity.ToTable("user_face");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FaceId).HasColumnName("face_id");

                entity.Property(e => e.FaceUrl).HasColumnName("face_url");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.ModelData).HasColumnName("model_data");

                entity.Property(e => e.Sdk).HasColumnName("sdk");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Template).HasColumnName("template");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UserFamily>(entity =>
            {
                entity.ToTable("user_family");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.GovtId).HasColumnName("govt_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<UserFinger>(entity =>
            {
                entity.ToTable("user_finger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FingerId).HasColumnName("finger_id");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Sdk).HasColumnName("sdk");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Template).HasColumnName("template");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UserLeave>(entity =>
            {
                entity.ToTable("user_leave");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatagoryId).HasColumnName("catagory_id");
                entity.Property(e => e.CatagoryName).HasColumnName("catagory_name");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.HourForm).HasColumnName("hour_form");

                entity.Property(e => e.HourTo).HasColumnName("hour_to");

                entity.Property(e => e.LeaveClassId).HasColumnName("leave_class_id");
                entity.Property(e => e.LeaveClassName).HasColumnName("leave_class_name");

                entity.Property(e => e.LeaveUnit).HasColumnName("leave_unit");

                entity.Property(e => e.PaidUnpaid).HasColumnName("paid_unpaid");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId).HasColumnName("userid");
            });

            modelBuilder.Entity<EmpLeaveApproval>(entity =>
            {
                entity.ToTable("emp_leave_approval");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.UserId).HasColumnName("userid");
                entity.Property(e => e.StartDate)
                  .HasColumnType("date")
                  .HasColumnName("start_date");
                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");
                entity.Property(e => e.LeaveClassId).HasColumnName("leave_class_id");
                entity.Property(e => e.LeaveClassName).HasColumnName("leave_class_name");
                entity.Property(e => e.CatagoryId).HasColumnName("catagory_id");
                entity.Property(e => e.CatagoryName).HasColumnName("catagory_name");
                entity.Property(e => e.Reason).HasColumnName("reason");
                entity.Property(e => e.PaidUnpaid).HasColumnName("paid_unpaid");
                entity.Property(e => e.CId).HasColumnName("cid");
                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");
                entity.Property(e => e.LeaveUnit).HasColumnName("leave_unit");
                entity.Property(e => e.HourFrom).HasColumnName("hour_from");

                entity.Property(e => e.HourTo).HasColumnName("hour_to");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NoOfLevel).HasColumnName("no_of_level");

                entity.Property(e => e.ApproverGroupId).HasColumnName("approver_group_id");
                entity.Property(e => e.ApproveStatus).HasColumnName("approve_status");
                entity.Property(e => e.Level1ApproveStatus).HasColumnName("level1_approve_status");

                entity.Property(e => e.Level1Approveby).HasColumnName("level1_approveby");

                entity.Property(e => e.Level2ApproveStatus).HasColumnName("level2_approve_status");

                entity.Property(e => e.Level2Approveby).HasColumnName("level2_approveby");

                entity.Property(e => e.Level3ApproveStatus).HasColumnName("level3_approve_status");

                entity.Property(e => e.Level3Approveby).HasColumnName("level3_approveby");
                entity.Property(e => e.NotesApprover1).HasColumnName("notes_approver1");
                entity.Property(e => e.NotesApprover2).HasColumnName("notes_approver2");
                entity.Property(e => e.NotesApprover3).HasColumnName("notes_approver3");

                entity.Property(e => e.Approver1Date).HasColumnName("approver1_date");
                entity.Property(e => e.Approver2Date).HasColumnName("approver2_date");
                entity.Property(e => e.Approver3Date).HasColumnName("approver3_date");
            });

            modelBuilder.Entity<UserPalm>(entity =>
            {
                entity.ToTable("user_palm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DataFormat).HasColumnName("data_format");

                entity.Property(e => e.IsDuress).HasColumnName("is_duress");

                entity.Property(e => e.Sdk).HasColumnName("sdk");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TemplateData).HasColumnName("template_data");

                entity.Property(e => e.TemplateNo).HasColumnName("template_no");

                entity.Property(e => e.TemplateNoIndex).HasColumnName("template_no_index");

                entity.Property(e => e.TemplateType).HasColumnName("template_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ValidFlag).HasColumnName("valid_flag");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<UserWagesSetting>(entity =>
            {
                entity.ToTable("user_wages_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankAccount).HasColumnName("bank_account");

                entity.Property(e => e.BankName).HasColumnName("bank_name");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ifsc).HasColumnName("ifsc");

                entity.Property(e => e.MonthlyOrScheduleDay).HasColumnName("monthly_or_schedule_day");

                entity.Property(e => e.Ot1Amt).HasColumnName("ot1_amt");

                entity.Property(e => e.Ot2Amt).HasColumnName("ot2_amt");

                entity.Property(e => e.Ot3Amt).HasColumnName("ot3_amt");

                entity.Property(e => e.OtType).HasColumnName("ot_type");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransferType).HasColumnName("transfer_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserGroup).HasColumnName("user_group");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.WagesAmount).HasColumnName("wages_amount");

                entity.Property(e => e.WagesType).HasColumnName("wages_type");

                entity.Property(e => e.WagesTypeValue).HasColumnName("wages_type_value");
            });
            
            modelBuilder.Entity<Userinfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("userinfo");

                entity.Property(e => e.UserId).HasColumnName("userid");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AnnualLeave).HasColumnName("annual_leave");
           
                entity.Property(e => e.Badgenumber).HasColumnName("badgenumber");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("date")
                    .HasColumnName("birth_day")
                    .HasDefaultValueSql("('1990-01-01')");

                entity.Property(e => e.CardNo).HasColumnName("card_no");

                entity.Property(e => e.CertificateType).HasColumnName("certificate_type");

                entity.Property(e => e.CheckWorkHourLeave)
                    .HasColumnName("check_work_hour_leave")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CId).HasColumnName("cid");

                entity.Property(e => e.CitizenShip).HasColumnName("citizen_ship");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.Contactno).HasColumnName("contactno");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DeptId)
                    .HasColumnName("dept_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Emailid).HasColumnName("emailid");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.GovtId).HasColumnName("govt_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.HireDay)
                    .HasColumnType("date")
                    .HasColumnName("hire_day")
                    .HasDefaultValueSql("('1990-01-01')");

                entity.Property(e => e.HolidayCheck).HasColumnName("holiday_check");

                entity.Property(e => e.HolidayOtCheck).HasColumnName("holiday_ot_check");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.LateDeduct).HasColumnName("late_deduct");

                entity.Property(e => e.LateDeductCheck).HasColumnName("late_deduct_check");

                entity.Property(e => e.LateIn).HasColumnName("late_in");

                entity.Property(e => e.LateTo).HasColumnName("late_to");

                entity.Property(e => e.LateType).HasColumnName("late_type");

                entity.Property(e => e.LoginPassword).HasColumnName("login_password");

                entity.Property(e => e.LoginUsername).HasColumnName("login_username");

                entity.Property(e => e.MaritalStatus).HasColumnName("marital_status");

                entity.Property(e => e.MaxLateDeduct).HasColumnName("max_late_deduct");

                entity.Property(e => e.MedicalLeave).HasColumnName("medical_leave");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Nationality).HasColumnName("nationality");

                entity.Property(e => e.NormalMaxTotalOt).HasColumnName("normal_max_total_ot");

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot2).HasColumnName("ot2");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.OvertimeApproval).HasColumnName("overtime_approval");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Payid).HasColumnName("payid");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Pin).HasColumnName("pin");

                entity.Property(e => e.Privilege).HasColumnName("privilege");

                entity.Property(e => e.RestDayCheck).HasColumnName("rest_day_check");

                entity.Property(e => e.RestDayOtCheck).HasColumnName("rest_day_ot_check");

                entity.Property(e => e.Sdk).HasColumnName("sdk");

                entity.Property(e => e.Seprater).HasColumnName("seprater");

                entity.Property(e => e.ServerFlag)
                    .HasColumnName("server_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SinglePunch).HasColumnName("single_punch");

                entity.Property(e => e.SinglePunchCheck).HasColumnName("single_punch_check");

                entity.Property(e => e.Timezone1).HasColumnName("timezone1");

                entity.Property(e => e.Timezone2).HasColumnName("timezone2");

                entity.Property(e => e.Timezone3).HasColumnName("timezone3");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.VerifyFlag).HasColumnName("verify_flag");

                entity.Property(e => e.WeekendCheck).HasColumnName("weekend_check");

                entity.Property(e => e.WeekendDays).HasColumnName("weekend_days");

                entity.Property(e => e.WorkHourLeave)
                    .HasColumnName("work_hour_leave")
                    .HasDefaultValueSql("((480))");

                entity.Property(e => e.Zip).HasColumnName("zip");
            });
            
            

            modelBuilder.Entity<Signin>()
            .HasData(
                new Signin
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    UserType = "Admin",
                    Contactno = "1234567989",
                    Emailid = "admin@demo.com",
                    Status = "Active",
                    Departments = "0",
                    Levels = "none",
                    CId = 0,
                    UserId = 1,
                    ServerFlag=0
                }
            );

            modelBuilder.Entity<Department>()
                .HasData(
                    new Department
                    {
                        Id = 1,
                        DeptName = "ABCD Department",
                        CId = 0,
                        DeptId = 1,
                        SubDeptId = 0,
                        CreatedAt = new DateTime(1990, 01, 01),
                        UpdatedAt = new DateTime(1990, 01, 01),
                        ServerFlag=0
                    }
                );

            modelBuilder.Entity<CompanyDetail>()
               .HasData(
                   new CompanyDetail
                   {
                       Id = 1,
                       CompanyName = "Demo",
                       ContactNo = "0987654321",
                       EmailId = "admin@email.com",
                       Address = "address",
                       City = "city",
                       Country = "malaysia",
                       PersonName = "person",
                       Username = "admin",
                       Password = "admin",
                       State = "state",
                       Flag = 1,
                       CreatedAt = new DateTime(1990, 01, 01),
                       UpdatedAt = new DateTime(1990, 01, 01),
                       ServerFlag = 0
                   }
               );
            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
    }
}
