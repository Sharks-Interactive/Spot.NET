// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/any_test.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtobufUnittest {

  /// <summary>Holder for reflection information generated from Protos/any_test.proto</summary>
  public static partial class AnyTestReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/any_test.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnyTestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvYW55X3Rlc3QucHJvdG8SEXByb3RvYnVmX3VuaXR0ZXN0Ghln",
            "b29nbGUvcHJvdG9idWYvYW55LnByb3RvIocBCgdUZXN0QW55EhMKC2ludDMy",
            "X3ZhbHVlGAEgASgFEicKCWFueV92YWx1ZRgCIAEoCzIULmdvb2dsZS5wcm90",
            "b2J1Zi5BbnkSMAoScmVwZWF0ZWRfYW55X3ZhbHVlGAMgAygLMhQuZ29vZ2xl",
            "LnByb3RvYnVmLkFueRIMCgR0ZXh0GAQgASgJQg5CDFRlc3RBbnlQcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtobufUnittest.TestAny), global::ProtobufUnittest.TestAny.Parser, new[]{ "Int32Value", "AnyValue", "RepeatedAnyValue", "Text" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TestAny : pb::IMessage<TestAny> {
    private static readonly pb::MessageParser<TestAny> _parser = new pb::MessageParser<TestAny>(() => new TestAny());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TestAny> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufUnittest.AnyTestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestAny() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestAny(TestAny other) : this() {
      int32Value_ = other.int32Value_;
      anyValue_ = other.anyValue_ != null ? other.anyValue_.Clone() : null;
      repeatedAnyValue_ = other.repeatedAnyValue_.Clone();
      text_ = other.text_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestAny Clone() {
      return new TestAny(this);
    }

    /// <summary>Field number for the "int32_value" field.</summary>
    public const int Int32ValueFieldNumber = 1;
    private int int32Value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Int32Value {
      get { return int32Value_; }
      set {
        int32Value_ = value;
      }
    }

    /// <summary>Field number for the "any_value" field.</summary>
    public const int AnyValueFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any anyValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any AnyValue {
      get { return anyValue_; }
      set {
        anyValue_ = value;
      }
    }

    /// <summary>Field number for the "repeated_any_value" field.</summary>
    public const int RepeatedAnyValueFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_repeatedAnyValue_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> repeatedAnyValue_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> RepeatedAnyValue {
      get { return repeatedAnyValue_; }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 4;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TestAny);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TestAny other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Int32Value != other.Int32Value) return false;
      if (!object.Equals(AnyValue, other.AnyValue)) return false;
      if(!repeatedAnyValue_.Equals(other.repeatedAnyValue_)) return false;
      if (Text != other.Text) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Int32Value != 0) hash ^= Int32Value.GetHashCode();
      if (anyValue_ != null) hash ^= AnyValue.GetHashCode();
      hash ^= repeatedAnyValue_.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
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
      if (Int32Value != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Int32Value);
      }
      if (anyValue_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AnyValue);
      }
      repeatedAnyValue_.WriteTo(output, _repeated_repeatedAnyValue_codec);
      if (Text.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Text);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Int32Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Int32Value);
      }
      if (anyValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AnyValue);
      }
      size += repeatedAnyValue_.CalculateSize(_repeated_repeatedAnyValue_codec);
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TestAny other) {
      if (other == null) {
        return;
      }
      if (other.Int32Value != 0) {
        Int32Value = other.Int32Value;
      }
      if (other.anyValue_ != null) {
        if (anyValue_ == null) {
          AnyValue = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        AnyValue.MergeFrom(other.AnyValue);
      }
      repeatedAnyValue_.Add(other.repeatedAnyValue_);
      if (other.Text.Length != 0) {
        Text = other.Text;
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
          case 8: {
            Int32Value = input.ReadInt32();
            break;
          }
          case 18: {
            if (anyValue_ == null) {
              AnyValue = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(AnyValue);
            break;
          }
          case 26: {
            repeatedAnyValue_.AddEntriesFrom(input, _repeated_repeatedAnyValue_codec);
            break;
          }
          case 34: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
