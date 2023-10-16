using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Role
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public int InitializeView { get; set; } = 0;
        public int InitializeDelete { get; set; } = 0;
        public int ClearDataView { get; set; } = 0;
        public int ClearDataDelete { get; set; } = 0;
        public int BackupView { get; set; } = 0;
        public int BackupAdd { get; set; } = 0;
        public int RestoreView { get; set; } = 0;
        public int RestoreAdd { get; set; } = 0;
        public int SyncDataView { get; set; } = 0;
        public int SyncDataAdd { get; set; } = 0;
        public int USBDiskManagerView { get; set; } = 0;
        public int USBDiskManagerAdd { get; set; } = 0;
        public int LeaveView { get; set; } = 0;
        public int LeaveAdd { get; set; } = 0;
        public int LeaveEdit { get; set; } = 0;
        public int LeaveDelete { get; set; } = 0;
        public int ForgetCheckInView { get; set; } = 0;
        public int ForgetCheckInAdd { get; set; } = 0;
        public int ForgetCheckInDelete { get; set; } = 0;
        public int RemarksView { get; set; } = 0;
        public int RemarksAdd { get; set; } = 0;
        public int RemarksEdit { get; set; } = 0;
        public int RemarksDelete { get; set; } = 0;
        public int YearlyLeaveView { get; set; } = 0;
        public int YearlyLeaveAdd { get; set; } = 0;
        public int YearlyLeaveEdit { get; set; } = 0;
        public int YearlyLeaveDelete { get; set; } = 0;
        public int AllowanceView { get; set; } = 0;
        public int AllowanceAdd { get; set; } = 0;
        public int AllowanceEdit { get; set; } = 0;
        public int AllowanceDelete { get; set; } = 0;
        public int RestDayView { get; set; } = 0;
        public int RestDayAdd { get; set; } = 0;
        public int RestDayEdit { get; set; } = 0;
        public int RestDayDelete { get; set; } = 0;
        public int ApproverGroupView { get; set; } = 0;
        public int ApproverGroupAdd { get; set; } = 0;
        public int ApproverGroupEdit { get; set; } = 0;
        public int ApproverGroupDelete { get; set; } = 0;

        public int OverTimeApproverView { get; set; } = 0;
        public int OverTimeApproverAdd { get; set; } = 0;
        public int OverTimeApproverEdit { get; set; } = 0;
        public int OverTimeApproverDelete { get; set; } = 0;

        public int LeaveApproverView { get; set; } = 0;
        public int LeaveApproverAdd { get; set; } = 0;
        public int LeaveApproverEdit { get; set; } = 0;
        public int LeaveApproverDelete { get; set; } = 0;

        public int OverTimeRuleView { get; set; } = 0;
        public int OverTimeRuleAdd { get; set; } = 0;
        public int OverTimeRuleEdit { get; set; } = 0;
        public int OverTimeRuleDelete { get; set; } = 0;

        public int OverTimeSplittingView { get; set; } = 0;
        public int OverTimeSplittingAdd { get; set; } = 0;
        public int OverTimeSplittingEdit { get; set; } = 0;
        public int OverTimeSplittingDelete { get; set; } = 0;
        public int ReportView { get; set; } = 0;
        public int DailyReportView { get; set; } = 0;
        public int DetailedReportView { get; set; } = 0;
        public int SummaryReportView { get; set; } = 0;
        public int OverTimeReportView { get; set; } = 0;
        public int LateEarlyReportView { get; set; } = 0;
        public int DailySummaryReportView { get; set; } = 0;
        public int BasicReportView { get; set; } = 0;
        public int AbsentReportView { get; set; } = 0;
        public int AllowanceReportView { get; set; } = 0;
        public int LeaveReportView { get; set; } = 0;
        public int BasicLeaveReportView { get; set; } = 0;
        public int SummaryLeaveReportView { get; set; } = 0;
        public int AnnualLeaveReportView { get; set; } = 0;
        public int InOutReportView { get; set; } = 0;
        public int OnDutyReportView { get; set; } = 0;
        public int AttendanceRecordReportView { get; set; } = 0;
        public int PunchStatusReportView { get; set; } = 0;
       
        public int TimeTableView { get; set; } = 0;
        public int TimeTableAdd { get; set; } = 0;
        public int TimeTableEdit { get; set; } = 0;
        public int TimeTableDelete { get; set; } = 0;

        public int ShiftView { get; set; } = 0;
        public int ShiftAdd { get; set; } = 0;
        public int ShiftEdit { get; set; } = 0;
        public int ShiftDelete { get; set; } = 0;

        public int ScheduleView { get; set; } = 0;
        public int ScheduleAdd { get; set; } = 0;
        public int ScheduleEdit { get; set; } = 0;
        public int ScheduleDelete { get; set; } = 0;
        public int ScheduleReportView { get; set; } = 0;

        public int OverTimeRoundingView { get; set; } = 0;
        public int OverTimeRoundingAdd { get; set; } = 0;
        public int OverTimeRoundingEdit { get; set; } = 0;
        public int OverTimeRoundingDelete { get; set; } = 0;

        public int DepartmentView { get; set; } = 0;
        public int DepartmentAdd { get; set; } = 0;
        public int DepartmentEdit { get; set; } = 0;
        public int DepartmentDelete { get; set; } = 0;

        public int DepartmentBranchView { get; set; } = 0;
        public int DepartmentBranchAdd { get; set; } = 0;
        public int DepartmentBranchEdit { get; set; } = 0;
        public int DepartmentBranchDelete { get; set; } = 0;
        public int EmployeeView { get; set; } = 0;
        public int EmployeeAdd { get; set; } = 0;
        public int EmployeeEdit { get; set; } = 0;
        public int EmployeeDelete { get; set; } = 0;
        public int AdministratorView { get; set; } = 0;
        public int AdministratorAdd { get; set; } = 0;
        public int AdministratorEdit { get; set; } = 0;
        public int AdministratorDelete { get; set; } = 0;
        public int HolidayView { get; set; } = 0;
        public int HolidayAdd { get; set; } = 0;
        public int HolidayEdit { get; set; } = 0;
        public int HolidayDelete { get; set; } = 0;
        public int LeaveCategoryView { get; set; } = 0;
        public int LeaveCategoryAdd { get; set; } = 0;
        public int LeaveCategoryEdit { get; set; } = 0;
        public int LeaveCategoryDelete { get; set; } = 0;
        public int LeaveClassView { get; set; } = 0;
        public int LeaveClassAdd { get; set; } = 0;
        public int LeaveClassEdit { get; set; } = 0;
        public int LeaveClassDelete { get; set; } = 0;

        public int PunchStateView { get; set; } = 0;
        public int PunchStateAdd { get; set; } = 0;
        public int PunchStateEdit { get; set; } = 0;
        public int PunchStateDelete { get; set; } = 0;

        public int AttendenceRuleView { get; set; } = 0;
        public int AttendenceRuleEdit { get; set; } = 0;
        public int PenaltyView { get; set; } = 0;
        public int PenaltyAdd { get; set; } = 0;
        public int PenaltyEdit { get; set; } = 0;
        public int PenaltyDelete { get; set; } = 0;
        public int DatabaseChangeView { get; set; } = 0;
        public int DatabaseChangeEdit { get; set; } = 0;
        public int SystemSettingView { get; set; } = 0;
        public int SystemSettingEdit { get; set; } = 0;
        public int ChangePasswordView { get; set; } = 0;
        public int ChangePasswordEdit { get; set; } = 0;
        public int UpdateDatabaseView { get; set; } = 0;
        public int AuditLogView { get; set; } = 0;
        public int DeviceView { get; set; } = 0;
        public int DeviceAdd { get; set; } = 0;
        public int DeviceEdit { get; set; } = 0;
        public int DeviceDelete { get; set; } = 0;
        public int ConnectView { get; set; } = 0;
        public int DisconnectView { get; set; } = 0;
        public int AttendanceLogView { get; set; } = 0;
        public int UserDownloadView { get; set; } = 0;
        public int UserDownloadAdd { get; set; } = 0;
        public int UserDownloadEdit { get; set; } = 0;
        public int UserDownloadDelete { get; set; } = 0;

        public int UserUploadView { get; set; } = 0;
        public int UserUploadAdd { get; set; } = 0;
        public int UserUploadEdit { get; set; } = 0;
        public int UserUploadDelete { get; set; } = 0;
        public int AcManagerView { get; set; } = 0;
        public int AcManagerEdit { get; set; } = 0;
        public int AcManagerDelete { get; set; } = 0;

        public int DeviceManagerView { get; set; } = 0;
        public int DeviceManagerEdit { get; set; } = 0;
        public int DeviceManagerDelete { get; set; } = 0;

        public int PayrollView { get; set; } = 0;
        public int WagesView { get; set; } = 0;
        public int? Status { get; set; } = 0;
        public int? CId { get; set; } = 0;
        public int? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;
    }
}
