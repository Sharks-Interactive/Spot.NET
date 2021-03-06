// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/network_stats.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bosdyn.Api {

  /// <summary>Holder for reflection information generated from Protos/network_stats.proto</summary>
  public static partial class NetworkStatsReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/network_stats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetworkStatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90b3MvbmV0d29ya19zdGF0cy5wcm90bxIKYm9zZHluLmFwaRoeZ29v",
            "Z2xlL3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvIqsDCgtBc3NvY2lhdGlvbhIT",
            "CgttYWNfYWRkcmVzcxgBIAEoCRIxCg5jb25uZWN0ZWRfdGltZRgCIAEoCzIZ",
            "Lmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbhIVCg1yeF9zaWduYWxfZGJtGAMg",
            "ASgFEhkKEXJ4X3NpZ25hbF9hdmdfZGJtGAQgASgFEiAKGHJ4X2JlYWNvbl9z",
            "aWduYWxfYXZnX2RibRgFIAEoBRIgChhleHBlY3RlZF9iaXRzX3Blcl9zZWNv",
            "bmQYBiABKAMSEAoIcnhfYnl0ZXMYByABKAMSEgoKcnhfcGFja2V0cxgIIAEo",
            "AxIaChJyeF9iaXRzX3Blcl9zZWNvbmQYCSABKAMSEAoIdHhfYnl0ZXMYCiAB",
            "KAMSEgoKdHhfcGFja2V0cxgLIAEoAxIaChJ0eF9iaXRzX3Blcl9zZWNvbmQY",
            "DCABKAMSEgoKdHhfcmV0cmllcxgNIAEoAxIRCgl0eF9mYWlsZWQYDiABKAMS",
            "GAoQYmVhY29uc19yZWNlaXZlZBgPIAEoAxIZChFiZWFjb25fbG9zc19jb3Vu",
            "dBgQIAEoAyLWAQoKV2lmaURldmljZRIpCgR0eXBlGAEgASgOMhsuYm9zZHlu",
            "LmFwaS5XaWZpRGV2aWNlLlR5cGUSDAoEbmFtZRgCIAEoCRITCgttYWNfYWRk",
            "cmVzcxgDIAEoCRIMCgRzc2lkGAQgASgJEhQKDHR4X3Bvd2VyX2RibRgFIAEo",
            "BRItCgxhc3NvY2lhdGlvbnMYBiADKAsyFy5ib3NkeW4uYXBpLkFzc29jaWF0",
            "aW9uIicKBFR5cGUSCwoHVU5LTk9XThAAEgYKAkFQEAESCgoGQ0xJRU5UEAIi",
            "RgoJV2lmaVN0YXRzEhAKCGhvc3RuYW1lGAEgASgJEicKB2RldmljZXMYAiAD",
            "KAsyFi5ib3NkeW4uYXBpLldpZmlEZXZpY2VCE0IRTmV0d29ya1N0YXRzUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.Association), global::Bosdyn.Api.Association.Parser, new[]{ "MacAddress", "ConnectedTime", "RxSignalDbm", "RxSignalAvgDbm", "RxBeaconSignalAvgDbm", "ExpectedBitsPerSecond", "RxBytes", "RxPackets", "RxBitsPerSecond", "TxBytes", "TxPackets", "TxBitsPerSecond", "TxRetries", "TxFailed", "BeaconsReceived", "BeaconLossCount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.WifiDevice), global::Bosdyn.Api.WifiDevice.Parser, new[]{ "Type", "Name", "MacAddress", "Ssid", "TxPowerDbm", "Associations" }, null, new[]{ typeof(global::Bosdyn.Api.WifiDevice.Types.Type) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.WifiStats), global::Bosdyn.Api.WifiStats.Parser, new[]{ "Hostname", "Devices" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Association : pb::IMessage<Association> {
    private static readonly pb::MessageParser<Association> _parser = new pb::MessageParser<Association>(() => new Association());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Association> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.NetworkStatsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Association() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Association(Association other) : this() {
      macAddress_ = other.macAddress_;
      connectedTime_ = other.connectedTime_ != null ? other.connectedTime_.Clone() : null;
      rxSignalDbm_ = other.rxSignalDbm_;
      rxSignalAvgDbm_ = other.rxSignalAvgDbm_;
      rxBeaconSignalAvgDbm_ = other.rxBeaconSignalAvgDbm_;
      expectedBitsPerSecond_ = other.expectedBitsPerSecond_;
      rxBytes_ = other.rxBytes_;
      rxPackets_ = other.rxPackets_;
      rxBitsPerSecond_ = other.rxBitsPerSecond_;
      txBytes_ = other.txBytes_;
      txPackets_ = other.txPackets_;
      txBitsPerSecond_ = other.txBitsPerSecond_;
      txRetries_ = other.txRetries_;
      txFailed_ = other.txFailed_;
      beaconsReceived_ = other.beaconsReceived_;
      beaconLossCount_ = other.beaconLossCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Association Clone() {
      return new Association(this);
    }

    /// <summary>Field number for the "mac_address" field.</summary>
    public const int MacAddressFieldNumber = 1;
    private string macAddress_ = "";
    /// <summary>
    /// MAC address of the associated station
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MacAddress {
      get { return macAddress_; }
      set {
        macAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "connected_time" field.</summary>
    public const int ConnectedTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration connectedTime_;
    /// <summary>
    /// Time duration since the station last connected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration ConnectedTime {
      get { return connectedTime_; }
      set {
        connectedTime_ = value;
      }
    }

    /// <summary>Field number for the "rx_signal_dbm" field.</summary>
    public const int RxSignalDbmFieldNumber = 3;
    private int rxSignalDbm_;
    /// <summary>
    /// Signal strength of last received packet
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RxSignalDbm {
      get { return rxSignalDbm_; }
      set {
        rxSignalDbm_ = value;
      }
    }

    /// <summary>Field number for the "rx_signal_avg_dbm" field.</summary>
    public const int RxSignalAvgDbmFieldNumber = 4;
    private int rxSignalAvgDbm_;
    /// <summary>
    /// Signal strength average
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RxSignalAvgDbm {
      get { return rxSignalAvgDbm_; }
      set {
        rxSignalAvgDbm_ = value;
      }
    }

    /// <summary>Field number for the "rx_beacon_signal_avg_dbm" field.</summary>
    public const int RxBeaconSignalAvgDbmFieldNumber = 5;
    private int rxBeaconSignalAvgDbm_;
    /// <summary>
    /// Signal strength average for beacons only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RxBeaconSignalAvgDbm {
      get { return rxBeaconSignalAvgDbm_; }
      set {
        rxBeaconSignalAvgDbm_ = value;
      }
    }

    /// <summary>Field number for the "expected_bits_per_second" field.</summary>
    public const int ExpectedBitsPerSecondFieldNumber = 6;
    private long expectedBitsPerSecond_;
    /// <summary>
    /// Expected throughput
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExpectedBitsPerSecond {
      get { return expectedBitsPerSecond_; }
      set {
        expectedBitsPerSecond_ = value;
      }
    }

    /// <summary>Field number for the "rx_bytes" field.</summary>
    public const int RxBytesFieldNumber = 7;
    private long rxBytes_;
    /// <summary>
    /// Total received bytes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RxBytes {
      get { return rxBytes_; }
      set {
        rxBytes_ = value;
      }
    }

    /// <summary>Field number for the "rx_packets" field.</summary>
    public const int RxPacketsFieldNumber = 8;
    private long rxPackets_;
    /// <summary>
    /// Total received packets from the associated station
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RxPackets {
      get { return rxPackets_; }
      set {
        rxPackets_ = value;
      }
    }

    /// <summary>Field number for the "rx_bits_per_second" field.</summary>
    public const int RxBitsPerSecondFieldNumber = 9;
    private long rxBitsPerSecond_;
    /// <summary>
    /// Last unicast receive rate
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RxBitsPerSecond {
      get { return rxBitsPerSecond_; }
      set {
        rxBitsPerSecond_ = value;
      }
    }

    /// <summary>Field number for the "tx_bytes" field.</summary>
    public const int TxBytesFieldNumber = 10;
    private long txBytes_;
    /// <summary>
    /// Total transmitted bytes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TxBytes {
      get { return txBytes_; }
      set {
        txBytes_ = value;
      }
    }

    /// <summary>Field number for the "tx_packets" field.</summary>
    public const int TxPacketsFieldNumber = 11;
    private long txPackets_;
    /// <summary>
    /// Total transmitted packets to the associated station
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TxPackets {
      get { return txPackets_; }
      set {
        txPackets_ = value;
      }
    }

    /// <summary>Field number for the "tx_bits_per_second" field.</summary>
    public const int TxBitsPerSecondFieldNumber = 12;
    private long txBitsPerSecond_;
    /// <summary>
    /// Current unicast transmit rate
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TxBitsPerSecond {
      get { return txBitsPerSecond_; }
      set {
        txBitsPerSecond_ = value;
      }
    }

    /// <summary>Field number for the "tx_retries" field.</summary>
    public const int TxRetriesFieldNumber = 13;
    private long txRetries_;
    /// <summary>
    /// Cumulative retry count to this station, within connected time
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TxRetries {
      get { return txRetries_; }
      set {
        txRetries_ = value;
      }
    }

    /// <summary>Field number for the "tx_failed" field.</summary>
    public const int TxFailedFieldNumber = 14;
    private long txFailed_;
    /// <summary>
    /// Cumulative failed tx packet count to this station, within connected time
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TxFailed {
      get { return txFailed_; }
      set {
        txFailed_ = value;
      }
    }

    /// <summary>Field number for the "beacons_received" field.</summary>
    public const int BeaconsReceivedFieldNumber = 15;
    private long beaconsReceived_;
    /// <summary>
    /// Number of beacons received from this peer
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BeaconsReceived {
      get { return beaconsReceived_; }
      set {
        beaconsReceived_ = value;
      }
    }

    /// <summary>Field number for the "beacon_loss_count" field.</summary>
    public const int BeaconLossCountFieldNumber = 16;
    private long beaconLossCount_;
    /// <summary>
    /// Number of times beacon loss was detected
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BeaconLossCount {
      get { return beaconLossCount_; }
      set {
        beaconLossCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Association);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Association other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MacAddress != other.MacAddress) return false;
      if (!object.Equals(ConnectedTime, other.ConnectedTime)) return false;
      if (RxSignalDbm != other.RxSignalDbm) return false;
      if (RxSignalAvgDbm != other.RxSignalAvgDbm) return false;
      if (RxBeaconSignalAvgDbm != other.RxBeaconSignalAvgDbm) return false;
      if (ExpectedBitsPerSecond != other.ExpectedBitsPerSecond) return false;
      if (RxBytes != other.RxBytes) return false;
      if (RxPackets != other.RxPackets) return false;
      if (RxBitsPerSecond != other.RxBitsPerSecond) return false;
      if (TxBytes != other.TxBytes) return false;
      if (TxPackets != other.TxPackets) return false;
      if (TxBitsPerSecond != other.TxBitsPerSecond) return false;
      if (TxRetries != other.TxRetries) return false;
      if (TxFailed != other.TxFailed) return false;
      if (BeaconsReceived != other.BeaconsReceived) return false;
      if (BeaconLossCount != other.BeaconLossCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MacAddress.Length != 0) hash ^= MacAddress.GetHashCode();
      if (connectedTime_ != null) hash ^= ConnectedTime.GetHashCode();
      if (RxSignalDbm != 0) hash ^= RxSignalDbm.GetHashCode();
      if (RxSignalAvgDbm != 0) hash ^= RxSignalAvgDbm.GetHashCode();
      if (RxBeaconSignalAvgDbm != 0) hash ^= RxBeaconSignalAvgDbm.GetHashCode();
      if (ExpectedBitsPerSecond != 0L) hash ^= ExpectedBitsPerSecond.GetHashCode();
      if (RxBytes != 0L) hash ^= RxBytes.GetHashCode();
      if (RxPackets != 0L) hash ^= RxPackets.GetHashCode();
      if (RxBitsPerSecond != 0L) hash ^= RxBitsPerSecond.GetHashCode();
      if (TxBytes != 0L) hash ^= TxBytes.GetHashCode();
      if (TxPackets != 0L) hash ^= TxPackets.GetHashCode();
      if (TxBitsPerSecond != 0L) hash ^= TxBitsPerSecond.GetHashCode();
      if (TxRetries != 0L) hash ^= TxRetries.GetHashCode();
      if (TxFailed != 0L) hash ^= TxFailed.GetHashCode();
      if (BeaconsReceived != 0L) hash ^= BeaconsReceived.GetHashCode();
      if (BeaconLossCount != 0L) hash ^= BeaconLossCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MacAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MacAddress);
      }
      if (connectedTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ConnectedTime);
      }
      if (RxSignalDbm != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RxSignalDbm);
      }
      if (RxSignalAvgDbm != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(RxSignalAvgDbm);
      }
      if (RxBeaconSignalAvgDbm != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(RxBeaconSignalAvgDbm);
      }
      if (ExpectedBitsPerSecond != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(ExpectedBitsPerSecond);
      }
      if (RxBytes != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(RxBytes);
      }
      if (RxPackets != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(RxPackets);
      }
      if (RxBitsPerSecond != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(RxBitsPerSecond);
      }
      if (TxBytes != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(TxBytes);
      }
      if (TxPackets != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(TxPackets);
      }
      if (TxBitsPerSecond != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(TxBitsPerSecond);
      }
      if (TxRetries != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(TxRetries);
      }
      if (TxFailed != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(TxFailed);
      }
      if (BeaconsReceived != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(BeaconsReceived);
      }
      if (BeaconLossCount != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(BeaconLossCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MacAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MacAddress);
      }
      if (connectedTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConnectedTime);
      }
      if (RxSignalDbm != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RxSignalDbm);
      }
      if (RxSignalAvgDbm != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RxSignalAvgDbm);
      }
      if (RxBeaconSignalAvgDbm != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RxBeaconSignalAvgDbm);
      }
      if (ExpectedBitsPerSecond != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpectedBitsPerSecond);
      }
      if (RxBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RxBytes);
      }
      if (RxPackets != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RxPackets);
      }
      if (RxBitsPerSecond != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RxBitsPerSecond);
      }
      if (TxBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TxBytes);
      }
      if (TxPackets != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TxPackets);
      }
      if (TxBitsPerSecond != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TxBitsPerSecond);
      }
      if (TxRetries != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TxRetries);
      }
      if (TxFailed != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TxFailed);
      }
      if (BeaconsReceived != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BeaconsReceived);
      }
      if (BeaconLossCount != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(BeaconLossCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Association other) {
      if (other == null) {
        return;
      }
      if (other.MacAddress.Length != 0) {
        MacAddress = other.MacAddress;
      }
      if (other.connectedTime_ != null) {
        if (connectedTime_ == null) {
          ConnectedTime = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        ConnectedTime.MergeFrom(other.ConnectedTime);
      }
      if (other.RxSignalDbm != 0) {
        RxSignalDbm = other.RxSignalDbm;
      }
      if (other.RxSignalAvgDbm != 0) {
        RxSignalAvgDbm = other.RxSignalAvgDbm;
      }
      if (other.RxBeaconSignalAvgDbm != 0) {
        RxBeaconSignalAvgDbm = other.RxBeaconSignalAvgDbm;
      }
      if (other.ExpectedBitsPerSecond != 0L) {
        ExpectedBitsPerSecond = other.ExpectedBitsPerSecond;
      }
      if (other.RxBytes != 0L) {
        RxBytes = other.RxBytes;
      }
      if (other.RxPackets != 0L) {
        RxPackets = other.RxPackets;
      }
      if (other.RxBitsPerSecond != 0L) {
        RxBitsPerSecond = other.RxBitsPerSecond;
      }
      if (other.TxBytes != 0L) {
        TxBytes = other.TxBytes;
      }
      if (other.TxPackets != 0L) {
        TxPackets = other.TxPackets;
      }
      if (other.TxBitsPerSecond != 0L) {
        TxBitsPerSecond = other.TxBitsPerSecond;
      }
      if (other.TxRetries != 0L) {
        TxRetries = other.TxRetries;
      }
      if (other.TxFailed != 0L) {
        TxFailed = other.TxFailed;
      }
      if (other.BeaconsReceived != 0L) {
        BeaconsReceived = other.BeaconsReceived;
      }
      if (other.BeaconLossCount != 0L) {
        BeaconLossCount = other.BeaconLossCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MacAddress = input.ReadString();
            break;
          }
          case 18: {
            if (connectedTime_ == null) {
              ConnectedTime = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ConnectedTime);
            break;
          }
          case 24: {
            RxSignalDbm = input.ReadInt32();
            break;
          }
          case 32: {
            RxSignalAvgDbm = input.ReadInt32();
            break;
          }
          case 40: {
            RxBeaconSignalAvgDbm = input.ReadInt32();
            break;
          }
          case 48: {
            ExpectedBitsPerSecond = input.ReadInt64();
            break;
          }
          case 56: {
            RxBytes = input.ReadInt64();
            break;
          }
          case 64: {
            RxPackets = input.ReadInt64();
            break;
          }
          case 72: {
            RxBitsPerSecond = input.ReadInt64();
            break;
          }
          case 80: {
            TxBytes = input.ReadInt64();
            break;
          }
          case 88: {
            TxPackets = input.ReadInt64();
            break;
          }
          case 96: {
            TxBitsPerSecond = input.ReadInt64();
            break;
          }
          case 104: {
            TxRetries = input.ReadInt64();
            break;
          }
          case 112: {
            TxFailed = input.ReadInt64();
            break;
          }
          case 120: {
            BeaconsReceived = input.ReadInt64();
            break;
          }
          case 128: {
            BeaconLossCount = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class WifiDevice : pb::IMessage<WifiDevice> {
    private static readonly pb::MessageParser<WifiDevice> _parser = new pb::MessageParser<WifiDevice>(() => new WifiDevice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WifiDevice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.NetworkStatsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WifiDevice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WifiDevice(WifiDevice other) : this() {
      type_ = other.type_;
      name_ = other.name_;
      macAddress_ = other.macAddress_;
      ssid_ = other.ssid_;
      txPowerDbm_ = other.txPowerDbm_;
      associations_ = other.associations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WifiDevice Clone() {
      return new WifiDevice(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Bosdyn.Api.WifiDevice.Types.Type type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bosdyn.Api.WifiDevice.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mac_address" field.</summary>
    public const int MacAddressFieldNumber = 3;
    private string macAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MacAddress {
      get { return macAddress_; }
      set {
        macAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ssid" field.</summary>
    public const int SsidFieldNumber = 4;
    private string ssid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ssid {
      get { return ssid_; }
      set {
        ssid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tx_power_dbm" field.</summary>
    public const int TxPowerDbmFieldNumber = 5;
    private int txPowerDbm_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TxPowerDbm {
      get { return txPowerDbm_; }
      set {
        txPowerDbm_ = value;
      }
    }

    /// <summary>Field number for the "associations" field.</summary>
    public const int AssociationsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Bosdyn.Api.Association> _repeated_associations_codec
        = pb::FieldCodec.ForMessage(50, global::Bosdyn.Api.Association.Parser);
    private readonly pbc::RepeatedField<global::Bosdyn.Api.Association> associations_ = new pbc::RepeatedField<global::Bosdyn.Api.Association>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Bosdyn.Api.Association> Associations {
      get { return associations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WifiDevice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WifiDevice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Name != other.Name) return false;
      if (MacAddress != other.MacAddress) return false;
      if (Ssid != other.Ssid) return false;
      if (TxPowerDbm != other.TxPowerDbm) return false;
      if(!associations_.Equals(other.associations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (MacAddress.Length != 0) hash ^= MacAddress.GetHashCode();
      if (Ssid.Length != 0) hash ^= Ssid.GetHashCode();
      if (TxPowerDbm != 0) hash ^= TxPowerDbm.GetHashCode();
      hash ^= associations_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (MacAddress.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MacAddress);
      }
      if (Ssid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Ssid);
      }
      if (TxPowerDbm != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(TxPowerDbm);
      }
      associations_.WriteTo(output, _repeated_associations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (MacAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MacAddress);
      }
      if (Ssid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ssid);
      }
      if (TxPowerDbm != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TxPowerDbm);
      }
      size += associations_.CalculateSize(_repeated_associations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WifiDevice other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.MacAddress.Length != 0) {
        MacAddress = other.MacAddress;
      }
      if (other.Ssid.Length != 0) {
        Ssid = other.Ssid;
      }
      if (other.TxPowerDbm != 0) {
        TxPowerDbm = other.TxPowerDbm;
      }
      associations_.Add(other.associations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::Bosdyn.Api.WifiDevice.Types.Type) input.ReadEnum();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            MacAddress = input.ReadString();
            break;
          }
          case 34: {
            Ssid = input.ReadString();
            break;
          }
          case 40: {
            TxPowerDbm = input.ReadInt32();
            break;
          }
          case 50: {
            associations_.AddEntriesFrom(input, _repeated_associations_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the WifiDevice message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Type {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("AP")] Ap = 1,
        [pbr::OriginalName("CLIENT")] Client = 2,
      }

    }
    #endregion

  }

  public sealed partial class WifiStats : pb::IMessage<WifiStats> {
    private static readonly pb::MessageParser<WifiStats> _parser = new pb::MessageParser<WifiStats>(() => new WifiStats());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WifiStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.NetworkStatsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WifiStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WifiStats(WifiStats other) : this() {
      hostname_ = other.hostname_;
      devices_ = other.devices_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WifiStats Clone() {
      return new WifiStats(this);
    }

    /// <summary>Field number for the "hostname" field.</summary>
    public const int HostnameFieldNumber = 1;
    private string hostname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Hostname {
      get { return hostname_; }
      set {
        hostname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "devices" field.</summary>
    public const int DevicesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Bosdyn.Api.WifiDevice> _repeated_devices_codec
        = pb::FieldCodec.ForMessage(18, global::Bosdyn.Api.WifiDevice.Parser);
    private readonly pbc::RepeatedField<global::Bosdyn.Api.WifiDevice> devices_ = new pbc::RepeatedField<global::Bosdyn.Api.WifiDevice>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Bosdyn.Api.WifiDevice> Devices {
      get { return devices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WifiStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WifiStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hostname != other.Hostname) return false;
      if(!devices_.Equals(other.devices_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Hostname.Length != 0) hash ^= Hostname.GetHashCode();
      hash ^= devices_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Hostname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Hostname);
      }
      devices_.WriteTo(output, _repeated_devices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Hostname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hostname);
      }
      size += devices_.CalculateSize(_repeated_devices_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WifiStats other) {
      if (other == null) {
        return;
      }
      if (other.Hostname.Length != 0) {
        Hostname = other.Hostname;
      }
      devices_.Add(other.devices_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Hostname = input.ReadString();
            break;
          }
          case 18: {
            devices_.AddEntriesFrom(input, _repeated_devices_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
