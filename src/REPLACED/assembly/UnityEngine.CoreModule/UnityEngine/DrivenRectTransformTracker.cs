// Decompiled with JetBrains decompiler
// Type: UnityEngine.DrivenRectTransformTracker
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct DrivenRectTransformTracker
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

  static DrivenRectTransformTracker()
  {
    Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (DrivenRectTransformTracker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr);
    DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100668651);
    DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100668652);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(
    Object driver,
    RectTransform rectTransform,
    DrivenTransformProperties drivenProperties)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) driver);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &drivenProperties;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool CanRecordModifications() => true;

  public void Clear(bool revertValues) => this.Clear();
}
