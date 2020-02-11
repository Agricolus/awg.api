using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWG.Stations.handlers.Model
{
  [Table("Stations")]
  public class Station
  {
    [Key]
    public long _Id { get; set; }
    public string Id { get; set; }
    public string Type { get; private set; } = "Device";
    public string Source { get; set; }
    public Uri DataProvider { get; set; }
    public string Category { get; set; }
    public string ControlledProperty { get; set; }
    public string ControlledAsset { get; set; }
    public string Mnc { get; set; }
    public string Mcc { get; set; }
    public string MacAddress { get; set; }
    public string IpAddress { get; set; }
    public string SupportedProtocol { get; set; }
    public string Configuration { get; set; }
    public string Location { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime? DateInstalled { get; set; }
    public DateTime? DateFirstUsed { get; set; }
    public DateTime? DateManufactured { get; set; }
    public string HardwareVersion { get; set; }
    public string SoftwareVersion { get; set; }
    public string FirmwareVersion { get; set; }
    public string OsVersion { get; set; }
    public DateTime? DateLastCalibration { get; set; }
    public string SerialNumber { get; set; }
    public string Provider { get; set; }
    public string RefDeviceModel { get; set; }
    public double? BatteryLevel { get; set; }
    public double? Rssi { get; set; }
    public string DeviceState { get; set; }
    public DateTime? DateLastValueReported { get; set; }
    public string Value { get; set; }
    public DateTime DateModified { get; set; }
    public DateTime DateCreated { get; set; }
    public string Owner { get; set; }
  }
}