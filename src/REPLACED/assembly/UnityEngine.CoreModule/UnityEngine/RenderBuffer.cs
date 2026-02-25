// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderBuffer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderBuffer
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderTextureInstanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferPtr;
  [FieldOffset(0)]
  public int m_RenderTextureInstanceID;
  [FieldOffset(8)]
  public System.IntPtr m_BufferPtr;
  private static readonly RenderBuffer.SetLoadActionDelegate SetLoadActionDelegateField;
  private static readonly RenderBuffer.SetStoreActionDelegate SetStoreActionDelegateField;
  private static readonly RenderBuffer.GetLoadActionDelegate GetLoadActionDelegateField;
  private static readonly RenderBuffer.GetStoreActionDelegate GetStoreActionDelegateField;
  private static readonly RenderBuffer.GetNativeRenderBufferPtrDelegate GetNativeRenderBufferPtrDelegateField;

  static RenderBuffer()
  {
    Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RenderBuffer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr);
    RenderBuffer.NativeFieldInfoPtr_m_RenderTextureInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, nameof (m_RenderTextureInstanceID));
    RenderBuffer.NativeFieldInfoPtr_m_BufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, nameof (m_BufferPtr));
    RenderBuffer.SetLoadActionDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetLoadActionDelegate>("UnityEngine.RenderBuffer::SetLoadAction");
    RenderBuffer.SetStoreActionDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetStoreActionDelegate>("UnityEngine.RenderBuffer::SetStoreAction");
    RenderBuffer.GetLoadActionDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetLoadActionDelegate>("UnityEngine.RenderBuffer::GetLoadAction");
    RenderBuffer.GetStoreActionDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetStoreActionDelegate>("UnityEngine.RenderBuffer::GetStoreAction");
    RenderBuffer.GetNativeRenderBufferPtrDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetNativeRenderBufferPtrDelegate>("UnityEngine.RenderBuffer::GetNativeRenderBufferPtr");
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void SetLoadAction(RenderBufferLoadAction action)
  {
    RenderBuffer.SetLoadActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), action);
  }

  public void SetStoreAction(RenderBufferStoreAction action)
  {
    RenderBuffer.SetStoreActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), action);
  }

  public RenderBufferLoadAction GetLoadAction()
  {
    return RenderBuffer.GetLoadActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public RenderBufferStoreAction GetStoreAction()
  {
    return RenderBuffer.GetStoreActionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public System.IntPtr GetNativeRenderBufferPtr()
  {
    return RenderBuffer.GetNativeRenderBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public RenderBufferLoadAction loadAction
  {
    get => this.GetLoadAction();
    set => this.SetLoadAction(value);
  }

  public RenderBufferStoreAction storeAction
  {
    get => this.GetStoreAction();
    set => this.SetStoreAction(value);
  }

  private delegate void SetLoadActionDelegate(System.IntPtr _param1, RenderBufferLoadAction action);

  private delegate void SetStoreActionDelegate(System.IntPtr _param1, RenderBufferStoreAction action);

  private delegate RenderBufferLoadAction GetLoadActionDelegate(System.IntPtr _param1);

  private delegate RenderBufferStoreAction GetStoreActionDelegate(System.IntPtr _param1);

  private delegate System.IntPtr GetNativeRenderBufferPtrDelegate(System.IntPtr _param1);
}
