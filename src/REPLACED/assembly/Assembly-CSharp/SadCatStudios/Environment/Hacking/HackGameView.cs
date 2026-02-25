// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.Hacking.HackGameView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.Environment.Hacking;

public class HackGameView(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_solidSprite;
  private static readonly IntPtr NativeFieldInfoPtr_emptySprite;
  private static readonly IntPtr NativeFieldInfoPtr_crossCheckSprite;
  private static readonly IntPtr NativeFieldInfoPtr_emptyCheckSprite;
  private static readonly IntPtr NativeFieldInfoPtr_fillCheckSprite;
  private static readonly IntPtr NativeFieldInfoPtr_viewImages;
  private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Il2CppObjectBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Il2CppObjectBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowGenerated_Public_Void_Il2CppObjectBase_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_FillColumn_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CompareValues_Public_Void_Il2CppObjectBase_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CompareValues_Public_Void_Il2CppObjectBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static HackGameView()
  {
    Il2CppClassPointerStore<HackGameView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment.Hacking", nameof (HackGameView));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HackGameView>.NativeClassPtr);
    HackGameView.NativeFieldInfoPtr_solidSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, nameof (solidSprite));
    HackGameView.NativeFieldInfoPtr_emptySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, nameof (emptySprite));
    HackGameView.NativeFieldInfoPtr_crossCheckSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, nameof (crossCheckSprite));
    HackGameView.NativeFieldInfoPtr_emptyCheckSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, nameof (emptyCheckSprite));
    HackGameView.NativeFieldInfoPtr_fillCheckSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, nameof (fillCheckSprite));
    HackGameView.NativeFieldInfoPtr_viewImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, nameof (viewImages));
    HackGameView.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, "<Value>k__BackingField");
    HackGameView.NativeMethodInfoPtr_get_Value_Public_get_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676232);
    HackGameView.NativeMethodInfoPtr_set_Value_Private_set_Void_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676233);
    HackGameView.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676234);
    HackGameView.NativeMethodInfoPtr_ShowGenerated_Public_Void_Il2CppObjectBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676235);
    HackGameView.NativeMethodInfoPtr_FillColumn_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676236);
    HackGameView.NativeMethodInfoPtr_CompareValues_Public_Void_Il2CppObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676237);
    HackGameView.NativeMethodInfoPtr_CompareValues_Public_Void_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676238);
    HackGameView.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676239);
    HackGameView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackGameView>.NativeClassPtr, 100676240);
  }

  public unsafe Il2CppObjectBase Value
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_get_Value_Public_get_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_set_Value_Private_set_Void_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122138, XrefRangeEnd = 122141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122141, XrefRangeEnd = 122142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowGenerated(Il2CppObjectBase generatedArray, bool inverse)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr(generatedArray);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &inverse;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_ShowGenerated_Public_Void_Il2CppObjectBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122142, XrefRangeEnd = 122143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FillColumn(int column)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &column
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_FillColumn_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 122146, RefRangeEnd = 122148, XrefRangeStart = 122143, XrefRangeEnd = 122146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CompareValues(Il2CppObjectBase keyArray, int column)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr(keyArray);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &column;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_CompareValues_Public_Void_Il2CppObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122148, XrefRangeEnd = 122151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CompareValues(Il2CppObjectBase keyArray)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr(keyArray)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_CompareValues_Public_Void_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122151, XrefRangeEnd = 122152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HackGameView()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HackGameView>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HackGameView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Sprite solidSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_solidSprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_solidSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite emptySprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_emptySprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_emptySprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite crossCheckSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_crossCheckSprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_crossCheckSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite emptyCheckSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_emptyCheckSprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_emptyCheckSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite fillCheckSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_fillCheckSprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_fillCheckSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Image> viewImages
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_viewImages));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Image>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr_viewImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppObjectBase _Value_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr__Value_k__BackingField));
      return num == IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HackGameView.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
    }
  }
}
