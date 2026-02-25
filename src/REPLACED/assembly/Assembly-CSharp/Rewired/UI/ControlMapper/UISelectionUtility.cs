// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UISelectionUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public static class UISelectionUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_reusableAllSelectables;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0;

  static UISelectionUtility()
  {
    Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UISelectionUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr);
    UISelectionUtility.NativeFieldInfoPtr_s_reusableAllSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr, nameof (s_reusableAllSelectables));
    UISelectionUtility.NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr, 100670073);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 80179, RefRangeEnd = 80191, XrefRangeStart = 80095, XrefRangeEnd = 80179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Selectable FindNextSelectable(
    Selectable selectable,
    Transform transform,
    Vector3 direction)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISelectionUtility.NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  public UISelectionUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppReferenceArray<Selectable> s_reusableAllSelectables
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UISelectionUtility.NativeFieldInfoPtr_s_reusableAllSelectables, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<Selectable>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UISelectionUtility.NativeFieldInfoPtr_s_reusableAllSelectables, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
