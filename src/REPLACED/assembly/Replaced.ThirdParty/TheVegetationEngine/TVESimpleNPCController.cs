// Decompiled with JetBrains decompiler
// Type: TheVegetationEngine.TVESimpleNPCController
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace TheVegetationEngine;

public class TVESimpleNPCController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_timeToChangeDirection;
  private static readonly IntPtr NativeFieldInfoPtr_direction;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ChangeDirection_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TVESimpleNPCController()
  {
    Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "TheVegetationEngine", nameof (TVESimpleNPCController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr);
    TVESimpleNPCController.NativeFieldInfoPtr_timeToChangeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr, nameof (timeToChangeDirection));
    TVESimpleNPCController.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr, nameof (direction));
    TVESimpleNPCController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr, 100673663);
    TVESimpleNPCController.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr, 100673664);
    TVESimpleNPCController.NativeMethodInfoPtr_ChangeDirection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr, 100673665);
    TVESimpleNPCController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr, 100673666);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403268, XrefRangeEnd = 403269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleNPCController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403269, XrefRangeEnd = 403273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleNPCController.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 403277, RefRangeEnd = 403279, XrefRangeStart = 403273, XrefRangeEnd = 403277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ChangeDirection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleNPCController.NativeMethodInfoPtr_ChangeDirection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TVESimpleNPCController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVESimpleNPCController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleNPCController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float timeToChangeDirection
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleNPCController.NativeFieldInfoPtr_timeToChangeDirection));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleNPCController.NativeFieldInfoPtr_timeToChangeDirection)) = value;
    }
  }

  public unsafe Vector3 direction
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleNPCController.NativeFieldInfoPtr_direction));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleNPCController.NativeFieldInfoPtr_direction)) = value;
    }
  }
}
