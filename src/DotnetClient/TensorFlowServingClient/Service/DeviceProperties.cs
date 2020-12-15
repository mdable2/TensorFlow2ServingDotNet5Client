// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/protobuf/device_properties.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/device_properties.proto</summary>
  public static partial class DevicePropertiesReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/device_properties.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DevicePropertiesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjB0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvZGV2aWNlX3Byb3BlcnRpZXMu",
            "cHJvdG8SCnRlbnNvcmZsb3cikAMKEERldmljZVByb3BlcnRpZXMSDAoEdHlw",
            "ZRgBIAEoCRIOCgZ2ZW5kb3IYAiABKAkSDQoFbW9kZWwYAyABKAkSEQoJZnJl",
            "cXVlbmN5GAQgASgDEhEKCW51bV9jb3JlcxgFIAEoAxJCCgtlbnZpcm9ubWVu",
            "dBgGIAMoCzItLnRlbnNvcmZsb3cuRGV2aWNlUHJvcGVydGllcy5FbnZpcm9u",
            "bWVudEVudHJ5EhUKDW51bV9yZWdpc3RlcnMYByABKAMSFQoNbDFfY2FjaGVf",
            "c2l6ZRgIIAEoAxIVCg1sMl9jYWNoZV9zaXplGAkgASgDEhUKDWwzX2NhY2hl",
            "X3NpemUYCiABKAMSLQolc2hhcmVkX21lbW9yeV9zaXplX3Blcl9tdWx0aXBy",
            "b2Nlc3NvchgLIAEoAxITCgttZW1vcnlfc2l6ZRgMIAEoAxIRCgliYW5kd2lk",
            "dGgYDSABKAMaMgoQRW52aXJvbm1lbnRFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAk6AjgBIk0KC05hbWVkRGV2aWNlEgwKBG5hbWUYASABKAkS",
            "MAoKcHJvcGVydGllcxgCIAEoCzIcLnRlbnNvcmZsb3cuRGV2aWNlUHJvcGVy",
            "dGllc0IbQhZEZXZpY2VQcm9wZXJ0aWVzUHJvdG9z+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.DeviceProperties), global::Tensorflow.DeviceProperties.Parser, new[]{ "Type", "Vendor", "Model", "Frequency", "NumCores", "Environment", "NumRegisters", "L1CacheSize", "L2CacheSize", "L3CacheSize", "SharedMemorySizePerMultiprocessor", "MemorySize", "Bandwidth" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.NamedDevice), global::Tensorflow.NamedDevice.Parser, new[]{ "Name", "Properties" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeviceProperties : pb::IMessage<DeviceProperties> {
    private static readonly pb::MessageParser<DeviceProperties> _parser = new pb::MessageParser<DeviceProperties>(() => new DeviceProperties());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeviceProperties> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.DevicePropertiesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceProperties() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceProperties(DeviceProperties other) : this() {
      type_ = other.type_;
      vendor_ = other.vendor_;
      model_ = other.model_;
      frequency_ = other.frequency_;
      numCores_ = other.numCores_;
      environment_ = other.environment_.Clone();
      numRegisters_ = other.numRegisters_;
      l1CacheSize_ = other.l1CacheSize_;
      l2CacheSize_ = other.l2CacheSize_;
      l3CacheSize_ = other.l3CacheSize_;
      sharedMemorySizePerMultiprocessor_ = other.sharedMemorySizePerMultiprocessor_;
      memorySize_ = other.memorySize_;
      bandwidth_ = other.bandwidth_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceProperties Clone() {
      return new DeviceProperties(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    /// <summary>
    /// Device type (CPU, GPU, ...)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vendor" field.</summary>
    public const int VendorFieldNumber = 2;
    private string vendor_ = "";
    /// <summary>
    /// Vendor (Intel, nvidia, ...)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Vendor {
      get { return vendor_; }
      set {
        vendor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "model" field.</summary>
    public const int ModelFieldNumber = 3;
    private string model_ = "";
    /// <summary>
    /// Model (Haswell, K40, ...)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Model {
      get { return model_; }
      set {
        model_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "frequency" field.</summary>
    public const int FrequencyFieldNumber = 4;
    private long frequency_;
    /// <summary>
    /// Core Frequency in Mhz
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Frequency {
      get { return frequency_; }
      set {
        frequency_ = value;
      }
    }

    /// <summary>Field number for the "num_cores" field.</summary>
    public const int NumCoresFieldNumber = 5;
    private long numCores_;
    /// <summary>
    /// Number of cores
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NumCores {
      get { return numCores_; }
      set {
        numCores_ = value;
      }
    }

    /// <summary>Field number for the "environment" field.</summary>
    public const int EnvironmentFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_environment_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 50);
    private readonly pbc::MapField<string, string> environment_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Version of the tools and libraries used with this device (e.g. gcc 4.9,
    /// cudnn 5.1)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Environment {
      get { return environment_; }
    }

    /// <summary>Field number for the "num_registers" field.</summary>
    public const int NumRegistersFieldNumber = 7;
    private long numRegisters_;
    /// <summary>
    /// Number of registers per core.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NumRegisters {
      get { return numRegisters_; }
      set {
        numRegisters_ = value;
      }
    }

    /// <summary>Field number for the "l1_cache_size" field.</summary>
    public const int L1CacheSizeFieldNumber = 8;
    private long l1CacheSize_;
    /// <summary>
    /// L1 cache size in bytes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long L1CacheSize {
      get { return l1CacheSize_; }
      set {
        l1CacheSize_ = value;
      }
    }

    /// <summary>Field number for the "l2_cache_size" field.</summary>
    public const int L2CacheSizeFieldNumber = 9;
    private long l2CacheSize_;
    /// <summary>
    /// L2 cache size in bytes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long L2CacheSize {
      get { return l2CacheSize_; }
      set {
        l2CacheSize_ = value;
      }
    }

    /// <summary>Field number for the "l3_cache_size" field.</summary>
    public const int L3CacheSizeFieldNumber = 10;
    private long l3CacheSize_;
    /// <summary>
    /// L3 cache size in bytes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long L3CacheSize {
      get { return l3CacheSize_; }
      set {
        l3CacheSize_ = value;
      }
    }

    /// <summary>Field number for the "shared_memory_size_per_multiprocessor" field.</summary>
    public const int SharedMemorySizePerMultiprocessorFieldNumber = 11;
    private long sharedMemorySizePerMultiprocessor_;
    /// <summary>
    /// Shared memory size per multiprocessor in bytes. This field is
    /// applicable to GPUs only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SharedMemorySizePerMultiprocessor {
      get { return sharedMemorySizePerMultiprocessor_; }
      set {
        sharedMemorySizePerMultiprocessor_ = value;
      }
    }

    /// <summary>Field number for the "memory_size" field.</summary>
    public const int MemorySizeFieldNumber = 12;
    private long memorySize_;
    /// <summary>
    /// Memory size in bytes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MemorySize {
      get { return memorySize_; }
      set {
        memorySize_ = value;
      }
    }

    /// <summary>Field number for the "bandwidth" field.</summary>
    public const int BandwidthFieldNumber = 13;
    private long bandwidth_;
    /// <summary>
    /// Memory bandwidth in KB/s
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Bandwidth {
      get { return bandwidth_; }
      set {
        bandwidth_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeviceProperties);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeviceProperties other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Vendor != other.Vendor) return false;
      if (Model != other.Model) return false;
      if (Frequency != other.Frequency) return false;
      if (NumCores != other.NumCores) return false;
      if (!Environment.Equals(other.Environment)) return false;
      if (NumRegisters != other.NumRegisters) return false;
      if (L1CacheSize != other.L1CacheSize) return false;
      if (L2CacheSize != other.L2CacheSize) return false;
      if (L3CacheSize != other.L3CacheSize) return false;
      if (SharedMemorySizePerMultiprocessor != other.SharedMemorySizePerMultiprocessor) return false;
      if (MemorySize != other.MemorySize) return false;
      if (Bandwidth != other.Bandwidth) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Vendor.Length != 0) hash ^= Vendor.GetHashCode();
      if (Model.Length != 0) hash ^= Model.GetHashCode();
      if (Frequency != 0L) hash ^= Frequency.GetHashCode();
      if (NumCores != 0L) hash ^= NumCores.GetHashCode();
      hash ^= Environment.GetHashCode();
      if (NumRegisters != 0L) hash ^= NumRegisters.GetHashCode();
      if (L1CacheSize != 0L) hash ^= L1CacheSize.GetHashCode();
      if (L2CacheSize != 0L) hash ^= L2CacheSize.GetHashCode();
      if (L3CacheSize != 0L) hash ^= L3CacheSize.GetHashCode();
      if (SharedMemorySizePerMultiprocessor != 0L) hash ^= SharedMemorySizePerMultiprocessor.GetHashCode();
      if (MemorySize != 0L) hash ^= MemorySize.GetHashCode();
      if (Bandwidth != 0L) hash ^= Bandwidth.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Vendor.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Vendor);
      }
      if (Model.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Model);
      }
      if (Frequency != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Frequency);
      }
      if (NumCores != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(NumCores);
      }
      environment_.WriteTo(output, _map_environment_codec);
      if (NumRegisters != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(NumRegisters);
      }
      if (L1CacheSize != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(L1CacheSize);
      }
      if (L2CacheSize != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(L2CacheSize);
      }
      if (L3CacheSize != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(L3CacheSize);
      }
      if (SharedMemorySizePerMultiprocessor != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(SharedMemorySizePerMultiprocessor);
      }
      if (MemorySize != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(MemorySize);
      }
      if (Bandwidth != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(Bandwidth);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Vendor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Vendor);
      }
      if (Model.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Model);
      }
      if (Frequency != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Frequency);
      }
      if (NumCores != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NumCores);
      }
      size += environment_.CalculateSize(_map_environment_codec);
      if (NumRegisters != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NumRegisters);
      }
      if (L1CacheSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(L1CacheSize);
      }
      if (L2CacheSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(L2CacheSize);
      }
      if (L3CacheSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(L3CacheSize);
      }
      if (SharedMemorySizePerMultiprocessor != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SharedMemorySizePerMultiprocessor);
      }
      if (MemorySize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MemorySize);
      }
      if (Bandwidth != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Bandwidth);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeviceProperties other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Vendor.Length != 0) {
        Vendor = other.Vendor;
      }
      if (other.Model.Length != 0) {
        Model = other.Model;
      }
      if (other.Frequency != 0L) {
        Frequency = other.Frequency;
      }
      if (other.NumCores != 0L) {
        NumCores = other.NumCores;
      }
      environment_.Add(other.environment_);
      if (other.NumRegisters != 0L) {
        NumRegisters = other.NumRegisters;
      }
      if (other.L1CacheSize != 0L) {
        L1CacheSize = other.L1CacheSize;
      }
      if (other.L2CacheSize != 0L) {
        L2CacheSize = other.L2CacheSize;
      }
      if (other.L3CacheSize != 0L) {
        L3CacheSize = other.L3CacheSize;
      }
      if (other.SharedMemorySizePerMultiprocessor != 0L) {
        SharedMemorySizePerMultiprocessor = other.SharedMemorySizePerMultiprocessor;
      }
      if (other.MemorySize != 0L) {
        MemorySize = other.MemorySize;
      }
      if (other.Bandwidth != 0L) {
        Bandwidth = other.Bandwidth;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Type = input.ReadString();
            break;
          }
          case 18: {
            Vendor = input.ReadString();
            break;
          }
          case 26: {
            Model = input.ReadString();
            break;
          }
          case 32: {
            Frequency = input.ReadInt64();
            break;
          }
          case 40: {
            NumCores = input.ReadInt64();
            break;
          }
          case 50: {
            environment_.AddEntriesFrom(input, _map_environment_codec);
            break;
          }
          case 56: {
            NumRegisters = input.ReadInt64();
            break;
          }
          case 64: {
            L1CacheSize = input.ReadInt64();
            break;
          }
          case 72: {
            L2CacheSize = input.ReadInt64();
            break;
          }
          case 80: {
            L3CacheSize = input.ReadInt64();
            break;
          }
          case 88: {
            SharedMemorySizePerMultiprocessor = input.ReadInt64();
            break;
          }
          case 96: {
            MemorySize = input.ReadInt64();
            break;
          }
          case 104: {
            Bandwidth = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NamedDevice : pb::IMessage<NamedDevice> {
    private static readonly pb::MessageParser<NamedDevice> _parser = new pb::MessageParser<NamedDevice>(() => new NamedDevice());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NamedDevice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.DevicePropertiesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NamedDevice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NamedDevice(NamedDevice other) : this() {
      name_ = other.name_;
      Properties = other.properties_ != null ? other.Properties.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NamedDevice Clone() {
      return new NamedDevice(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 2;
    private global::Tensorflow.DeviceProperties properties_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.DeviceProperties Properties {
      get { return properties_; }
      set {
        properties_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NamedDevice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NamedDevice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Properties, other.Properties)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (properties_ != null) hash ^= Properties.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (properties_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Properties);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (properties_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Properties);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NamedDevice other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.properties_ != null) {
        if (properties_ == null) {
          properties_ = new global::Tensorflow.DeviceProperties();
        }
        Properties.MergeFrom(other.Properties);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (properties_ == null) {
              properties_ = new global::Tensorflow.DeviceProperties();
            }
            input.ReadMessage(properties_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
