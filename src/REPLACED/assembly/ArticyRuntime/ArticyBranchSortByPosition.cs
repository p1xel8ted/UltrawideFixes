// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyBranchSortByPosition
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public class ArticyBranchSortByPosition(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Branch_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PosSort_Private_Int32_Branch_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PinSort_Private_Int32_Branch_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectionSort_Private_Int32_Branch_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyBranchSortByPosition()
  {
    Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyBranchSortByPosition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr);
    ArticyBranchSortByPosition.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr, nameof (Logger));
    ArticyBranchSortByPosition.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Branch_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr, 100663309 /*0x0600000D*/);
    ArticyBranchSortByPosition.NativeMethodInfoPtr_PosSort_Private_Int32_Branch_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr, 100663310 /*0x0600000E*/);
    ArticyBranchSortByPosition.NativeMethodInfoPtr_PinSort_Private_Int32_Branch_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr, 100663311 /*0x0600000F*/);
    ArticyBranchSortByPosition.NativeMethodInfoPtr_ConnectionSort_Private_Int32_Branch_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr, 100663312 /*0x06000010*/);
    ArticyBranchSortByPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr, 100663313 /*0x06000011*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984501, XrefRangeEnd = 984528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int Compare(Branch x, Branch y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyBranchSortByPosition.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Branch_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984528, XrefRangeEnd = 984540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int PosSort(Branch x, Branch y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyBranchSortByPosition.NativeMethodInfoPtr_PosSort_Private_Int32_Branch_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984540, XrefRangeEnd = 984575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int PinSort(Branch x, Branch y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyBranchSortByPosition.NativeMethodInfoPtr_PinSort_Private_Int32_Branch_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984575, XrefRangeEnd = 984598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int ConnectionSort(Branch x, Branch y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyBranchSortByPosition.NativeMethodInfoPtr_ConnectionSort_Private_Int32_Branch_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyBranchSortByPosition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyBranchSortByPosition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyBranchSortByPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyBranchSortByPosition.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyBranchSortByPosition.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
