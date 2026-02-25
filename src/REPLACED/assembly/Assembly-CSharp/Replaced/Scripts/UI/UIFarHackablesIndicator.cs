// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIFarHackablesIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIFarHackablesIndicator(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_left;
  private static readonly System.IntPtr NativeFieldInfoPtr_top;
  private static readonly System.IntPtr NativeFieldInfoPtr_right;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_stringBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateIndicators_Private_Void_FarHackablesIndicators_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Int32_TMP_Text_PDM_0;

  static UIFarHackablesIndicator()
  {
    Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIFarHackablesIndicator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr);
    UIFarHackablesIndicator.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, nameof (left));
    UIFarHackablesIndicator.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, nameof (top));
    UIFarHackablesIndicator.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, nameof (right));
    UIFarHackablesIndicator.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, nameof (bottom));
    UIFarHackablesIndicator.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, nameof (stringBuilder));
    UIFarHackablesIndicator.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, nameof (eventDisposable));
    UIFarHackablesIndicator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, 100670705);
    UIFarHackablesIndicator.NativeMethodInfoPtr_UpdateIndicators_Private_Void_FarHackablesIndicators_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, 100670706);
    UIFarHackablesIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, 100670707);
    UIFarHackablesIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, 100670708);
    UIFarHackablesIndicator.NativeMethodInfoPtr_Method_Private_Void_Int32_TMP_Text_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr, 100670709);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87706, XrefRangeEnd = 87724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFarHackablesIndicator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87724, XrefRangeEnd = 87744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateIndicators(FarHackablesIndicators indicators)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &indicators
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFarHackablesIndicator.NativeMethodInfoPtr_UpdateIndicators_Private_Void_FarHackablesIndicators_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87744, XrefRangeEnd = 87747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFarHackablesIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87747, XrefRangeEnd = 87752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIFarHackablesIndicator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFarHackablesIndicator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFarHackablesIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87752, XrefRangeEnd = 87757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_Int32_TMP_Text_PDM_0(int distance, TMP_Text text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &distance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) text);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIFarHackablesIndicator.NativeMethodInfoPtr_Method_Private_Void_Int32_TMP_Text_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text left
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_left));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_left), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text top
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_top));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_top), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text right
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_right));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_right), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text bottom
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_bottom));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_bottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder stringBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_stringBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIFarHackablesIndicator.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
