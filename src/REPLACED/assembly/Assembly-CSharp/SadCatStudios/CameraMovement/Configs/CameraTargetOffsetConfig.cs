// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.Configs.CameraTargetOffsetConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.CameraMovement.Configs;

public class CameraTargetOffsetConfig(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_dutch;
  private static readonly IntPtr NativeFieldInfoPtr_enterSmoothTime;
  private static readonly IntPtr NativeFieldInfoPtr_exitSmoothTime;
  private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Dutch_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnterSmoothTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ExitSmoothTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CameraTargetOffsetConfig()
  {
    Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement.Configs", nameof (CameraTargetOffsetConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr);
    CameraTargetOffsetConfig.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, nameof (offset));
    CameraTargetOffsetConfig.NativeFieldInfoPtr_dutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, nameof (dutch));
    CameraTargetOffsetConfig.NativeFieldInfoPtr_enterSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, nameof (enterSmoothTime));
    CameraTargetOffsetConfig.NativeFieldInfoPtr_exitSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, nameof (exitSmoothTime));
    CameraTargetOffsetConfig.NativeMethodInfoPtr_get_Offset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, 100676405);
    CameraTargetOffsetConfig.NativeMethodInfoPtr_get_Dutch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, 100676406);
    CameraTargetOffsetConfig.NativeMethodInfoPtr_get_EnterSmoothTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, 100676407);
    CameraTargetOffsetConfig.NativeMethodInfoPtr_get_ExitSmoothTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, 100676408);
    CameraTargetOffsetConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr, 100676409);
  }

  public unsafe Vector3 Offset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraTargetOffsetConfig.NativeMethodInfoPtr_get_Offset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float Dutch
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraTargetOffsetConfig.NativeMethodInfoPtr_get_Dutch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float EnterSmoothTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraTargetOffsetConfig.NativeMethodInfoPtr_get_EnterSmoothTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float ExitSmoothTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraTargetOffsetConfig.NativeMethodInfoPtr_get_ExitSmoothTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraTargetOffsetConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraTargetOffsetConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraTargetOffsetConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe float dutch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_dutch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_dutch)) = value;
    }
  }

  public unsafe float enterSmoothTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_enterSmoothTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_enterSmoothTime)) = value;
    }
  }

  public unsafe float exitSmoothTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_exitSmoothTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraTargetOffsetConfig.NativeFieldInfoPtr_exitSmoothTime)) = value;
    }
  }
}
