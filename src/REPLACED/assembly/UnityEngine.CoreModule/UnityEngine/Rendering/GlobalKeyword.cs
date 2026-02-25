// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GlobalKeyword
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class GlobalKeyword : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordCount_Private_Static_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Private_Static_UInt32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Private_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_GlobalKeyword_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

  static GlobalKeyword()
  {
    Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GlobalKeyword));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr);
    GlobalKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, nameof (m_Name));
    GlobalKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, nameof (m_Index));
    GlobalKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Private_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670638);
    GlobalKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670639);
    GlobalKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670640);
    GlobalKeyword.NativeMethodInfoPtr_Create_Public_Static_GlobalKeyword_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670641);
    GlobalKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670642);
    GlobalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670643);
    GlobalKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670644);
    GlobalKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100670645);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488961, XrefRangeEnd = 488963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetGlobalKeywordCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Private_Static_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488977, RefRangeEnd = 488978, XrefRangeStart = 488963, XrefRangeEnd = 488977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetGlobalKeywordIndex(string keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keyword)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Private_Static_UInt32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488992, RefRangeEnd = 488993, XrefRangeStart = 488978, XrefRangeEnd = 488992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateGlobalKeyword(string keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keyword)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488995, RefRangeEnd = 488997, XrefRangeStart = 488993, XrefRangeEnd = 488995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GlobalKeyword Create(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_Create_Public_Static_GlobalKeyword_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new GlobalKeyword(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489010, RefRangeEnd = 489011, XrefRangeStart = 488997, XrefRangeEnd = 489010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalKeyword(string name)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489011, XrefRangeEnd = 489013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref keyword
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489013, XrefRangeEnd = 489015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref keyword
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public GlobalKeyword(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public GlobalKeyword()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr))
  {
  }

  public unsafe string m_Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe uint m_Index
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Index));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Index)) = value;
    }
  }

  public string name => this.m_Name;
}
