// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/synchronized_command.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bosdyn.Api {

  /// <summary>Holder for reflection information generated from Protos/synchronized_command.proto</summary>
  public static partial class SynchronizedCommandReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/synchronized_command.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SynchronizedCommandReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQcm90b3Mvc3luY2hyb25pemVkX2NvbW1hbmQucHJvdG8SCmJvc2R5bi5h",
            "cGkaGFByb3Rvcy9hcm1fY29tbWFuZC5wcm90bxocUHJvdG9zL2dyaXBwZXJf",
            "Y29tbWFuZC5wcm90bxodUHJvdG9zL21vYmlsaXR5X2NvbW1hbmQucHJvdG8i",
            "rgMKE1N5bmNocm9uaXplZENvbW1hbmQaugEKB1JlcXVlc3QSMwoLYXJtX2Nv",
            "bW1hbmQYASABKAsyHi5ib3NkeW4uYXBpLkFybUNvbW1hbmQuUmVxdWVzdBI9",
            "ChBtb2JpbGl0eV9jb21tYW5kGAIgASgLMiMuYm9zZHluLmFwaS5Nb2JpbGl0",
            "eUNvbW1hbmQuUmVxdWVzdBI7Cg9ncmlwcGVyX2NvbW1hbmQYAyABKAsyIi5i",
            "b3NkeW4uYXBpLkdyaXBwZXJDb21tYW5kLlJlcXVlc3Qa2QEKCEZlZWRiYWNr",
            "Ej0KFGFybV9jb21tYW5kX2ZlZWRiYWNrGAEgASgLMh8uYm9zZHluLmFwaS5B",
            "cm1Db21tYW5kLkZlZWRiYWNrEkcKGW1vYmlsaXR5X2NvbW1hbmRfZmVlZGJh",
            "Y2sYAiABKAsyJC5ib3NkeW4uYXBpLk1vYmlsaXR5Q29tbWFuZC5GZWVkYmFj",
            "axJFChhncmlwcGVyX2NvbW1hbmRfZmVlZGJhY2sYAyABKAsyIy5ib3NkeW4u",
            "YXBpLkdyaXBwZXJDb21tYW5kLkZlZWRiYWNrQhpCGFN5bmNocm9uaXplZENv",
            "bW1hbmRQcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bosdyn.Api.ArmCommandReflection.Descriptor, global::Bosdyn.Api.GripperCommandReflection.Descriptor, global::Bosdyn.Api.MobilityCommandReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SynchronizedCommand), global::Bosdyn.Api.SynchronizedCommand.Parser, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SynchronizedCommand.Types.Request), global::Bosdyn.Api.SynchronizedCommand.Types.Request.Parser, new[]{ "ArmCommand", "MobilityCommand", "GripperCommand" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bosdyn.Api.SynchronizedCommand.Types.Feedback), global::Bosdyn.Api.SynchronizedCommand.Types.Feedback.Parser, new[]{ "ArmCommandFeedback", "MobilityCommandFeedback", "GripperCommandFeedback" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SynchronizedCommand : pb::IMessage<SynchronizedCommand> {
    private static readonly pb::MessageParser<SynchronizedCommand> _parser = new pb::MessageParser<SynchronizedCommand>(() => new SynchronizedCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SynchronizedCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bosdyn.Api.SynchronizedCommandReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SynchronizedCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SynchronizedCommand(SynchronizedCommand other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SynchronizedCommand Clone() {
      return new SynchronizedCommand(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SynchronizedCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SynchronizedCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SynchronizedCommand other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SynchronizedCommand message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Request : pb::IMessage<Request> {
        private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Request> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Bosdyn.Api.SynchronizedCommand.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Request() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Request(Request other) : this() {
          armCommand_ = other.armCommand_ != null ? other.armCommand_.Clone() : null;
          mobilityCommand_ = other.mobilityCommand_ != null ? other.mobilityCommand_.Clone() : null;
          gripperCommand_ = other.gripperCommand_ != null ? other.gripperCommand_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Request Clone() {
          return new Request(this);
        }

        /// <summary>Field number for the "arm_command" field.</summary>
        public const int ArmCommandFieldNumber = 1;
        private global::Bosdyn.Api.ArmCommand.Types.Request armCommand_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Bosdyn.Api.ArmCommand.Types.Request ArmCommand {
          get { return armCommand_; }
          set {
            armCommand_ = value;
          }
        }

        /// <summary>Field number for the "mobility_command" field.</summary>
        public const int MobilityCommandFieldNumber = 2;
        private global::Bosdyn.Api.MobilityCommand.Types.Request mobilityCommand_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Bosdyn.Api.MobilityCommand.Types.Request MobilityCommand {
          get { return mobilityCommand_; }
          set {
            mobilityCommand_ = value;
          }
        }

        /// <summary>Field number for the "gripper_command" field.</summary>
        public const int GripperCommandFieldNumber = 3;
        private global::Bosdyn.Api.GripperCommand.Types.Request gripperCommand_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Bosdyn.Api.GripperCommand.Types.Request GripperCommand {
          get { return gripperCommand_; }
          set {
            gripperCommand_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Request);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Request other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(ArmCommand, other.ArmCommand)) return false;
          if (!object.Equals(MobilityCommand, other.MobilityCommand)) return false;
          if (!object.Equals(GripperCommand, other.GripperCommand)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (armCommand_ != null) hash ^= ArmCommand.GetHashCode();
          if (mobilityCommand_ != null) hash ^= MobilityCommand.GetHashCode();
          if (gripperCommand_ != null) hash ^= GripperCommand.GetHashCode();
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
          if (armCommand_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(ArmCommand);
          }
          if (mobilityCommand_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(MobilityCommand);
          }
          if (gripperCommand_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(GripperCommand);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (armCommand_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(ArmCommand);
          }
          if (mobilityCommand_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobilityCommand);
          }
          if (gripperCommand_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(GripperCommand);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Request other) {
          if (other == null) {
            return;
          }
          if (other.armCommand_ != null) {
            if (armCommand_ == null) {
              ArmCommand = new global::Bosdyn.Api.ArmCommand.Types.Request();
            }
            ArmCommand.MergeFrom(other.ArmCommand);
          }
          if (other.mobilityCommand_ != null) {
            if (mobilityCommand_ == null) {
              MobilityCommand = new global::Bosdyn.Api.MobilityCommand.Types.Request();
            }
            MobilityCommand.MergeFrom(other.MobilityCommand);
          }
          if (other.gripperCommand_ != null) {
            if (gripperCommand_ == null) {
              GripperCommand = new global::Bosdyn.Api.GripperCommand.Types.Request();
            }
            GripperCommand.MergeFrom(other.GripperCommand);
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
                if (armCommand_ == null) {
                  ArmCommand = new global::Bosdyn.Api.ArmCommand.Types.Request();
                }
                input.ReadMessage(ArmCommand);
                break;
              }
              case 18: {
                if (mobilityCommand_ == null) {
                  MobilityCommand = new global::Bosdyn.Api.MobilityCommand.Types.Request();
                }
                input.ReadMessage(MobilityCommand);
                break;
              }
              case 26: {
                if (gripperCommand_ == null) {
                  GripperCommand = new global::Bosdyn.Api.GripperCommand.Types.Request();
                }
                input.ReadMessage(GripperCommand);
                break;
              }
            }
          }
        }

      }

      public sealed partial class Feedback : pb::IMessage<Feedback> {
        private static readonly pb::MessageParser<Feedback> _parser = new pb::MessageParser<Feedback>(() => new Feedback());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Feedback> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Bosdyn.Api.SynchronizedCommand.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Feedback() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Feedback(Feedback other) : this() {
          armCommandFeedback_ = other.armCommandFeedback_ != null ? other.armCommandFeedback_.Clone() : null;
          mobilityCommandFeedback_ = other.mobilityCommandFeedback_ != null ? other.mobilityCommandFeedback_.Clone() : null;
          gripperCommandFeedback_ = other.gripperCommandFeedback_ != null ? other.gripperCommandFeedback_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Feedback Clone() {
          return new Feedback(this);
        }

        /// <summary>Field number for the "arm_command_feedback" field.</summary>
        public const int ArmCommandFeedbackFieldNumber = 1;
        private global::Bosdyn.Api.ArmCommand.Types.Feedback armCommandFeedback_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Bosdyn.Api.ArmCommand.Types.Feedback ArmCommandFeedback {
          get { return armCommandFeedback_; }
          set {
            armCommandFeedback_ = value;
          }
        }

        /// <summary>Field number for the "mobility_command_feedback" field.</summary>
        public const int MobilityCommandFeedbackFieldNumber = 2;
        private global::Bosdyn.Api.MobilityCommand.Types.Feedback mobilityCommandFeedback_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Bosdyn.Api.MobilityCommand.Types.Feedback MobilityCommandFeedback {
          get { return mobilityCommandFeedback_; }
          set {
            mobilityCommandFeedback_ = value;
          }
        }

        /// <summary>Field number for the "gripper_command_feedback" field.</summary>
        public const int GripperCommandFeedbackFieldNumber = 3;
        private global::Bosdyn.Api.GripperCommand.Types.Feedback gripperCommandFeedback_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Bosdyn.Api.GripperCommand.Types.Feedback GripperCommandFeedback {
          get { return gripperCommandFeedback_; }
          set {
            gripperCommandFeedback_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Feedback);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Feedback other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(ArmCommandFeedback, other.ArmCommandFeedback)) return false;
          if (!object.Equals(MobilityCommandFeedback, other.MobilityCommandFeedback)) return false;
          if (!object.Equals(GripperCommandFeedback, other.GripperCommandFeedback)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (armCommandFeedback_ != null) hash ^= ArmCommandFeedback.GetHashCode();
          if (mobilityCommandFeedback_ != null) hash ^= MobilityCommandFeedback.GetHashCode();
          if (gripperCommandFeedback_ != null) hash ^= GripperCommandFeedback.GetHashCode();
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
          if (armCommandFeedback_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(ArmCommandFeedback);
          }
          if (mobilityCommandFeedback_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(MobilityCommandFeedback);
          }
          if (gripperCommandFeedback_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(GripperCommandFeedback);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (armCommandFeedback_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(ArmCommandFeedback);
          }
          if (mobilityCommandFeedback_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobilityCommandFeedback);
          }
          if (gripperCommandFeedback_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(GripperCommandFeedback);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Feedback other) {
          if (other == null) {
            return;
          }
          if (other.armCommandFeedback_ != null) {
            if (armCommandFeedback_ == null) {
              ArmCommandFeedback = new global::Bosdyn.Api.ArmCommand.Types.Feedback();
            }
            ArmCommandFeedback.MergeFrom(other.ArmCommandFeedback);
          }
          if (other.mobilityCommandFeedback_ != null) {
            if (mobilityCommandFeedback_ == null) {
              MobilityCommandFeedback = new global::Bosdyn.Api.MobilityCommand.Types.Feedback();
            }
            MobilityCommandFeedback.MergeFrom(other.MobilityCommandFeedback);
          }
          if (other.gripperCommandFeedback_ != null) {
            if (gripperCommandFeedback_ == null) {
              GripperCommandFeedback = new global::Bosdyn.Api.GripperCommand.Types.Feedback();
            }
            GripperCommandFeedback.MergeFrom(other.GripperCommandFeedback);
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
                if (armCommandFeedback_ == null) {
                  ArmCommandFeedback = new global::Bosdyn.Api.ArmCommand.Types.Feedback();
                }
                input.ReadMessage(ArmCommandFeedback);
                break;
              }
              case 18: {
                if (mobilityCommandFeedback_ == null) {
                  MobilityCommandFeedback = new global::Bosdyn.Api.MobilityCommand.Types.Feedback();
                }
                input.ReadMessage(MobilityCommandFeedback);
                break;
              }
              case 26: {
                if (gripperCommandFeedback_ == null) {
                  GripperCommandFeedback = new global::Bosdyn.Api.GripperCommand.Types.Feedback();
                }
                input.ReadMessage(GripperCommandFeedback);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
