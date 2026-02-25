// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Audio.FMODParamsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Audio;

public class FMODParamsManager(IntPtr pointer) : GlobalSingletonBehaviour<FMODParamsManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_healthDesc;
  private static readonly IntPtr NativeFieldInfoPtr_tankCountDesc;
  private static readonly IntPtr NativeFieldInfoPtr_combatDesc;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetParam_Private_Void_PARAMETER_DESCRIPTION_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetHealth_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTanksInCombat_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetCombat_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FMODParamsManager()
  {
    Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Audio", nameof (FMODParamsManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr);
    FMODParamsManager.NativeFieldInfoPtr_healthDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, nameof (healthDesc));
    FMODParamsManager.NativeFieldInfoPtr_tankCountDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, nameof (tankCountDesc));
    FMODParamsManager.NativeFieldInfoPtr_combatDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, nameof (combatDesc));
    FMODParamsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, 100676429);
    FMODParamsManager.NativeMethodInfoPtr_SetParam_Private_Void_PARAMETER_DESCRIPTION_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, 100676430);
    FMODParamsManager.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, 100676431);
    FMODParamsManager.NativeMethodInfoPtr_SetTanksInCombat_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, 100676432);
    FMODParamsManager.NativeMethodInfoPtr_SetCombat_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, 100676433);
    FMODParamsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr, 100676434);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123327, XrefRangeEnd = 123342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FMODParamsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123342, XrefRangeEnd = 123347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetParam(PARAMETER_DESCRIPTION desc, float val)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &desc;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &val;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FMODParamsManager.NativeMethodInfoPtr_SetParam_Private_Void_PARAMETER_DESCRIPTION_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123352, RefRangeEnd = 123353, XrefRangeStart = 123347, XrefRangeEnd = 123352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetHealth(float val)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &val
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FMODParamsManager.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123358, RefRangeEnd = 123359, XrefRangeStart = 123353, XrefRangeEnd = 123358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTanksInCombat(float val)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &val
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FMODParamsManager.NativeMethodInfoPtr_SetTanksInCombat_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 123364, RefRangeEnd = 123368, XrefRangeStart = 123359, XrefRangeEnd = 123364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCombat(float val)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &val
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FMODParamsManager.NativeMethodInfoPtr_SetCombat_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123368, XrefRangeEnd = 123371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FMODParamsManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FMODParamsManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FMODParamsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PARAMETER_DESCRIPTION healthDesc
  {
    get
    {
      return *(PARAMETER_DESCRIPTION*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FMODParamsManager.NativeFieldInfoPtr_healthDesc));
    }
    [param: In] set
    {
      *(PARAMETER_DESCRIPTION*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FMODParamsManager.NativeFieldInfoPtr_healthDesc)) = value;
    }
  }

  public unsafe PARAMETER_DESCRIPTION tankCountDesc
  {
    get
    {
      return *(PARAMETER_DESCRIPTION*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FMODParamsManager.NativeFieldInfoPtr_tankCountDesc));
    }
    [param: In] set
    {
      *(PARAMETER_DESCRIPTION*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FMODParamsManager.NativeFieldInfoPtr_tankCountDesc)) = value;
    }
  }

  public unsafe PARAMETER_DESCRIPTION combatDesc
  {
    get
    {
      return *(PARAMETER_DESCRIPTION*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FMODParamsManager.NativeFieldInfoPtr_combatDesc));
    }
    [param: In] set
    {
      *(PARAMETER_DESCRIPTION*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FMODParamsManager.NativeFieldInfoPtr_combatDesc)) = value;
    }
  }
}
