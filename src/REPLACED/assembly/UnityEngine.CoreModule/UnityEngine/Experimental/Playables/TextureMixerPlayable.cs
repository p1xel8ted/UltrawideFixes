// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Playables.TextureMixerPlayable
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Experimental.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct TextureMixerPlayable
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0;
  [FieldOffset(0)]
  public PlayableHandle m_Handle;
  private static readonly TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate CreateTextureMixerPlayableInternalDelegateField;

  static TextureMixerPlayable()
  {
    Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", nameof (TextureMixerPlayable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr);
    TextureMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, nameof (m_Handle));
    TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100670732);
    TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100670733);
    TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate>("UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal");
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489656, XrefRangeEnd = 489660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(TextureMixerPlayable other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static TextureMixerPlayable Create(PlayableGraph graph)
  {
    return new TextureMixerPlayable(TextureMixerPlayable.CreateHandle(graph));
  }

  public static PlayableHandle CreateHandle(PlayableGraph graph)
  {
    PlayableHandle handle = PlayableHandle.Null;
    return !TextureMixerPlayable.CreateTextureMixerPlayableInternal(ref graph, ref handle) ? PlayableHandle.Null : handle;
  }

  public static implicit operator Playable(TextureMixerPlayable playable)
  {
    return new Playable(playable.GetHandle());
  }

  public static explicit operator TextureMixerPlayable(Playable playable)
  {
    return new TextureMixerPlayable(playable.GetHandle());
  }

  public static bool CreateTextureMixerPlayableInternal(
    ref PlayableGraph graph,
    ref PlayableHandle handle)
  {
    return TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField((System.IntPtr) ref graph, (System.IntPtr) ref handle);
  }

  private delegate bool CreateTextureMixerPlayableInternalDelegate(System.IntPtr graph, System.IntPtr handle);
}
