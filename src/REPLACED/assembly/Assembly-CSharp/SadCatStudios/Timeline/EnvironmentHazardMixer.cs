// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.EnvironmentHazardMixer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Environment;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

public class EnvironmentHazardMixer(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mat;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnvironmentHazardMixer()
  {
    Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (EnvironmentHazardMixer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr);
    EnvironmentHazardMixer.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr, nameof (mat));
    EnvironmentHazardMixer.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr, 100670774);
    EnvironmentHazardMixer.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr, 100670775);
    EnvironmentHazardMixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr, 100670776);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88174, XrefRangeEnd = 88189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EnvironmentHazardMixer.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88189, XrefRangeEnd = 88190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnBehaviourPause(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EnvironmentHazardMixer.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnvironmentHazardMixer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentHazardMixer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnvironmentHazardMixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ElectricityTile mat
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnvironmentHazardMixer.NativeFieldInfoPtr_mat));
      return num == System.IntPtr.Zero ? (ElectricityTile) null : Il2CppObjectPool.Get<ElectricityTile>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnvironmentHazardMixer.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
