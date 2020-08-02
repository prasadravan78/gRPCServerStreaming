// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerStreaming.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ServerStream {

  /// <summary>Holder for reflection information generated from ServerStreaming.proto</summary>
  public static partial class ServerStreamingReflection {

    #region Descriptor
    /// <summary>File descriptor for ServerStreaming.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerStreamingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTZXJ2ZXJTdHJlYW1pbmcucHJvdG8SDFNlcnZlclN0cmVhbSI2Cg9TZXJ2",
            "ZXJTdHJlYW1Nc2cSEQoJRmlyc3ROYW1lGAEgASgJEhAKCExhc3ROYW1lGAIg",
            "ASgJIkcKFlNlcnZlclN0cmVhbWluZ1JlcXVlc3QSLQoGc3RyZWFtGAEgASgL",
            "Mh0uU2VydmVyU3RyZWFtLlNlcnZlclN0cmVhbU1zZyIxChdTZXJ2ZXJTdHJl",
            "YW1pbmdSZXNwb25zZRIWCg5TZXJ2ZXJSZXNwb25zZRgBIAEoCTJ5ChZTZXJ2",
            "ZXJTdHJlYW1pbmdTZXJ2aWNlEl8KDFNlcnZlclN0cmVhbRIkLlNlcnZlclN0",
            "cmVhbS5TZXJ2ZXJTdHJlYW1pbmdSZXF1ZXN0GiUuU2VydmVyU3RyZWFtLlNl",
            "cnZlclN0cmVhbWluZ1Jlc3BvbnNlIgAwAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ServerStream.ServerStreamMsg), global::ServerStream.ServerStreamMsg.Parser, new[]{ "FirstName", "LastName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServerStream.ServerStreamingRequest), global::ServerStream.ServerStreamingRequest.Parser, new[]{ "Stream" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ServerStream.ServerStreamingResponse), global::ServerStream.ServerStreamingResponse.Parser, new[]{ "ServerResponse" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServerStreamMsg : pb::IMessage<ServerStreamMsg> {
    private static readonly pb::MessageParser<ServerStreamMsg> _parser = new pb::MessageParser<ServerStreamMsg>(() => new ServerStreamMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerStreamMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServerStream.ServerStreamingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamMsg(ServerStreamMsg other) : this() {
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamMsg Clone() {
      return new ServerStreamMsg(this);
    }

    /// <summary>Field number for the "FirstName" field.</summary>
    public const int FirstNameFieldNumber = 1;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LastName" field.</summary>
    public const int LastNameFieldNumber = 2;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerStreamMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerStreamMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
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
      if (FirstName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LastName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerStreamMsg other) {
      if (other == null) {
        return;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
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
            FirstName = input.ReadString();
            break;
          }
          case 18: {
            LastName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerStreamingRequest : pb::IMessage<ServerStreamingRequest> {
    private static readonly pb::MessageParser<ServerStreamingRequest> _parser = new pb::MessageParser<ServerStreamingRequest>(() => new ServerStreamingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerStreamingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServerStream.ServerStreamingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamingRequest(ServerStreamingRequest other) : this() {
      stream_ = other.stream_ != null ? other.stream_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamingRequest Clone() {
      return new ServerStreamingRequest(this);
    }

    /// <summary>Field number for the "stream" field.</summary>
    public const int StreamFieldNumber = 1;
    private global::ServerStream.ServerStreamMsg stream_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ServerStream.ServerStreamMsg Stream {
      get { return stream_; }
      set {
        stream_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerStreamingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerStreamingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Stream, other.Stream)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (stream_ != null) hash ^= Stream.GetHashCode();
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
      if (stream_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Stream);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (stream_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stream);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerStreamingRequest other) {
      if (other == null) {
        return;
      }
      if (other.stream_ != null) {
        if (stream_ == null) {
          Stream = new global::ServerStream.ServerStreamMsg();
        }
        Stream.MergeFrom(other.Stream);
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
            if (stream_ == null) {
              Stream = new global::ServerStream.ServerStreamMsg();
            }
            input.ReadMessage(Stream);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ServerStreamingResponse : pb::IMessage<ServerStreamingResponse> {
    private static readonly pb::MessageParser<ServerStreamingResponse> _parser = new pb::MessageParser<ServerStreamingResponse>(() => new ServerStreamingResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerStreamingResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ServerStream.ServerStreamingReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamingResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamingResponse(ServerStreamingResponse other) : this() {
      serverResponse_ = other.serverResponse_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerStreamingResponse Clone() {
      return new ServerStreamingResponse(this);
    }

    /// <summary>Field number for the "ServerResponse" field.</summary>
    public const int ServerResponseFieldNumber = 1;
    private string serverResponse_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServerResponse {
      get { return serverResponse_; }
      set {
        serverResponse_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerStreamingResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerStreamingResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerResponse != other.ServerResponse) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerResponse.Length != 0) hash ^= ServerResponse.GetHashCode();
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
      if (ServerResponse.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServerResponse);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServerResponse.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerResponse);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerStreamingResponse other) {
      if (other == null) {
        return;
      }
      if (other.ServerResponse.Length != 0) {
        ServerResponse = other.ServerResponse;
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
            ServerResponse = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
