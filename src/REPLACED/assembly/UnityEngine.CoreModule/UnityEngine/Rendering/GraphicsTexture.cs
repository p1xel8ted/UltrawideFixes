// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GraphicsTexture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public class GraphicsTexture
{
  private static readonly GraphicsTexture.get_state_InjectedDelegate get_state_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.get_state_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::get_state_Injected");
  private static readonly GraphicsTexture.GetActive_InjectedDelegate GetActive_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.GetActive_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::GetActive_Injected");
  private static readonly GraphicsTexture.SetActive_InjectedDelegate SetActive_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.SetActive_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::SetActive_Injected");
  private static readonly GraphicsTexture.ReleaseBuffer_InjectedDelegate ReleaseBuffer_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.ReleaseBuffer_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::ReleaseBuffer_Injected");
  private static readonly GraphicsTexture.ReleaseBufferOnMain_InjectedDelegate ReleaseBufferOnMain_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.ReleaseBufferOnMain_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::ReleaseBufferOnMain_Injected");
  private static readonly GraphicsTexture.UploadBuffer_InjectedDelegate UploadBuffer_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.UploadBuffer_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::UploadBuffer_Injected");
  private static readonly GraphicsTexture.UploadBuffer_Array_InjectedDelegate UploadBuffer_Array_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsTexture.UploadBuffer_Array_InjectedDelegate>("UnityEngine.Rendering.GraphicsTexture::UploadBuffer_Array_Injected");

  public override void Finalize()
  {
    try
    {
      this.Dispose(false);
    }
    finally
    {
      ((Il2CppSystem.Object) this).Finalize();
    }
  }

  public void Dispose()
  {
    this.Dispose(true);
    Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object) this);
  }

  public void Dispose(bool disposing)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void UploadData(System.IntPtr data, int size)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void UploadData(Il2CppStructArray<byte> data)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public GraphicsTextureState state
  {
    get
    {
      System.IntPtr native = GraphicsTexture.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return GraphicsTexture.get_state_Injected(native);
    }
  }

  public static GraphicsTexture GetActive()
  {
    System.IntPtr activeInjected = GraphicsTexture.GetActive_Injected();
    return activeInjected != System.IntPtr.Zero ? GraphicsTexture.BindingsMarshaller.ConvertToManaged(activeInjected) : (GraphicsTexture) null;
  }

  public static void SetActive(GraphicsTexture target)
  {
    GraphicsTexture.SetActive_Injected(target == null ? System.IntPtr.Zero : GraphicsTexture.BindingsMarshaller.ConvertToNative(target));
  }

  public static GraphicsTexture active
  {
    get => GraphicsTexture.GetActive();
    set => GraphicsTexture.SetActive(value);
  }

  public void ReleaseBuffer()
  {
    System.IntPtr native = GraphicsTexture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsTexture.ReleaseBuffer_Injected(native);
  }

  public void ReleaseBufferOnMain()
  {
    System.IntPtr native = GraphicsTexture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    GraphicsTexture.ReleaseBufferOnMain_Injected(native);
  }

  public bool UploadBuffer(System.IntPtr data, ulong size)
  {
    System.IntPtr native = GraphicsTexture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return GraphicsTexture.UploadBuffer_Injected(native, data, size);
  }

  public unsafe bool UploadBuffer_Array(Il2CppStructArray<byte> data)
  {
    System.IntPtr native = GraphicsTexture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Il2CppSystem.Span<byte> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<byte>) ref span).\u002Ector((Il2CppArrayBase<byte>) data);
    int num;
    fixed (byte* begin = &((Il2CppSystem.Span<byte>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper data1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<byte>) ref span).Length);
      num = GraphicsTexture.UploadBuffer_Array_Injected(native, ref data1) ? 1 : 0;
    }
    return num != 0;
  }

  public static GraphicsTextureState get_state_Injected(System.IntPtr _unity_self)
  {
    return GraphicsTexture.get_state_InjectedDelegateField(_unity_self);
  }

  public static System.IntPtr GetActive_Injected()
  {
    return GraphicsTexture.GetActive_InjectedDelegateField();
  }

  public static void SetActive_Injected(System.IntPtr target)
  {
    GraphicsTexture.SetActive_InjectedDelegateField(target);
  }

  public static void ReleaseBuffer_Injected(System.IntPtr _unity_self)
  {
    GraphicsTexture.ReleaseBuffer_InjectedDelegateField(_unity_self);
  }

  public static void ReleaseBufferOnMain_Injected(System.IntPtr _unity_self)
  {
    GraphicsTexture.ReleaseBufferOnMain_InjectedDelegateField(_unity_self);
  }

  public static bool UploadBuffer_Injected(System.IntPtr _unity_self, System.IntPtr data, ulong size)
  {
    return GraphicsTexture.UploadBuffer_InjectedDelegateField(_unity_self, data, size);
  }

  public static bool UploadBuffer_Array_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper data)
  {
    return GraphicsTexture.UploadBuffer_Array_InjectedDelegateField(_unity_self, (System.IntPtr) ref data);
  }

  public static class BindingsMarshaller
  {
  }

  private delegate GraphicsTextureState get_state_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetActive_InjectedDelegate();

  private delegate void SetActive_InjectedDelegate(System.IntPtr target);

  private delegate void ReleaseBuffer_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void ReleaseBufferOnMain_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool UploadBuffer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data, ulong size);

  private delegate bool UploadBuffer_Array_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr data);
}
