// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.G_ExtensionMethods
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.Utils;

public static class G_ExtensionMethods : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_GameObject_List_1_GameObject_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetOneActive_Public_Static_List_1_Image_List_1_Image_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_Image_List_1_Image_Boolean_0;

  static G_ExtensionMethods()
  {
    Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Utils", nameof (G_ExtensionMethods));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr);
    G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_GameObject_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr, 100663523 /*0x060000E3*/);
    G_ExtensionMethods.NativeMethodInfoPtr_SetOneActive_Public_Static_List_1_Image_List_1_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr, 100663524 /*0x060000E4*/);
    G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_Image_List_1_Image_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr, 100663525 /*0x060000E5*/);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 361688, RefRangeEnd = 361698, XrefRangeStart = 361673, XrefRangeEnd = 361688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<GameObject> SetAllActive(this List<GameObject> gameObjects, bool active)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjects);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &active;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_GameObject_List_1_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<GameObject>) null : Il2CppObjectPool.Get<List<GameObject>>(num3);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 361705, RefRangeEnd = 361711, XrefRangeStart = 361698, XrefRangeEnd = 361705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<Image> SetOneActive(this List<Image> images, int active)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) images);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &active;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_ExtensionMethods.NativeMethodInfoPtr_SetOneActive_Public_Static_List_1_Image_List_1_Image_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<Image>) null : Il2CppObjectPool.Get<List<Image>>(num3);
  }

  [CallerCount(21)]
  [CachedScanResults(RefRangeStart = 361727, RefRangeEnd = 361748, XrefRangeStart = 361711, XrefRangeEnd = 361727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<Image> SetAllActive(this List<Image> images, bool active)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) images);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &active;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_Image_List_1_Image_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<Image>) null : Il2CppObjectPool.Get<List<Image>>(num3);
  }

  public G_ExtensionMethods(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
