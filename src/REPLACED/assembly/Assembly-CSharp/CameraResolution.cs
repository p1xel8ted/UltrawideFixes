// Decompiled with JetBrains decompiler
// Type: CameraResolution
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
public class CameraResolution(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_TargetWidthAspect;
  private static readonly IntPtr NativeFieldInfoPtr_TargetHeightAspect;
  private static readonly IntPtr NativeFieldInfoPtr_ScreenSizeX;
  private static readonly IntPtr NativeFieldInfoPtr_ScreenSizeY;
  private static readonly IntPtr NativeMethodInfoPtr_RescaleCamera_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPreCull_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CameraResolution()
  {
    Il2CppClassPointerStore<CameraResolution>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CameraResolution));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr);
    CameraResolution.NativeFieldInfoPtr_TargetWidthAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, nameof (TargetWidthAspect));
    CameraResolution.NativeFieldInfoPtr_TargetHeightAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, nameof (TargetHeightAspect));
    CameraResolution.NativeFieldInfoPtr_ScreenSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, nameof (ScreenSizeX));
    CameraResolution.NativeFieldInfoPtr_ScreenSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, nameof (ScreenSizeY));
    CameraResolution.NativeMethodInfoPtr_RescaleCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, 100663422 /*0x0600007E*/);
    CameraResolution.NativeMethodInfoPtr_OnPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, 100663423 /*0x0600007F*/);
    CameraResolution.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, 100663424 /*0x06000080*/);
    CameraResolution.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, 100663425 /*0x06000081*/);
    CameraResolution.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr, 100663426 /*0x06000082*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 16505, RefRangeEnd = 16507, XrefRangeStart = 16494, XrefRangeEnd = 16505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RescaleCamera()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraResolution.NativeMethodInfoPtr_RescaleCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16507, XrefRangeEnd = 16518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnPreCull()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraResolution.NativeMethodInfoPtr_OnPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16518, XrefRangeEnd = 16519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraResolution.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraResolution.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16519, XrefRangeEnd = 16520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraResolution()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraResolution>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraResolution.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float TargetWidthAspect
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_TargetWidthAspect));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_TargetWidthAspect)) = value;
    }
  }

  public unsafe float TargetHeightAspect
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_TargetHeightAspect));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_TargetHeightAspect)) = value;
    }
  }

  public unsafe int ScreenSizeX
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_ScreenSizeX));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_ScreenSizeX)) = value;
    }
  }

  public unsafe int ScreenSizeY
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_ScreenSizeY));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraResolution.NativeFieldInfoPtr_ScreenSizeY)) = value;
    }
  }
}
