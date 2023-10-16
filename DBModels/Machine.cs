using System;
using System.Collections.Generic;

namespace CheckTimeAttendanceManagementSoftware.DBModels
{
    public partial class Machine
    {
        public int Id { get; set; }
        public long? MachineId { get; set; } = 0;
        public string Status { get; set; } = "";
        public string ConnectType { get; set; } = "";
        public string Ip { get; set; } = "";
        public string Port { get; set; } = "";
        public string CommPassword { get; set; } = "";
        public long? ManagerCount { get; set; } = 0;
        public long? UserCount { get; set; } = 0;
        public long? FingerCount { get; set; } = 0;
        public long? SecretCount { get; set; } = 0;
        public string FirmwareVersion { get; set; } = "";
        public string SerialNo { get; set; } = "";
        public string DeviceName { get; set; } = "";
        public string DeviceType { get; set; } = "";
        public long? DeviceActivation { get; set; } = 0;
        public string ProductKey { get; set; } = "";
        public long? MachineNo { get; set; } = 0;
        public string ModelNo { get; set; } = "";
        public string Brand { get; set; } = "";
        public string ModelCode { get; set; } = "";
        public string Sdk { get; set; } = "";
        public string DeviceUsername { get; set; } = "";
        public string DevicePassword { get; set; } = "";
        public string DeviceUrl { get; set; } = "";
        public long? CId { get; set; } = 0;
        public long? ServerFlag { get; set; } = 0;
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
