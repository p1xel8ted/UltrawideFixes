// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PageResultInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices;

[StructLayout(LayoutKind.Explicit)]
public struct PageResultInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StartIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TotalCount_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PageResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_StartIndex;
  [FieldOffset(4)]
  public int m_Count;
  [FieldOffset(8)]
  public int m_TotalCount;

  static PageResultInternal()
  {
    Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (PageResultInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr);
    PageResultInternal.NativeFieldInfoPtr_m_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, nameof (m_StartIndex));
    PageResultInternal.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, nameof (m_Count));
    PageResultInternal.NativeFieldInfoPtr_m_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, nameof (m_TotalCount));
    PageResultInternal.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664445);
    PageResultInternal.NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664446);
    PageResultInternal.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664447);
    PageResultInternal.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664448 /*0x06000480*/);
    PageResultInternal.NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664449);
    PageResultInternal.NativeMethodInfoPtr_set_TotalCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664450);
    PageResultInternal.NativeMethodInfoPtr_Set_Public_Void_PageResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664451);
    PageResultInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664452);
    PageResultInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, 100664453);
  }

  public unsafe int StartIndex
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int Count
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int TotalCount
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_get_TotalCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147413, RefRangeEnd = 147418, XrefRangeStart = 147413, XrefRangeEnd = 147418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_set_TotalCount_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(PageResult other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_Set_Public_Void_PageResult_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371681, XrefRangeEnd = 371683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PageResultInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PageResultInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
