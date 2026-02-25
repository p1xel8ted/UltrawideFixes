// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.LocalKeyword
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

public sealed class LocalKeyword : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SpaceInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordCount_Private_Static_UInt32_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Private_Static_UInt32_ComputeShader_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly LocalKeyword.IsDynamic_InjectedDelegate IsDynamic_InjectedDelegateField;
  private static readonly LocalKeyword.IsOverridable_InjectedDelegate IsOverridable_InjectedDelegateField;
  private static readonly LocalKeyword.GetKeywordType_InjectedDelegate GetKeywordType_InjectedDelegateField;
  private static readonly LocalKeyword.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

  static LocalKeyword()
  {
    Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (LocalKeyword));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr);
    LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, nameof (m_SpaceInfo));
    LocalKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, nameof (m_Name));
    LocalKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, nameof (m_Index));
    LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670646);
    LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670647);
    LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordCount_Private_Static_UInt32_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670648);
    LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Private_Static_UInt32_ComputeShader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670649);
    LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670650);
    LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670651);
    LocalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670652);
    LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670653);
    LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670654);
    LocalKeyword.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670655);
    LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670656);
    LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670657);
    LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670658);
    LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, 100670659);
    LocalKeyword.IsDynamic_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsDynamic_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsDynamic_Injected");
    LocalKeyword.IsOverridable_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsOverridable_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsOverridable_Injected");
    LocalKeyword.GetKeywordType_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.GetKeywordType_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::GetKeywordType_Injected");
    LocalKeyword.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeyword.IsValid_InjectedDelegate>("UnityEngine.Rendering.LocalKeyword::IsValid_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489015, XrefRangeEnd = 489020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetShaderKeywordCount(Shader shader)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Private_Static_UInt32_Shader_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489038, RefRangeEnd = 489039, XrefRangeStart = 489020, XrefRangeEnd = 489038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetShaderKeywordIndex(Shader shader, string keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(keyword);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Private_Static_UInt32_Shader_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489039, XrefRangeEnd = 489044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetComputeShaderKeywordCount(ComputeShader shader)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordCount_Private_Static_UInt32_ComputeShader_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489062, RefRangeEnd = 489063, XrefRangeStart = 489044, XrefRangeEnd = 489062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(keyword);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Private_Static_UInt32_ComputeShader_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489089, RefRangeEnd = 489090, XrefRangeStart = 489063, XrefRangeEnd = 489089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalKeyword(Shader shader, string name)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_Shader_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 489116, RefRangeEnd = 489125, XrefRangeStart = 489090, XrefRangeEnd = 489116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalKeyword(ComputeShader shader, string name)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 265578, RefRangeEnd = 265607, XrefRangeStart = 265578, XrefRangeEnd = 265607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489125, XrefRangeEnd = 489128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object o)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(LocalKeyword rhs)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) rhs))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489128, XrefRangeEnd = 489130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489130, XrefRangeEnd = 489132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetShaderKeywordCount_Injected(System.IntPtr shader)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &shader
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489132, XrefRangeEnd = 489134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetShaderKeywordIndex_Injected(
    System.IntPtr shader,
    ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &shader;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref keyword;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489134, XrefRangeEnd = 489136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetComputeShaderKeywordCount_Injected(System.IntPtr shader)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &shader
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordCount_Injected_Private_Static_UInt32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489136, XrefRangeEnd = 489138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetComputeShaderKeywordIndex_Injected(
    System.IntPtr shader,
    ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &shader;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref keyword;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeyword.NativeMethodInfoPtr_GetComputeShaderKeywordIndex_Injected_Private_Static_UInt32_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public LocalKeyword(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public LocalKeyword()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr))
  {
  }

  public unsafe LocalKeywordSpace m_SpaceInfo
  {
    get
    {
      return *(LocalKeywordSpace*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo));
    }
    [param: In] set
    {
      *(LocalKeywordSpace*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_SpaceInfo)) = value;
    }
  }

  public unsafe string m_Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe uint m_Index
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Index));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalKeyword.NativeFieldInfoPtr_m_Index)) = value;
    }
  }

  public static bool IsDynamic(LocalKeyword kw) => LocalKeyword.IsDynamic_Injected(ref kw);

  public static bool IsOverridable(LocalKeyword kw) => LocalKeyword.IsOverridable_Injected(ref kw);

  public static ShaderKeywordType GetKeywordType(LocalKeywordSpace spaceInfo, uint keyword)
  {
    return LocalKeyword.GetKeywordType_Injected(ref spaceInfo, keyword);
  }

  public static bool IsValid(LocalKeywordSpace spaceInfo, uint keyword)
  {
    return LocalKeyword.IsValid_Injected(ref spaceInfo, keyword);
  }

  public string name => this.m_Name;

  public bool isDynamic
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool isOverridable
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool isValid => LocalKeyword.IsValid(this.m_SpaceInfo, this.m_Index);

  public ShaderKeywordType type => LocalKeyword.GetKeywordType(this.m_SpaceInfo, this.m_Index);

  public static bool operator ==(LocalKeyword lhs, LocalKeyword rhs)
  {
    return ((LocalKeyword) ref lhs).Equals(rhs);
  }

  public static bool operator !=(LocalKeyword lhs, LocalKeyword rhs) => !(lhs == rhs);

  public static unsafe bool IsDynamic_Injected([In] ref LocalKeyword kw)
  {
    return LocalKeyword.IsDynamic_InjectedDelegateField((System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) kw));
  }

  public static unsafe bool IsOverridable_Injected([In] ref LocalKeyword kw)
  {
    return LocalKeyword.IsOverridable_InjectedDelegateField((System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) kw));
  }

  public static ShaderKeywordType GetKeywordType_Injected(
    [In] ref LocalKeywordSpace spaceInfo,
    uint keyword)
  {
    return LocalKeyword.GetKeywordType_InjectedDelegateField((System.IntPtr) ref spaceInfo, keyword);
  }

  public static bool IsValid_Injected([In] ref LocalKeywordSpace spaceInfo, uint keyword)
  {
    return LocalKeyword.IsValid_InjectedDelegateField((System.IntPtr) ref spaceInfo, keyword);
  }

  private delegate bool IsDynamic_InjectedDelegate([In] System.IntPtr kw);

  private delegate bool IsOverridable_InjectedDelegate([In] System.IntPtr kw);

  private delegate ShaderKeywordType GetKeywordType_InjectedDelegate([In] System.IntPtr spaceInfo, uint keyword);

  private delegate bool IsValid_InjectedDelegate([In] System.IntPtr spaceInfo, uint keyword);
}
