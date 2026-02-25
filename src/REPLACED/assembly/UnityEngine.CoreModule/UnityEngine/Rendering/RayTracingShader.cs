// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RayTracingShader
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class RayTracingShader(System.IntPtr pointer) : UnityEngine.Object(pointer)
{
  private static readonly RayTracingShader.get_maxRecursionDepth_InjectedDelegate get_maxRecursionDepth_InjectedDelegateField;
  private static readonly RayTracingShader.SetFloat_InjectedDelegate SetFloat_InjectedDelegateField;
  private static readonly RayTracingShader.SetInt_InjectedDelegate SetInt_InjectedDelegateField;
  private static readonly RayTracingShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField;
  private static readonly RayTracingShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;
  private static readonly RayTracingShader.SetFloatArray_InjectedDelegate SetFloatArray_InjectedDelegateField;
  private static readonly RayTracingShader.SetIntArray_InjectedDelegate SetIntArray_InjectedDelegateField;
  private static readonly RayTracingShader.SetVectorArray_InjectedDelegate SetVectorArray_InjectedDelegateField;
  private static readonly RayTracingShader.SetMatrixArray_InjectedDelegate SetMatrixArray_InjectedDelegateField;
  private static readonly RayTracingShader.SetTexture_InjectedDelegate SetTexture_InjectedDelegateField;
  private static readonly RayTracingShader.SetBuffer_InjectedDelegate SetBuffer_InjectedDelegateField;
  private static readonly RayTracingShader.SetGraphicsBuffer_InjectedDelegate SetGraphicsBuffer_InjectedDelegateField;
  private static readonly RayTracingShader.SetGraphicsBufferHandle_InjectedDelegate SetGraphicsBufferHandle_InjectedDelegateField;
  private static readonly RayTracingShader.SetConstantComputeBuffer_InjectedDelegate SetConstantComputeBuffer_InjectedDelegateField;
  private static readonly RayTracingShader.SetConstantGraphicsBuffer_InjectedDelegate SetConstantGraphicsBuffer_InjectedDelegateField;
  private static readonly RayTracingShader.SetAccelerationStructure_InjectedDelegate SetAccelerationStructure_InjectedDelegateField;
  private static readonly RayTracingShader.SetShaderPass_InjectedDelegate SetShaderPass_InjectedDelegateField;
  private static readonly RayTracingShader.SetTextureFromGlobal_InjectedDelegate SetTextureFromGlobal_InjectedDelegateField;
  private static readonly RayTracingShader.Dispatch_InjectedDelegate Dispatch_InjectedDelegateField;
  private static readonly RayTracingShader.DispatchIndirect_InjectedDelegate DispatchIndirect_InjectedDelegateField;

  static RayTracingShader()
  {
    Il2CppClassPointerStore<RayTracingShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RayTracingShader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingShader>.NativeClassPtr);
    RayTracingShader.get_maxRecursionDepth_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.get_maxRecursionDepth_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::get_maxRecursionDepth_Injected");
    RayTracingShader.SetFloat_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloat_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetFloat_Injected");
    RayTracingShader.SetInt_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetInt_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetInt_Injected");
    RayTracingShader.SetVector_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVector_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetVector_Injected");
    RayTracingShader.SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrix_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetMatrix_Injected");
    RayTracingShader.SetFloatArray_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetFloatArray_Injected");
    RayTracingShader.SetIntArray_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetIntArray_Injected");
    RayTracingShader.SetVectorArray_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVectorArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetVectorArray_Injected");
    RayTracingShader.SetMatrixArray_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrixArray_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetMatrixArray_Injected");
    RayTracingShader.SetTexture_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTexture_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetTexture_Injected");
    RayTracingShader.SetBuffer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetBuffer_Injected");
    RayTracingShader.SetGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetGraphicsBuffer_Injected");
    RayTracingShader.SetGraphicsBufferHandle_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetGraphicsBufferHandle_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetGraphicsBufferHandle_Injected");
    RayTracingShader.SetConstantComputeBuffer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantComputeBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetConstantComputeBuffer_Injected");
    RayTracingShader.SetConstantGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantGraphicsBuffer_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetConstantGraphicsBuffer_Injected");
    RayTracingShader.SetAccelerationStructure_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetAccelerationStructure_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetAccelerationStructure_Injected");
    RayTracingShader.SetShaderPass_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetShaderPass_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetShaderPass_Injected");
    RayTracingShader.SetTextureFromGlobal_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureFromGlobal_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::SetTextureFromGlobal_Injected");
    RayTracingShader.Dispatch_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.Dispatch_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::Dispatch_Injected");
    RayTracingShader.DispatchIndirect_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.DispatchIndirect_InjectedDelegate>("UnityEngine.Rendering.RayTracingShader::DispatchIndirect_Injected");
  }

  public float maxRecursionDepth
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return RayTracingShader.get_maxRecursionDepth_Injected(_unity_self);
    }
  }

  public void SetFloat(int nameID, float val)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingShader.SetFloat_Injected(_unity_self, nameID, val);
  }

  public void SetInt(int nameID, int val)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingShader.SetInt_Injected(_unity_self, nameID, val);
  }

  public void SetVector(int nameID, Vector4 val)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingShader.SetVector_Injected(_unity_self, nameID, ref val);
  }

  public void SetMatrix(int nameID, Matrix4x4 val)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingShader.SetMatrix_Injected(_unity_self, nameID, ref val);
  }

  public unsafe void SetFloatArray(int nameID, Il2CppStructArray<float> values)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<float> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<float>) ref span).\u002Ector((Il2CppArrayBase<float>) values);
    fixed (float* begin = &((Il2CppSystem.Span<float>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<float>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      RayTracingShader.SetFloatArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public unsafe void SetIntArray(int nameID, Il2CppStructArray<int> values)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<int> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<int>) ref span).\u002Ector((Il2CppArrayBase<int>) values);
    fixed (int* begin = &((Il2CppSystem.Span<int>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<int>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      RayTracingShader.SetIntArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<Vector4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector4>) ref span).\u002Ector((Il2CppArrayBase<Vector4>) values);
    fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector4>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      RayTracingShader.SetVectorArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public unsafe void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<Matrix4x4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Matrix4x4>) ref span).\u002Ector((Il2CppArrayBase<Matrix4x4>) values);
    fixed (Matrix4x4* begin = &((Il2CppSystem.Span<Matrix4x4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Matrix4x4>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      RayTracingShader.SetMatrixArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public void SetTexture(int nameID, Texture texture)
  {
    if (texture == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) texture, nameof (texture));
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr texture1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Texture>(texture);
    if (texture1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) texture, nameof (texture));
    RayTracingShader.SetTexture_Injected(_unity_self, nameID1, texture1);
  }

  public void SetBuffer(int nameID, ComputeBuffer buffer)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    RayTracingShader.SetBuffer_Injected(_unity_self, nameID1, native);
  }

  public void SetGraphicsBuffer(int nameID, GraphicsBuffer buffer)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    RayTracingShader.SetGraphicsBuffer_Injected(_unity_self, nameID1, native);
  }

  public void SetGraphicsBufferHandle(int nameID, GraphicsBufferHandle bufferHandle)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingShader.SetGraphicsBufferHandle_Injected(_unity_self, nameID, ref bufferHandle);
  }

  public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    int offset1 = offset;
    int size1 = size;
    RayTracingShader.SetConstantComputeBuffer_Injected(_unity_self, nameID1, native, offset1, size1);
  }

  public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    int offset1 = offset;
    int size1 = size;
    RayTracingShader.SetConstantGraphicsBuffer_Injected(_unity_self, nameID1, native, offset1, size1);
  }

  public void SetAccelerationStructure(
    int nameID,
    RayTracingAccelerationStructure accelerationStructure)
  {
    if (accelerationStructure == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) accelerationStructure, nameof (accelerationStructure));
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(accelerationStructure);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) accelerationStructure, nameof (accelerationStructure));
    RayTracingShader.SetAccelerationStructure_Injected(_unity_self, nameID1, native);
  }

  public unsafe void SetShaderPass(string passName)
  {
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(passName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = passName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      RayTracingShader.SetShaderPass_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    RayTracingShader.SetTextureFromGlobal_Injected(_unity_self, nameID, globalTextureNameID);
  }

  public unsafe void Dispatch(
    string rayGenFunctionName,
    int width,
    int height,
    int depth,
    Camera camera = null)
  {
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(rayGenFunctionName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = rayGenFunctionName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      RayTracingShader.Dispatch_Injected(_unity_self, ref managedSpanWrapper, width, height, depth, UnityEngine.Object.MarshalledUnityObject.Marshal<Camera>(camera));
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public unsafe void DispatchIndirect(
    string rayGenFunctionName,
    GraphicsBuffer argsBuffer,
    uint argsOffset = default (uint),
    Camera camera = null)
  {
    if (argsBuffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) argsBuffer, nameof (argsBuffer));
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<RayTracingShader>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(rayGenFunctionName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = rayGenFunctionName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) argsBuffer, nameof (argsBuffer));
      int argsOffset1 = (int) argsOffset;
      System.IntPtr camera1 = UnityEngine.Object.MarshalledUnityObject.Marshal<Camera>(camera);
      RayTracingShader.DispatchIndirect_Injected(_unity_self, ref local, native, (uint) argsOffset1, camera1);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void SetBuffer(int nameID, GraphicsBuffer buffer)
  {
    this.SetGraphicsBuffer(nameID, buffer);
  }

  public void SetBuffer(int nameID, GraphicsBufferHandle bufferHandle)
  {
    this.SetGraphicsBufferHandle(nameID, bufferHandle);
  }

  public void SetFloat(string name, float val) => this.SetFloat(Shader.PropertyToID(name), val);

  public void SetInt(string name, int val) => this.SetInt(Shader.PropertyToID(name), val);

  public void SetVector(string name, Vector4 val) => this.SetVector(Shader.PropertyToID(name), val);

  public void SetMatrix(string name, Matrix4x4 val)
  {
    this.SetMatrix(Shader.PropertyToID(name), val);
  }

  public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
  {
    this.SetVectorArray(Shader.PropertyToID(name), values);
  }

  public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
  {
    this.SetMatrixArray(Shader.PropertyToID(name), values);
  }

  public void SetFloats(string name, Il2CppStructArray<float> values)
  {
    this.SetFloatArray(Shader.PropertyToID(name), values);
  }

  public void SetFloats(string name, params float[] values)
  {
    this.SetFloats(name, new Il2CppStructArray<float>(values));
  }

  public void SetFloats(int nameID, Il2CppStructArray<float> values)
  {
    this.SetFloatArray(nameID, values);
  }

  public void SetFloats(int nameID, params float[] values)
  {
    this.SetFloats(nameID, new Il2CppStructArray<float>(values));
  }

  public void SetInts(string name, Il2CppStructArray<int> values)
  {
    this.SetIntArray(Shader.PropertyToID(name), values);
  }

  public void SetInts(string name, params int[] values)
  {
    this.SetInts(name, new Il2CppStructArray<int>(values));
  }

  public void SetInts(int nameID, Il2CppStructArray<int> values)
  {
    this.SetIntArray(nameID, values);
  }

  public void SetInts(int nameID, params int[] values)
  {
    this.SetInts(nameID, new Il2CppStructArray<int>(values));
  }

  public void SetBool(string name, bool val) => this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);

  public void SetBool(int nameID, bool val) => this.SetInt(nameID, val ? 1 : 0);

  public void SetTexture(string name, Texture texture)
  {
    this.SetTexture(Shader.PropertyToID(name), texture);
  }

  public void SetBuffer(string name, ComputeBuffer buffer)
  {
    this.SetBuffer(Shader.PropertyToID(name), buffer);
  }

  public void SetBuffer(string name, GraphicsBuffer buffer)
  {
    this.SetBuffer(Shader.PropertyToID(name), buffer);
  }

  public void SetBuffer(string name, GraphicsBufferHandle bufferHandle)
  {
    this.SetBuffer(Shader.PropertyToID(name), bufferHandle);
  }

  public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
  {
    this.SetConstantComputeBuffer(nameID, buffer, offset, size);
  }

  public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
  {
    this.SetConstantComputeBuffer(Shader.PropertyToID(name), buffer, offset, size);
  }

  public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
  {
    this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
  }

  public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
  {
    this.SetConstantGraphicsBuffer(Shader.PropertyToID(name), buffer, offset, size);
  }

  public void SetAccelerationStructure(
    string name,
    RayTracingAccelerationStructure accelerationStructure)
  {
    this.SetAccelerationStructure(Shader.PropertyToID(name), accelerationStructure);
  }

  public void SetTextureFromGlobal(string name, string globalTextureName)
  {
    this.SetTextureFromGlobal(Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
  }

  public static float get_maxRecursionDepth_Injected(System.IntPtr _unity_self)
  {
    return RayTracingShader.get_maxRecursionDepth_InjectedDelegateField(_unity_self);
  }

  public static void SetFloat_Injected(System.IntPtr _unity_self, int nameID, float val)
  {
    RayTracingShader.SetFloat_InjectedDelegateField(_unity_self, nameID, val);
  }

  public static void SetInt_Injected(System.IntPtr _unity_self, int nameID, int val)
  {
    RayTracingShader.SetInt_InjectedDelegateField(_unity_self, nameID, val);
  }

  public static void SetVector_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector4 val)
  {
    RayTracingShader.SetVector_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref val);
  }

  public static void SetMatrix_Injected(System.IntPtr _unity_self, int nameID, [In] ref Matrix4x4 val)
  {
    RayTracingShader.SetMatrix_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref val);
  }

  public static void SetFloatArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    RayTracingShader.SetFloatArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetIntArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    RayTracingShader.SetIntArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetVectorArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    RayTracingShader.SetVectorArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetMatrixArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    RayTracingShader.SetMatrixArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetTexture_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr texture)
  {
    RayTracingShader.SetTexture_InjectedDelegateField(_unity_self, nameID, texture);
  }

  public static void SetBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer)
  {
    RayTracingShader.SetBuffer_InjectedDelegateField(_unity_self, nameID, buffer);
  }

  public static void SetGraphicsBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer)
  {
    RayTracingShader.SetGraphicsBuffer_InjectedDelegateField(_unity_self, nameID, buffer);
  }

  public static void SetGraphicsBufferHandle_Injected(
    System.IntPtr _unity_self,
    int nameID,
    [In] ref GraphicsBufferHandle bufferHandle)
  {
    RayTracingShader.SetGraphicsBufferHandle_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref bufferHandle);
  }

  public static void SetConstantComputeBuffer_Injected(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size)
  {
    RayTracingShader.SetConstantComputeBuffer_InjectedDelegateField(_unity_self, nameID, buffer, offset, size);
  }

  public static void SetConstantGraphicsBuffer_Injected(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size)
  {
    RayTracingShader.SetConstantGraphicsBuffer_InjectedDelegateField(_unity_self, nameID, buffer, offset, size);
  }

  public static void SetAccelerationStructure_Injected(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr accelerationStructure)
  {
    RayTracingShader.SetAccelerationStructure_InjectedDelegateField(_unity_self, nameID, accelerationStructure);
  }

  public static void SetShaderPass_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper passName)
  {
    RayTracingShader.SetShaderPass_InjectedDelegateField(_unity_self, (System.IntPtr) ref passName);
  }

  public static void SetTextureFromGlobal_Injected(
    System.IntPtr _unity_self,
    int nameID,
    int globalTextureNameID)
  {
    RayTracingShader.SetTextureFromGlobal_InjectedDelegateField(_unity_self, nameID, globalTextureNameID);
  }

  public static void Dispatch_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper rayGenFunctionName,
    int width,
    int height,
    int depth,
    System.IntPtr camera)
  {
    RayTracingShader.Dispatch_InjectedDelegateField(_unity_self, (System.IntPtr) ref rayGenFunctionName, width, height, depth, camera);
  }

  public static void DispatchIndirect_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper rayGenFunctionName,
    System.IntPtr argsBuffer,
    uint argsOffset,
    System.IntPtr camera)
  {
    RayTracingShader.DispatchIndirect_InjectedDelegateField(_unity_self, (System.IntPtr) ref rayGenFunctionName, argsBuffer, argsOffset, camera);
  }

  private delegate float get_maxRecursionDepth_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void SetFloat_InjectedDelegate(System.IntPtr _unity_self, int nameID, float val);

  private delegate void SetInt_InjectedDelegate(System.IntPtr _unity_self, int nameID, int val);

  private delegate void SetVector_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

  private delegate void SetMatrix_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

  private delegate void SetFloatArray_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr values);

  private delegate void SetIntArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

  private delegate void SetVectorArray_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr values);

  private delegate void SetMatrixArray_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr values);

  private delegate void SetTexture_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr texture);

  private delegate void SetBuffer_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr buffer);

  private delegate void SetGraphicsBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer);

  private delegate void SetGraphicsBufferHandle_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    [In] System.IntPtr bufferHandle);

  private delegate void SetConstantComputeBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size);

  private delegate void SetConstantGraphicsBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size);

  private delegate void SetAccelerationStructure_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr accelerationStructure);

  private delegate void SetShaderPass_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr passName);

  private delegate void SetTextureFromGlobal_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    int globalTextureNameID);

  private delegate void Dispatch_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr rayGenFunctionName,
    int width,
    int height,
    int depth,
    System.IntPtr camera);

  private delegate void DispatchIndirect_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr rayGenFunctionName,
    System.IntPtr argsBuffer,
    uint argsOffset,
    System.IntPtr camera);
}
