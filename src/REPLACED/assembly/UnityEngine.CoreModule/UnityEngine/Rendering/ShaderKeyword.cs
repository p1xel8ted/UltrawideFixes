// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShaderKeyword
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class ShaderKeyword : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsLocal;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsCompute;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsValid;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly ShaderKeyword.GetGlobalShaderKeywordTypeDelegate GetGlobalShaderKeywordTypeDelegateField;
  private static readonly ShaderKeyword.GetKeywordCount_InjectedDelegate GetKeywordCount_InjectedDelegateField;
  private static readonly ShaderKeyword.GetKeywordIndex_InjectedDelegate GetKeywordIndex_InjectedDelegateField;
  private static readonly ShaderKeyword.GetComputeShaderKeywordCount_InjectedDelegate GetComputeShaderKeywordCount_InjectedDelegateField;
  private static readonly ShaderKeyword.GetComputeShaderKeywordIndex_InjectedDelegate GetComputeShaderKeywordIndex_InjectedDelegateField;

  static ShaderKeyword()
  {
    Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ShaderKeyword));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr);
    ShaderKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, nameof (m_Name));
    ShaderKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, nameof (m_Index));
    ShaderKeyword.NativeFieldInfoPtr_m_IsLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, nameof (m_IsLocal));
    ShaderKeyword.NativeFieldInfoPtr_m_IsCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, nameof (m_IsCompute));
    ShaderKeyword.NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, nameof (m_IsValid));
    ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670666);
    ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670667);
    ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670668);
    ShaderKeyword.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670669);
    ShaderKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670670);
    ShaderKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670671);
    ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670672);
    ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr, 100670673);
    ShaderKeyword.GetGlobalShaderKeywordTypeDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetGlobalShaderKeywordTypeDelegate>("UnityEngine.Rendering.ShaderKeyword::GetGlobalShaderKeywordType");
    ShaderKeyword.GetKeywordCount_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetKeywordCount_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordCount_Injected");
    ShaderKeyword.GetKeywordIndex_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetKeywordIndex_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetKeywordIndex_Injected");
    ShaderKeyword.GetComputeShaderKeywordCount_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetComputeShaderKeywordCount_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordCount_Injected");
    ShaderKeyword.GetComputeShaderKeywordIndex_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeyword.GetComputeShaderKeywordIndex_InjectedDelegate>("UnityEngine.Rendering.ShaderKeyword::GetComputeShaderKeywordIndex_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489154, XrefRangeEnd = 489156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetGlobalKeywordCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordCount_Internal_Static_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489170, RefRangeEnd = 489172, XrefRangeStart = 489156, XrefRangeEnd = 489170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetGlobalKeywordIndex(string keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keyword)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Internal_Static_UInt32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489186, RefRangeEnd = 489187, XrefRangeStart = 489172, XrefRangeEnd = 489186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateGlobalKeyword(string keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keyword)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Internal_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string name
  {
    [CallerCount(192 /*0xC0*/), CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489187, XrefRangeEnd = 489192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShaderKeyword(string keywordName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keywordName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489192, XrefRangeEnd = 489194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref keyword
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_GetGlobalKeywordIndex_Injected_Private_Static_UInt32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489194, XrefRangeEnd = 489196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref keyword
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShaderKeyword.NativeMethodInfoPtr_CreateGlobalKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ShaderKeyword(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ShaderKeyword()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeyword>.NativeClassPtr))
  {
  }

  public unsafe string m_Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe uint m_Index
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Index));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_Index)) = value;
    }
  }

  public unsafe bool m_IsLocal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsLocal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsLocal)) = value;
    }
  }

  public unsafe bool m_IsCompute
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsCompute));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsCompute)) = value;
    }
  }

  public unsafe bool m_IsValid
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsValid));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderKeyword.NativeFieldInfoPtr_m_IsValid)) = value;
    }
  }

  public static uint GetKeywordCount(Shader shader)
  {
    return ShaderKeyword.GetKeywordCount_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<Shader>(shader));
  }

  public static unsafe uint GetKeywordIndex(Shader shader, string keyword)
  {
    try
    {
      System.IntPtr shader1 = UnityEngine.Object.MarshalledUnityObject.Marshal<Shader>(shader);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = keyword.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      return ShaderKeyword.GetKeywordIndex_Injected(shader1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static uint GetComputeShaderKeywordCount(ComputeShader shader)
  {
    return ShaderKeyword.GetComputeShaderKeywordCount_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<ComputeShader>(shader));
  }

  public static unsafe uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword)
  {
    try
    {
      System.IntPtr shader1 = UnityEngine.Object.MarshalledUnityObject.Marshal<ComputeShader>(shader);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = keyword.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      return ShaderKeyword.GetComputeShaderKeywordIndex_Injected(shader1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static ShaderKeywordType GetGlobalShaderKeywordType(uint keyword)
  {
    return ShaderKeyword.GetGlobalShaderKeywordTypeDelegateField(keyword);
  }

  public static ShaderKeywordType GetGlobalKeywordType(ShaderKeyword index)
  {
    return ((ShaderKeyword) ref index).IsValid() ? ShaderKeyword.GetGlobalShaderKeywordType(index.m_Index) : ShaderKeywordType.UserDefined;
  }

  public static bool IsKeywordLocal(ShaderKeyword keyword) => keyword.m_IsLocal;

  public bool IsValid() => this.m_IsValid;

  public bool IsValid(ComputeShader shader) => this.m_IsValid;

  public bool IsValid(Shader shader) => this.m_IsValid;

  public int index => (int) this.m_Index;

  public static ShaderKeywordType GetKeywordType(Shader shader, ShaderKeyword index)
  {
    return ShaderKeywordType.UserDefined;
  }

  public static ShaderKeywordType GetKeywordType(ComputeShader shader, ShaderKeyword index)
  {
    return ShaderKeywordType.UserDefined;
  }

  public static string GetGlobalKeywordName(ShaderKeyword index) => index.m_Name;

  public static string GetKeywordName(Shader shader, ShaderKeyword index) => index.m_Name;

  public static string GetKeywordName(ComputeShader shader, ShaderKeyword index) => index.m_Name;

  public ShaderKeywordType GetKeywordType()
  {
    // ISSUE: unable to decompile the method.
  }

  public string GetKeywordName()
  {
    // ISSUE: unable to decompile the method.
  }

  public string GetName() => this.GetKeywordName();

  public static uint GetKeywordCount_Injected(System.IntPtr shader)
  {
    return ShaderKeyword.GetKeywordCount_InjectedDelegateField(shader);
  }

  public static uint GetKeywordIndex_Injected(System.IntPtr shader, ref ManagedSpanWrapper keyword)
  {
    return ShaderKeyword.GetKeywordIndex_InjectedDelegateField(shader, (System.IntPtr) ref keyword);
  }

  public static uint GetComputeShaderKeywordCount_Injected(System.IntPtr shader)
  {
    return ShaderKeyword.GetComputeShaderKeywordCount_InjectedDelegateField(shader);
  }

  public static uint GetComputeShaderKeywordIndex_Injected(
    System.IntPtr shader,
    ref ManagedSpanWrapper keyword)
  {
    return ShaderKeyword.GetComputeShaderKeywordIndex_InjectedDelegateField(shader, (System.IntPtr) ref keyword);
  }

  private delegate ShaderKeywordType GetGlobalShaderKeywordTypeDelegate(uint keyword);

  private delegate uint GetKeywordCount_InjectedDelegate(System.IntPtr shader);

  private delegate uint GetKeywordIndex_InjectedDelegate(System.IntPtr shader, System.IntPtr keyword);

  private delegate uint GetComputeShaderKeywordCount_InjectedDelegate(System.IntPtr shader);

  private delegate uint GetComputeShaderKeywordIndex_InjectedDelegate(System.IntPtr shader, System.IntPtr keyword);
}
