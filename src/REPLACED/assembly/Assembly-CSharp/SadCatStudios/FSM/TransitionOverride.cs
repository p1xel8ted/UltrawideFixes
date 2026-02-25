// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.TransitionOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM;

[Serializable]
public class TransitionOverride(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_RunGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_RunClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_Cancellable;
  private static readonly System.IntPtr NativeFieldInfoPtr_WaitForCurrentClipEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_IdleGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_IdleClip;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TransitionOverride()
  {
    Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (TransitionOverride));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr);
    TransitionOverride.NativeFieldInfoPtr_RunGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, nameof (RunGraph));
    TransitionOverride.NativeFieldInfoPtr_RunClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, nameof (RunClip));
    TransitionOverride.NativeFieldInfoPtr_Cancellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, nameof (Cancellable));
    TransitionOverride.NativeFieldInfoPtr_WaitForCurrentClipEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, nameof (WaitForCurrentClipEnd));
    TransitionOverride.NativeFieldInfoPtr_IdleGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, nameof (IdleGraph));
    TransitionOverride.NativeFieldInfoPtr_IdleClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, nameof (IdleClip));
    TransitionOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr, 100673213);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TransitionOverride()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionOverride>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransitionOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FSMGraph RunGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_RunGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_RunGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip RunClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_RunClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_RunClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Cancellable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_Cancellable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_Cancellable)) = value;
    }
  }

  public unsafe bool WaitForCurrentClipEnd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_WaitForCurrentClipEnd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_WaitForCurrentClipEnd)) = value;
    }
  }

  public unsafe FSMGraph IdleGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_IdleGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_IdleGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip IdleClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_IdleClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransitionOverride.NativeFieldInfoPtr_IdleClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
