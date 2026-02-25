// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.BeginResetToCheckpointEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.Events;

[StructLayout(LayoutKind.Explicit)]
public struct BeginResetToCheckpointEvent
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Delay;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
  [FieldOffset(0)]
  public readonly float Delay;

  static BeginResetToCheckpointEvent()
  {
    Il2CppClassPointerStore<BeginResetToCheckpointEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (BeginResetToCheckpointEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginResetToCheckpointEvent>.NativeClassPtr);
    BeginResetToCheckpointEvent.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginResetToCheckpointEvent>.NativeClassPtr, nameof (Delay));
    BeginResetToCheckpointEvent.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginResetToCheckpointEvent>.NativeClassPtr, 100671460);
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BeginResetToCheckpointEvent(float delay = 0.0f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginResetToCheckpointEvent.NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginResetToCheckpointEvent>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
