// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.SkinnedStateController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Character;

public class SkinnedStateController(IntPtr pointer) : StateController(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_overrideContainer;
  private static readonly IntPtr NativeMethodInfoPtr_PlayClip_Public_Virtual_Void_MeshClip_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SkinnedStateController()
  {
    Il2CppClassPointerStore<SkinnedStateController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (SkinnedStateController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedStateController>.NativeClassPtr);
    SkinnedStateController.NativeFieldInfoPtr_overrideContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedStateController>.NativeClassPtr, nameof (overrideContainer));
    SkinnedStateController.NativeMethodInfoPtr_PlayClip_Public_Virtual_Void_MeshClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedStateController>.NativeClassPtr, 100675602);
    SkinnedStateController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedStateController>.NativeClassPtr, 100675603);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118347, XrefRangeEnd = 118352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PlayClip(MeshClip clip, bool force = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &force;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SkinnedStateController.NativeMethodInfoPtr_PlayClip_Public_Virtual_Void_MeshClip_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118352, XrefRangeEnd = 118353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SkinnedStateController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedStateController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkinnedStateController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ClipsOverrideContainer overrideContainer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkinnedStateController.NativeFieldInfoPtr_overrideContainer));
      return num == IntPtr.Zero ? (ClipsOverrideContainer) null : Il2CppObjectPool.Get<ClipsOverrideContainer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkinnedStateController.NativeFieldInfoPtr_overrideContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
