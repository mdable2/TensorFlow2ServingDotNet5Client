// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: inference.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Serving {

  /// <summary>Holder for reflection information generated from inference.proto</summary>
  public static partial class InferenceReflection {

    #region Descriptor
    /// <summary>File descriptor for inference.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InferenceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9pbmZlcmVuY2UucHJvdG8SEnRlbnNvcmZsb3cuc2VydmluZxoUY2xhc3Np",
            "ZmljYXRpb24ucHJvdG8aC2lucHV0LnByb3RvGgttb2RlbC5wcm90bxoQcmVn",
            "cmVzc2lvbi5wcm90byJXCg1JbmZlcmVuY2VUYXNrEjEKCm1vZGVsX3NwZWMY",
            "ASABKAsyHS50ZW5zb3JmbG93LnNlcnZpbmcuTW9kZWxTcGVjEhMKC21ldGhv",
            "ZF9uYW1lGAIgASgJItwBCg9JbmZlcmVuY2VSZXN1bHQSMQoKbW9kZWxfc3Bl",
            "YxgBIAEoCzIdLnRlbnNvcmZsb3cuc2VydmluZy5Nb2RlbFNwZWMSSQoVY2xh",
            "c3NpZmljYXRpb25fcmVzdWx0GAIgASgLMigudGVuc29yZmxvdy5zZXJ2aW5n",
            "LkNsYXNzaWZpY2F0aW9uUmVzdWx0SAASQQoRcmVncmVzc2lvbl9yZXN1bHQY",
            "AyABKAsyJC50ZW5zb3JmbG93LnNlcnZpbmcuUmVncmVzc2lvblJlc3VsdEgA",
            "QggKBnJlc3VsdCJzChVNdWx0aUluZmVyZW5jZVJlcXVlc3QSMAoFdGFza3MY",
            "ASADKAsyIS50ZW5zb3JmbG93LnNlcnZpbmcuSW5mZXJlbmNlVGFzaxIoCgVp",
            "bnB1dBgCIAEoCzIZLnRlbnNvcmZsb3cuc2VydmluZy5JbnB1dCJOChZNdWx0",
            "aUluZmVyZW5jZVJlc3BvbnNlEjQKB3Jlc3VsdHMYASADKAsyIy50ZW5zb3Jm",
            "bG93LnNlcnZpbmcuSW5mZXJlbmNlUmVzdWx0QgP4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.Serving.ClassificationReflection.Descriptor, global::Tensorflow.Serving.InputReflection.Descriptor, global::Tensorflow.Serving.ModelReflection.Descriptor, global::Tensorflow.Serving.RegressionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.InferenceTask), global::Tensorflow.Serving.InferenceTask.Parser, new[]{ "ModelSpec", "MethodName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.InferenceResult), global::Tensorflow.Serving.InferenceResult.Parser, new[]{ "ModelSpec", "ClassificationResult", "RegressionResult" }, new[]{ "Result" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.MultiInferenceRequest), global::Tensorflow.Serving.MultiInferenceRequest.Parser, new[]{ "Tasks", "Input" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.MultiInferenceResponse), global::Tensorflow.Serving.MultiInferenceResponse.Parser, new[]{ "Results" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Inference request such as classification, regression, etc...
  /// </summary>
  public sealed partial class InferenceTask : pb::IMessage<InferenceTask> {
    private static readonly pb::MessageParser<InferenceTask> _parser = new pb::MessageParser<InferenceTask>(() => new InferenceTask());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InferenceTask> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.InferenceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InferenceTask() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InferenceTask(InferenceTask other) : this() {
      ModelSpec = other.modelSpec_ != null ? other.ModelSpec.Clone() : null;
      methodName_ = other.methodName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InferenceTask Clone() {
      return new InferenceTask(this);
    }

    /// <summary>Field number for the "model_spec" field.</summary>
    public const int ModelSpecFieldNumber = 1;
    private global::Tensorflow.Serving.ModelSpec modelSpec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelSpec ModelSpec {
      get { return modelSpec_; }
      set {
        modelSpec_ = value;
      }
    }

    /// <summary>Field number for the "method_name" field.</summary>
    public const int MethodNameFieldNumber = 2;
    private string methodName_ = "";
    /// <summary>
    /// Signature's method_name. Should be one of the method names defined in
    /// third_party/tensorflow/python/saved_model/signature_constants.py.
    /// e.g. "tensorflow/serving/classify".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MethodName {
      get { return methodName_; }
      set {
        methodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InferenceTask);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InferenceTask other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModelSpec, other.ModelSpec)) return false;
      if (MethodName != other.MethodName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (modelSpec_ != null) hash ^= ModelSpec.GetHashCode();
      if (MethodName.Length != 0) hash ^= MethodName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (modelSpec_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ModelSpec);
      }
      if (MethodName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MethodName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (modelSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelSpec);
      }
      if (MethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MethodName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InferenceTask other) {
      if (other == null) {
        return;
      }
      if (other.modelSpec_ != null) {
        if (modelSpec_ == null) {
          modelSpec_ = new global::Tensorflow.Serving.ModelSpec();
        }
        ModelSpec.MergeFrom(other.ModelSpec);
      }
      if (other.MethodName.Length != 0) {
        MethodName = other.MethodName;
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
            if (modelSpec_ == null) {
              modelSpec_ = new global::Tensorflow.Serving.ModelSpec();
            }
            input.ReadMessage(modelSpec_);
            break;
          }
          case 18: {
            MethodName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Inference result, matches the type of request or is an error.
  /// </summary>
  public sealed partial class InferenceResult : pb::IMessage<InferenceResult> {
    private static readonly pb::MessageParser<InferenceResult> _parser = new pb::MessageParser<InferenceResult>(() => new InferenceResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InferenceResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.InferenceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InferenceResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InferenceResult(InferenceResult other) : this() {
      ModelSpec = other.modelSpec_ != null ? other.ModelSpec.Clone() : null;
      switch (other.ResultCase) {
        case ResultOneofCase.ClassificationResult:
          ClassificationResult = other.ClassificationResult.Clone();
          break;
        case ResultOneofCase.RegressionResult:
          RegressionResult = other.RegressionResult.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InferenceResult Clone() {
      return new InferenceResult(this);
    }

    /// <summary>Field number for the "model_spec" field.</summary>
    public const int ModelSpecFieldNumber = 1;
    private global::Tensorflow.Serving.ModelSpec modelSpec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelSpec ModelSpec {
      get { return modelSpec_; }
      set {
        modelSpec_ = value;
      }
    }

    /// <summary>Field number for the "classification_result" field.</summary>
    public const int ClassificationResultFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ClassificationResult ClassificationResult {
      get { return resultCase_ == ResultOneofCase.ClassificationResult ? (global::Tensorflow.Serving.ClassificationResult) result_ : null; }
      set {
        result_ = value;
        resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.ClassificationResult;
      }
    }

    /// <summary>Field number for the "regression_result" field.</summary>
    public const int RegressionResultFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.RegressionResult RegressionResult {
      get { return resultCase_ == ResultOneofCase.RegressionResult ? (global::Tensorflow.Serving.RegressionResult) result_ : null; }
      set {
        result_ = value;
        resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.RegressionResult;
      }
    }

    private object result_;
    /// <summary>Enum of possible cases for the "result" oneof.</summary>
    public enum ResultOneofCase {
      None = 0,
      ClassificationResult = 2,
      RegressionResult = 3,
    }
    private ResultOneofCase resultCase_ = ResultOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultOneofCase ResultCase {
      get { return resultCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearResult() {
      resultCase_ = ResultOneofCase.None;
      result_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InferenceResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InferenceResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModelSpec, other.ModelSpec)) return false;
      if (!object.Equals(ClassificationResult, other.ClassificationResult)) return false;
      if (!object.Equals(RegressionResult, other.RegressionResult)) return false;
      if (ResultCase != other.ResultCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (modelSpec_ != null) hash ^= ModelSpec.GetHashCode();
      if (resultCase_ == ResultOneofCase.ClassificationResult) hash ^= ClassificationResult.GetHashCode();
      if (resultCase_ == ResultOneofCase.RegressionResult) hash ^= RegressionResult.GetHashCode();
      hash ^= (int) resultCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (modelSpec_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ModelSpec);
      }
      if (resultCase_ == ResultOneofCase.ClassificationResult) {
        output.WriteRawTag(18);
        output.WriteMessage(ClassificationResult);
      }
      if (resultCase_ == ResultOneofCase.RegressionResult) {
        output.WriteRawTag(26);
        output.WriteMessage(RegressionResult);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (modelSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelSpec);
      }
      if (resultCase_ == ResultOneofCase.ClassificationResult) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClassificationResult);
      }
      if (resultCase_ == ResultOneofCase.RegressionResult) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegressionResult);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InferenceResult other) {
      if (other == null) {
        return;
      }
      if (other.modelSpec_ != null) {
        if (modelSpec_ == null) {
          modelSpec_ = new global::Tensorflow.Serving.ModelSpec();
        }
        ModelSpec.MergeFrom(other.ModelSpec);
      }
      switch (other.ResultCase) {
        case ResultOneofCase.ClassificationResult:
          if (ClassificationResult == null) {
            ClassificationResult = new global::Tensorflow.Serving.ClassificationResult();
          }
          ClassificationResult.MergeFrom(other.ClassificationResult);
          break;
        case ResultOneofCase.RegressionResult:
          if (RegressionResult == null) {
            RegressionResult = new global::Tensorflow.Serving.RegressionResult();
          }
          RegressionResult.MergeFrom(other.RegressionResult);
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
            if (modelSpec_ == null) {
              modelSpec_ = new global::Tensorflow.Serving.ModelSpec();
            }
            input.ReadMessage(modelSpec_);
            break;
          }
          case 18: {
            global::Tensorflow.Serving.ClassificationResult subBuilder = new global::Tensorflow.Serving.ClassificationResult();
            if (resultCase_ == ResultOneofCase.ClassificationResult) {
              subBuilder.MergeFrom(ClassificationResult);
            }
            input.ReadMessage(subBuilder);
            ClassificationResult = subBuilder;
            break;
          }
          case 26: {
            global::Tensorflow.Serving.RegressionResult subBuilder = new global::Tensorflow.Serving.RegressionResult();
            if (resultCase_ == ResultOneofCase.RegressionResult) {
              subBuilder.MergeFrom(RegressionResult);
            }
            input.ReadMessage(subBuilder);
            RegressionResult = subBuilder;
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Inference request containing one or more requests.
  /// </summary>
  public sealed partial class MultiInferenceRequest : pb::IMessage<MultiInferenceRequest> {
    private static readonly pb::MessageParser<MultiInferenceRequest> _parser = new pb::MessageParser<MultiInferenceRequest>(() => new MultiInferenceRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MultiInferenceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.InferenceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiInferenceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiInferenceRequest(MultiInferenceRequest other) : this() {
      tasks_ = other.tasks_.Clone();
      Input = other.input_ != null ? other.Input.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiInferenceRequest Clone() {
      return new MultiInferenceRequest(this);
    }

    /// <summary>Field number for the "tasks" field.</summary>
    public const int TasksFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.Serving.InferenceTask> _repeated_tasks_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.Serving.InferenceTask.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.Serving.InferenceTask> tasks_ = new pbc::RepeatedField<global::Tensorflow.Serving.InferenceTask>();
    /// <summary>
    /// Inference tasks.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.Serving.InferenceTask> Tasks {
      get { return tasks_; }
    }

    /// <summary>Field number for the "input" field.</summary>
    public const int InputFieldNumber = 2;
    private global::Tensorflow.Serving.Input input_;
    /// <summary>
    /// Input data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.Input Input {
      get { return input_; }
      set {
        input_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MultiInferenceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MultiInferenceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tasks_.Equals(other.tasks_)) return false;
      if (!object.Equals(Input, other.Input)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tasks_.GetHashCode();
      if (input_ != null) hash ^= Input.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      tasks_.WriteTo(output, _repeated_tasks_codec);
      if (input_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Input);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += tasks_.CalculateSize(_repeated_tasks_codec);
      if (input_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Input);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MultiInferenceRequest other) {
      if (other == null) {
        return;
      }
      tasks_.Add(other.tasks_);
      if (other.input_ != null) {
        if (input_ == null) {
          input_ = new global::Tensorflow.Serving.Input();
        }
        Input.MergeFrom(other.Input);
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
            tasks_.AddEntriesFrom(input, _repeated_tasks_codec);
            break;
          }
          case 18: {
            if (input_ == null) {
              input_ = new global::Tensorflow.Serving.Input();
            }
            input.ReadMessage(input_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Inference request containing one or more responses.
  /// </summary>
  public sealed partial class MultiInferenceResponse : pb::IMessage<MultiInferenceResponse> {
    private static readonly pb::MessageParser<MultiInferenceResponse> _parser = new pb::MessageParser<MultiInferenceResponse>(() => new MultiInferenceResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MultiInferenceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.InferenceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiInferenceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiInferenceResponse(MultiInferenceResponse other) : this() {
      results_ = other.results_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MultiInferenceResponse Clone() {
      return new MultiInferenceResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.Serving.InferenceResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.Serving.InferenceResult.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.Serving.InferenceResult> results_ = new pbc::RepeatedField<global::Tensorflow.Serving.InferenceResult>();
    /// <summary>
    /// List of results; one for each InferenceTask in the request, returned in the
    /// same order as the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.Serving.InferenceResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MultiInferenceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MultiInferenceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      results_.WriteTo(output, _repeated_results_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MultiInferenceResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
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
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
