// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/LED.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bosdyn.Api.SpotCam {

  /// <summary>Holder for reflection information generated from Protos/LED.proto</summary>
  public static partial class LEDReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/LED.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LEDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBQcm90b3MvTEVELnByb3RvEhNib3NkeW4uYXBpLnNwb3RfY2FtGhNQcm90",
            "b3MvaGVhZGVyLnByb3RvIkQKF0dldExFREJyaWdodG5lc3NSZXF1ZXN0EikK",
            "BmhlYWRlchgBIAEoCzIZLmJvc2R5bi5hcGkuUmVxdWVzdEhlYWRlciJcChhH",
            "ZXRMRURCcmlnaHRuZXNzUmVzcG9uc2USKgoGaGVhZGVyGAEgASgLMhouYm9z",
            "ZHluLmFwaS5SZXNwb25zZUhlYWRlchIUCgxicmlnaHRuZXNzZXMYAiADKAIi",
            "zwEKF1NldExFREJyaWdodG5lc3NSZXF1ZXN0EikKBmhlYWRlchgBIAEoCzIZ",
            "LmJvc2R5bi5hcGkuUmVxdWVzdEhlYWRlchJUCgxicmlnaHRuZXNzZXMYAiAD",
            "KAsyPi5ib3NkeW4uYXBpLnNwb3RfY2FtLlNldExFREJyaWdodG5lc3NSZXF1",
            "ZXN0LkJyaWdodG5lc3Nlc0VudHJ5GjMKEUJyaWdodG5lc3Nlc0VudHJ5EgsK",
            "A2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoAjoCOAEiRgoYU2V0TEVEQnJpZ2h0",
            "bmVzc1Jlc3BvbnNlEioKBmhlYWRlchgBIAEoCzIaLmJvc2R5bi5hcGkuUmVz",
            "cG9uc2VIZWFkZXJCD0INTGlnaHRpbmdQcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bosdyn.Api.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SpotCam.GetLEDBrightnessRequest), global::Bosdyn.Api.SpotCam.GetLEDBrightnessRequest.Parser, new[]{ "Header" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SpotCam.GetLEDBrightnessResponse), global::Bosdyn.Api.SpotCam.GetLEDBrightnessResponse.Parser, new[]{ "Header", "Brightnesses" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SpotCam.SetLEDBrightnessRequest), global::Bosdyn.Api.SpotCam.SetLEDBrightnessRequest.Parser, new[]{ "Header", "Brightnesses" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SpotCam.SetLEDBrightnessResponse), global::Bosdyn.Api.SpotCam.SetLEDBrightnessResponse.Parser, new[]{ "Header" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request the current state of LEDs on the SpotCam.
  /// </summary>
  public sealed partial class GetLEDBrightnessRequest : pb::IMessage<GetLEDBrightnessRequest> {
    private static readonly pb::MessageParser<GetLEDBrightnessRequest> _parser = new pb::MessageParser<GetLEDBrightnessRequest>(() => new GetLEDBrightnessRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetLEDBrightnessRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.SpotCam.LEDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLEDBrightnessRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLEDBrightnessRequest(GetLEDBrightnessRequest other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLEDBrightnessRequest Clone() {
      return new GetLEDBrightnessRequest(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Bosdyn.Api.RequestHeader header_;
    /// <summary>
    /// Common request header.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bosdyn.Api.RequestHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetLEDBrightnessRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetLEDBrightnessRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetLEDBrightnessRequest other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Bosdyn.Api.RequestHeader();
        }
        Header.MergeFrom(other.Header);
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
            if (header_ == null) {
              Header = new global::Bosdyn.Api.RequestHeader();
            }
            input.ReadMessage(Header);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Describes the current brightnesses of all LEDs.
  /// </summary>
  public sealed partial class GetLEDBrightnessResponse : pb::IMessage<GetLEDBrightnessResponse> {
    private static readonly pb::MessageParser<GetLEDBrightnessResponse> _parser = new pb::MessageParser<GetLEDBrightnessResponse>(() => new GetLEDBrightnessResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetLEDBrightnessResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.SpotCam.LEDReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLEDBrightnessResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLEDBrightnessResponse(GetLEDBrightnessResponse other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      brightnesses_ = other.brightnesses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLEDBrightnessResponse Clone() {
      return new GetLEDBrightnessResponse(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Bosdyn.Api.ResponseHeader header_;
    /// <summary>
    /// Common response header.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bosdyn.Api.ResponseHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "brightnesses" field.</summary>
    public const int BrightnessesFieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_brightnesses_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> brightnesses_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// Brightness [0, 1] of the LED located at indices [0, 3].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Brightnesses {
      get { return brightnesses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetLEDBrightnessResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetLEDBrightnessResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if(!brightnesses_.Equals(other.brightnesses_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= brightnesses_.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      brightnesses_.WriteTo(output, _repeated_brightnesses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += brightnesses_.CalculateSize(_repeated_brightnesses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetLEDBrightnessResponse other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Bosdyn.Api.ResponseHeader();
        }
        Header.MergeFrom(other.Header);
      }
      brightnesses_.Add(other.brightnesses_);
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
            if (header_ == null) {
              Header = new global::Bosdyn.Api.ResponseHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18:
          case 21: {
            brightnesses_.AddEntriesFrom(input, _repeated_brightnesses_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Set individual LED brightnesses.
  /// </summary>
  public sealed partial class SetLEDBrightnessRequest : pb::IMessage<SetLEDBrightnessRequest> {
    private static readonly pb::MessageParser<SetLEDBrightnessRequest> _parser = new pb::MessageParser<SetLEDBrightnessRequest>(() => new SetLEDBrightnessRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetLEDBrightnessRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.SpotCam.LEDReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLEDBrightnessRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLEDBrightnessRequest(SetLEDBrightnessRequest other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      brightnesses_ = other.brightnesses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLEDBrightnessRequest Clone() {
      return new SetLEDBrightnessRequest(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Bosdyn.Api.RequestHeader header_;
    /// <summary>
    /// Common request header.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bosdyn.Api.RequestHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "brightnesses" field.</summary>
    public const int BrightnessesFieldNumber = 2;
    private static readonly pbc::MapField<int, float>.Codec _map_brightnesses_codec
        = new pbc::MapField<int, float>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForFloat(21), 18);
    private readonly pbc::MapField<int, float> brightnesses_ = new pbc::MapField<int, float>();
    /// <summary>
    /// Brightness [0, 1] to assign to the LED located at indices [0, 3].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, float> Brightnesses {
      get { return brightnesses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetLEDBrightnessRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetLEDBrightnessRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (!Brightnesses.Equals(other.Brightnesses)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= Brightnesses.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      brightnesses_.WriteTo(output, _map_brightnesses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += brightnesses_.CalculateSize(_map_brightnesses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetLEDBrightnessRequest other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Bosdyn.Api.RequestHeader();
        }
        Header.MergeFrom(other.Header);
      }
      brightnesses_.Add(other.brightnesses_);
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
            if (header_ == null) {
              Header = new global::Bosdyn.Api.RequestHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            brightnesses_.AddEntriesFrom(input, _map_brightnesses_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response with any errors setting LED brightnesses.
  /// </summary>
  public sealed partial class SetLEDBrightnessResponse : pb::IMessage<SetLEDBrightnessResponse> {
    private static readonly pb::MessageParser<SetLEDBrightnessResponse> _parser = new pb::MessageParser<SetLEDBrightnessResponse>(() => new SetLEDBrightnessResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetLEDBrightnessResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.SpotCam.LEDReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLEDBrightnessResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLEDBrightnessResponse(SetLEDBrightnessResponse other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLEDBrightnessResponse Clone() {
      return new SetLEDBrightnessResponse(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Bosdyn.Api.ResponseHeader header_;
    /// <summary>
    /// Common response header.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bosdyn.Api.ResponseHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetLEDBrightnessResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetLEDBrightnessResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetLEDBrightnessResponse other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Bosdyn.Api.ResponseHeader();
        }
        Header.MergeFrom(other.Header);
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
            if (header_ == null) {
              Header = new global::Bosdyn.Api.ResponseHeader();
            }
            input.ReadMessage(Header);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
