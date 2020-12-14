// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/example/example_parser_configuration.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/example/example_parser_configuration.proto</summary>
  public static partial class ExampleParserConfigurationReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/example/example_parser_configuration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExampleParserConfigurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjp0ZW5zb3JmbG93L2NvcmUvZXhhbXBsZS9leGFtcGxlX3BhcnNlcl9jb25m",
            "aWd1cmF0aW9uLnByb3RvEgp0ZW5zb3JmbG93Gix0ZW5zb3JmbG93L2NvcmUv",
            "ZnJhbWV3b3JrL3RlbnNvcl9zaGFwZS5wcm90bxomdGVuc29yZmxvdy9jb3Jl",
            "L2ZyYW1ld29yay90ZW5zb3IucHJvdG8aJXRlbnNvcmZsb3cvY29yZS9mcmFt",
            "ZXdvcmsvdHlwZXMucHJvdG8iowEKElZhckxlbkZlYXR1cmVQcm90bxIjCgVk",
            "dHlwZRgBIAEoDjIULnRlbnNvcmZsb3cuRGF0YVR5cGUSIQoZdmFsdWVzX291",
            "dHB1dF90ZW5zb3JfbmFtZRgCIAEoCRIiChppbmRpY2VzX291dHB1dF90ZW5z",
            "b3JfbmFtZRgDIAEoCRIhChlzaGFwZXNfb3V0cHV0X3RlbnNvcl9uYW1lGAQg",
            "ASgJIrsBChRGaXhlZExlbkZlYXR1cmVQcm90bxIjCgVkdHlwZRgBIAEoDjIU",
            "LnRlbnNvcmZsb3cuRGF0YVR5cGUSKwoFc2hhcGUYAiABKAsyHC50ZW5zb3Jm",
            "bG93LlRlbnNvclNoYXBlUHJvdG8SLgoNZGVmYXVsdF92YWx1ZRgDIAEoCzIX",
            "LnRlbnNvcmZsb3cuVGVuc29yUHJvdG8SIQoZdmFsdWVzX291dHB1dF90ZW5z",
            "b3JfbmFtZRgEIAEoCSKaAQoURmVhdHVyZUNvbmZpZ3VyYXRpb24SPQoRZml4",
            "ZWRfbGVuX2ZlYXR1cmUYASABKAsyIC50ZW5zb3JmbG93LkZpeGVkTGVuRmVh",
            "dHVyZVByb3RvSAASOQoPdmFyX2xlbl9mZWF0dXJlGAIgASgLMh4udGVuc29y",
            "Zmxvdy5WYXJMZW5GZWF0dXJlUHJvdG9IAEIICgZjb25maWcivgEKGkV4YW1w",
            "bGVQYXJzZXJDb25maWd1cmF0aW9uEksKC2ZlYXR1cmVfbWFwGAEgAygLMjYu",
            "dGVuc29yZmxvdy5FeGFtcGxlUGFyc2VyQ29uZmlndXJhdGlvbi5GZWF0dXJl",
            "TWFwRW50cnkaUwoPRmVhdHVyZU1hcEVudHJ5EgsKA2tleRgBIAEoCRIvCgV2",
            "YWx1ZRgCIAEoCzIgLnRlbnNvcmZsb3cuRmVhdHVyZUNvbmZpZ3VyYXRpb246",
            "AjgBQj8KFm9yZy50ZW5zb3JmbG93LmV4YW1wbGVCIEV4YW1wbGVQYXJzZXJD",
            "b25maWd1cmF0aW9uUHJvdG9zUAH4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.TensorShapeReflection.Descriptor, global::Tensorflow.TensorReflection.Descriptor, global::Tensorflow.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.VarLenFeatureProto), global::Tensorflow.VarLenFeatureProto.Parser, new[]{ "Dtype", "ValuesOutputTensorName", "IndicesOutputTensorName", "ShapesOutputTensorName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.FixedLenFeatureProto), global::Tensorflow.FixedLenFeatureProto.Parser, new[]{ "Dtype", "Shape", "DefaultValue", "ValuesOutputTensorName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.FeatureConfiguration), global::Tensorflow.FeatureConfiguration.Parser, new[]{ "FixedLenFeature", "VarLenFeature" }, new[]{ "Config" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.ExampleParserConfiguration), global::Tensorflow.ExampleParserConfiguration.Parser, new[]{ "FeatureMap" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VarLenFeatureProto : pb::IMessage<VarLenFeatureProto> {
    private static readonly pb::MessageParser<VarLenFeatureProto> _parser = new pb::MessageParser<VarLenFeatureProto>(() => new VarLenFeatureProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VarLenFeatureProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ExampleParserConfigurationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VarLenFeatureProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VarLenFeatureProto(VarLenFeatureProto other) : this() {
      dtype_ = other.dtype_;
      valuesOutputTensorName_ = other.valuesOutputTensorName_;
      indicesOutputTensorName_ = other.indicesOutputTensorName_;
      shapesOutputTensorName_ = other.shapesOutputTensorName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VarLenFeatureProto Clone() {
      return new VarLenFeatureProto(this);
    }

    /// <summary>Field number for the "dtype" field.</summary>
    public const int DtypeFieldNumber = 1;
    private global::Tensorflow.DataType dtype_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.DataType Dtype {
      get { return dtype_; }
      set {
        dtype_ = value;
      }
    }

    /// <summary>Field number for the "values_output_tensor_name" field.</summary>
    public const int ValuesOutputTensorNameFieldNumber = 2;
    private string valuesOutputTensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValuesOutputTensorName {
      get { return valuesOutputTensorName_; }
      set {
        valuesOutputTensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "indices_output_tensor_name" field.</summary>
    public const int IndicesOutputTensorNameFieldNumber = 3;
    private string indicesOutputTensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IndicesOutputTensorName {
      get { return indicesOutputTensorName_; }
      set {
        indicesOutputTensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shapes_output_tensor_name" field.</summary>
    public const int ShapesOutputTensorNameFieldNumber = 4;
    private string shapesOutputTensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ShapesOutputTensorName {
      get { return shapesOutputTensorName_; }
      set {
        shapesOutputTensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VarLenFeatureProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VarLenFeatureProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Dtype != other.Dtype) return false;
      if (ValuesOutputTensorName != other.ValuesOutputTensorName) return false;
      if (IndicesOutputTensorName != other.IndicesOutputTensorName) return false;
      if (ShapesOutputTensorName != other.ShapesOutputTensorName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Dtype != 0) hash ^= Dtype.GetHashCode();
      if (ValuesOutputTensorName.Length != 0) hash ^= ValuesOutputTensorName.GetHashCode();
      if (IndicesOutputTensorName.Length != 0) hash ^= IndicesOutputTensorName.GetHashCode();
      if (ShapesOutputTensorName.Length != 0) hash ^= ShapesOutputTensorName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Dtype != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Dtype);
      }
      if (ValuesOutputTensorName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ValuesOutputTensorName);
      }
      if (IndicesOutputTensorName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IndicesOutputTensorName);
      }
      if (ShapesOutputTensorName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ShapesOutputTensorName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Dtype != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Dtype);
      }
      if (ValuesOutputTensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValuesOutputTensorName);
      }
      if (IndicesOutputTensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IndicesOutputTensorName);
      }
      if (ShapesOutputTensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShapesOutputTensorName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VarLenFeatureProto other) {
      if (other == null) {
        return;
      }
      if (other.Dtype != 0) {
        Dtype = other.Dtype;
      }
      if (other.ValuesOutputTensorName.Length != 0) {
        ValuesOutputTensorName = other.ValuesOutputTensorName;
      }
      if (other.IndicesOutputTensorName.Length != 0) {
        IndicesOutputTensorName = other.IndicesOutputTensorName;
      }
      if (other.ShapesOutputTensorName.Length != 0) {
        ShapesOutputTensorName = other.ShapesOutputTensorName;
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
          case 8: {
            dtype_ = (global::Tensorflow.DataType) input.ReadEnum();
            break;
          }
          case 18: {
            ValuesOutputTensorName = input.ReadString();
            break;
          }
          case 26: {
            IndicesOutputTensorName = input.ReadString();
            break;
          }
          case 34: {
            ShapesOutputTensorName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FixedLenFeatureProto : pb::IMessage<FixedLenFeatureProto> {
    private static readonly pb::MessageParser<FixedLenFeatureProto> _parser = new pb::MessageParser<FixedLenFeatureProto>(() => new FixedLenFeatureProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FixedLenFeatureProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ExampleParserConfigurationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FixedLenFeatureProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FixedLenFeatureProto(FixedLenFeatureProto other) : this() {
      dtype_ = other.dtype_;
      Shape = other.shape_ != null ? other.Shape.Clone() : null;
      DefaultValue = other.defaultValue_ != null ? other.DefaultValue.Clone() : null;
      valuesOutputTensorName_ = other.valuesOutputTensorName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FixedLenFeatureProto Clone() {
      return new FixedLenFeatureProto(this);
    }

    /// <summary>Field number for the "dtype" field.</summary>
    public const int DtypeFieldNumber = 1;
    private global::Tensorflow.DataType dtype_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.DataType Dtype {
      get { return dtype_; }
      set {
        dtype_ = value;
      }
    }

    /// <summary>Field number for the "shape" field.</summary>
    public const int ShapeFieldNumber = 2;
    private global::Tensorflow.TensorShapeProto shape_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.TensorShapeProto Shape {
      get { return shape_; }
      set {
        shape_ = value;
      }
    }

    /// <summary>Field number for the "default_value" field.</summary>
    public const int DefaultValueFieldNumber = 3;
    private global::Tensorflow.TensorProto defaultValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.TensorProto DefaultValue {
      get { return defaultValue_; }
      set {
        defaultValue_ = value;
      }
    }

    /// <summary>Field number for the "values_output_tensor_name" field.</summary>
    public const int ValuesOutputTensorNameFieldNumber = 4;
    private string valuesOutputTensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValuesOutputTensorName {
      get { return valuesOutputTensorName_; }
      set {
        valuesOutputTensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FixedLenFeatureProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FixedLenFeatureProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Dtype != other.Dtype) return false;
      if (!object.Equals(Shape, other.Shape)) return false;
      if (!object.Equals(DefaultValue, other.DefaultValue)) return false;
      if (ValuesOutputTensorName != other.ValuesOutputTensorName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Dtype != 0) hash ^= Dtype.GetHashCode();
      if (shape_ != null) hash ^= Shape.GetHashCode();
      if (defaultValue_ != null) hash ^= DefaultValue.GetHashCode();
      if (ValuesOutputTensorName.Length != 0) hash ^= ValuesOutputTensorName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Dtype != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Dtype);
      }
      if (shape_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Shape);
      }
      if (defaultValue_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DefaultValue);
      }
      if (ValuesOutputTensorName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ValuesOutputTensorName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Dtype != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Dtype);
      }
      if (shape_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Shape);
      }
      if (defaultValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DefaultValue);
      }
      if (ValuesOutputTensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValuesOutputTensorName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FixedLenFeatureProto other) {
      if (other == null) {
        return;
      }
      if (other.Dtype != 0) {
        Dtype = other.Dtype;
      }
      if (other.shape_ != null) {
        if (shape_ == null) {
          shape_ = new global::Tensorflow.TensorShapeProto();
        }
        Shape.MergeFrom(other.Shape);
      }
      if (other.defaultValue_ != null) {
        if (defaultValue_ == null) {
          defaultValue_ = new global::Tensorflow.TensorProto();
        }
        DefaultValue.MergeFrom(other.DefaultValue);
      }
      if (other.ValuesOutputTensorName.Length != 0) {
        ValuesOutputTensorName = other.ValuesOutputTensorName;
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
          case 8: {
            dtype_ = (global::Tensorflow.DataType) input.ReadEnum();
            break;
          }
          case 18: {
            if (shape_ == null) {
              shape_ = new global::Tensorflow.TensorShapeProto();
            }
            input.ReadMessage(shape_);
            break;
          }
          case 26: {
            if (defaultValue_ == null) {
              defaultValue_ = new global::Tensorflow.TensorProto();
            }
            input.ReadMessage(defaultValue_);
            break;
          }
          case 34: {
            ValuesOutputTensorName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FeatureConfiguration : pb::IMessage<FeatureConfiguration> {
    private static readonly pb::MessageParser<FeatureConfiguration> _parser = new pb::MessageParser<FeatureConfiguration>(() => new FeatureConfiguration());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeatureConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ExampleParserConfigurationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureConfiguration(FeatureConfiguration other) : this() {
      switch (other.ConfigCase) {
        case ConfigOneofCase.FixedLenFeature:
          FixedLenFeature = other.FixedLenFeature.Clone();
          break;
        case ConfigOneofCase.VarLenFeature:
          VarLenFeature = other.VarLenFeature.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureConfiguration Clone() {
      return new FeatureConfiguration(this);
    }

    /// <summary>Field number for the "fixed_len_feature" field.</summary>
    public const int FixedLenFeatureFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.FixedLenFeatureProto FixedLenFeature {
      get { return configCase_ == ConfigOneofCase.FixedLenFeature ? (global::Tensorflow.FixedLenFeatureProto) config_ : null; }
      set {
        config_ = value;
        configCase_ = value == null ? ConfigOneofCase.None : ConfigOneofCase.FixedLenFeature;
      }
    }

    /// <summary>Field number for the "var_len_feature" field.</summary>
    public const int VarLenFeatureFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.VarLenFeatureProto VarLenFeature {
      get { return configCase_ == ConfigOneofCase.VarLenFeature ? (global::Tensorflow.VarLenFeatureProto) config_ : null; }
      set {
        config_ = value;
        configCase_ = value == null ? ConfigOneofCase.None : ConfigOneofCase.VarLenFeature;
      }
    }

    private object config_;
    /// <summary>Enum of possible cases for the "config" oneof.</summary>
    public enum ConfigOneofCase {
      None = 0,
      FixedLenFeature = 1,
      VarLenFeature = 2,
    }
    private ConfigOneofCase configCase_ = ConfigOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigOneofCase ConfigCase {
      get { return configCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConfig() {
      configCase_ = ConfigOneofCase.None;
      config_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeatureConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeatureConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FixedLenFeature, other.FixedLenFeature)) return false;
      if (!object.Equals(VarLenFeature, other.VarLenFeature)) return false;
      if (ConfigCase != other.ConfigCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (configCase_ == ConfigOneofCase.FixedLenFeature) hash ^= FixedLenFeature.GetHashCode();
      if (configCase_ == ConfigOneofCase.VarLenFeature) hash ^= VarLenFeature.GetHashCode();
      hash ^= (int) configCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (configCase_ == ConfigOneofCase.FixedLenFeature) {
        output.WriteRawTag(10);
        output.WriteMessage(FixedLenFeature);
      }
      if (configCase_ == ConfigOneofCase.VarLenFeature) {
        output.WriteRawTag(18);
        output.WriteMessage(VarLenFeature);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (configCase_ == ConfigOneofCase.FixedLenFeature) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FixedLenFeature);
      }
      if (configCase_ == ConfigOneofCase.VarLenFeature) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VarLenFeature);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeatureConfiguration other) {
      if (other == null) {
        return;
      }
      switch (other.ConfigCase) {
        case ConfigOneofCase.FixedLenFeature:
          if (FixedLenFeature == null) {
            FixedLenFeature = new global::Tensorflow.FixedLenFeatureProto();
          }
          FixedLenFeature.MergeFrom(other.FixedLenFeature);
          break;
        case ConfigOneofCase.VarLenFeature:
          if (VarLenFeature == null) {
            VarLenFeature = new global::Tensorflow.VarLenFeatureProto();
          }
          VarLenFeature.MergeFrom(other.VarLenFeature);
          break;
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
            global::Tensorflow.FixedLenFeatureProto subBuilder = new global::Tensorflow.FixedLenFeatureProto();
            if (configCase_ == ConfigOneofCase.FixedLenFeature) {
              subBuilder.MergeFrom(FixedLenFeature);
            }
            input.ReadMessage(subBuilder);
            FixedLenFeature = subBuilder;
            break;
          }
          case 18: {
            global::Tensorflow.VarLenFeatureProto subBuilder = new global::Tensorflow.VarLenFeatureProto();
            if (configCase_ == ConfigOneofCase.VarLenFeature) {
              subBuilder.MergeFrom(VarLenFeature);
            }
            input.ReadMessage(subBuilder);
            VarLenFeature = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExampleParserConfiguration : pb::IMessage<ExampleParserConfiguration> {
    private static readonly pb::MessageParser<ExampleParserConfiguration> _parser = new pb::MessageParser<ExampleParserConfiguration>(() => new ExampleParserConfiguration());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExampleParserConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ExampleParserConfigurationReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExampleParserConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExampleParserConfiguration(ExampleParserConfiguration other) : this() {
      featureMap_ = other.featureMap_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExampleParserConfiguration Clone() {
      return new ExampleParserConfiguration(this);
    }

    /// <summary>Field number for the "feature_map" field.</summary>
    public const int FeatureMapFieldNumber = 1;
    private static readonly pbc::MapField<string, global::Tensorflow.FeatureConfiguration>.Codec _map_featureMap_codec
        = new pbc::MapField<string, global::Tensorflow.FeatureConfiguration>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.FeatureConfiguration.Parser), 10);
    private readonly pbc::MapField<string, global::Tensorflow.FeatureConfiguration> featureMap_ = new pbc::MapField<string, global::Tensorflow.FeatureConfiguration>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.FeatureConfiguration> FeatureMap {
      get { return featureMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExampleParserConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExampleParserConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!FeatureMap.Equals(other.FeatureMap)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= FeatureMap.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      featureMap_.WriteTo(output, _map_featureMap_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += featureMap_.CalculateSize(_map_featureMap_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExampleParserConfiguration other) {
      if (other == null) {
        return;
      }
      featureMap_.Add(other.featureMap_);
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
            featureMap_.AddEntriesFrom(input, _map_featureMap_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code