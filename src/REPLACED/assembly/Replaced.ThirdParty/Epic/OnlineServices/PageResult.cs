// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PageResult
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices;

public class PageResult(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__StartIndex_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Count_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TotalCount_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TotalCount_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PageResultInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PageResult()
  {
    Il2CppClassPointerStore<PageResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (PageResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageResult>.NativeClassPtr);
    PageResult.NativeFieldInfoPtr__StartIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageResult>.NativeClassPtr, "<StartIndex>k__BackingField");
    PageResult.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageResult>.NativeClassPtr, "<Count>k__BackingField");
    PageResult.NativeFieldInfoPtr__TotalCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageResult>.NativeClassPtr, "<TotalCount>k__BackingField");
    PageResult.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664436);
    PageResult.NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664437);
    PageResult.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664438);
    PageResult.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664439);
    PageResult.NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664440);
    PageResult.NativeMethodInfoPtr_set_TotalCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664441);
    PageResult.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PageResultInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664442);
    PageResult.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664443);
    PageResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResult>.NativeClassPtr, 100664444);
  }

  public unsafe int StartIndex
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int Count
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int TotalCount
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_set_TotalCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371661, XrefRangeEnd = 371669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<PageResultInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PageResultInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371669, XrefRangeEnd = 371681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PageResult()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageResult>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PageResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _StartIndex_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PageResult.NativeFieldInfoPtr__StartIndex_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PageResult.NativeFieldInfoPtr__StartIndex_k__BackingField)) = value;
    }
  }

  public unsafe int _Count_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PageResult.NativeFieldInfoPtr__Count_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PageResult.NativeFieldInfoPtr__Count_k__BackingField)) = value;
    }
  }

  public unsafe int _TotalCount_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PageResult.NativeFieldInfoPtr__TotalCount_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PageResult.NativeFieldInfoPtr__TotalCount_k__BackingField)) = value;
    }
  }
}
