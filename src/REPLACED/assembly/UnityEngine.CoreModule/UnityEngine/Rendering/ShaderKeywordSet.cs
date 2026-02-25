// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShaderKeywordSet
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShaderKeywordSet
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_KeywordState;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Shader;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ComputeShader;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StateIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public System.IntPtr m_KeywordState;
  [FieldOffset(8)]
  public System.IntPtr m_Shader;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ComputeShader;
  [FieldOffset(24)]
  public ulong m_StateIndex;
  private static readonly ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegate IsGlobalKeywordEnabled_InjectedDelegateField;
  private static readonly ShaderKeywordSet.IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;
  private static readonly ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegate EnableGlobalKeyword_InjectedDelegateField;
  private static readonly ShaderKeywordSet.EnableKeywordName_InjectedDelegate EnableKeywordName_InjectedDelegateField;
  private static readonly ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegate DisableGlobalKeyword_InjectedDelegateField;
  private static readonly ShaderKeywordSet.DisableKeywordName_InjectedDelegate DisableKeywordName_InjectedDelegateField;
  private static readonly ShaderKeywordSet.GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;

  static ShaderKeywordSet()
  {
    Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ShaderKeywordSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr);
    ShaderKeywordSet.NativeFieldInfoPtr_m_KeywordState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, nameof (m_KeywordState));
    ShaderKeywordSet.NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, nameof (m_Shader));
    ShaderKeywordSet.NativeFieldInfoPtr_m_ComputeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, nameof (m_ComputeShader));
    ShaderKeywordSet.NativeFieldInfoPtr_m_StateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, nameof (m_StateIndex));
    ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100670674);
    ShaderKeywordSet.NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100670675);
    ShaderKeywordSet.NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100670676);
    ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, 100670677);
    ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsGlobalKeywordEnabled_Injected");
    ShaderKeywordSet.IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.IsKeywordEnabled_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::IsKeywordEnabled_Injected");
    ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableGlobalKeyword_Injected");
    ShaderKeywordSet.EnableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.EnableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::EnableKeywordName_Injected");
    ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableGlobalKeyword_Injected");
    ShaderKeywordSet.DisableKeywordName_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.DisableKeywordName_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::DisableKeywordName_Injected");
    ShaderKeywordSet.GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<ShaderKeywordSet.GetEnabledKeywords_InjectedDelegate>("UnityEngine.Rendering.ShaderKeywordSet::GetEnabledKeywords_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489210, RefRangeEnd = 489211, XrefRangeStart = 489196, XrefRangeEnd = 489210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsKeywordNameEnabled(ShaderKeywordSet state, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &state;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Private_Static_Boolean_ShaderKeywordSet_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489211, XrefRangeEnd = 489219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckKeywordCompatible(ShaderKeyword keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) keyword))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_CheckKeywordCompatible_Private_Void_ShaderKeyword_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 489228, RefRangeEnd = 489232, XrefRangeStart = 489219, XrefRangeEnd = 489228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsEnabled(ShaderKeyword keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) keyword))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsEnabled_Public_Boolean_ShaderKeyword_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489232, XrefRangeEnd = 489234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsKeywordNameEnabled_Injected(
    [In] ref ShaderKeywordSet state,
    ref ManagedSpanWrapper name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref state;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderKeywordSet.NativeMethodInfoPtr_IsKeywordNameEnabled_Injected_Private_Static_Boolean_byref_ShaderKeywordSet_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderKeywordSet>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool IsGlobalKeywordEnabled(ShaderKeywordSet state, uint index)
  {
    return ShaderKeywordSet.IsGlobalKeywordEnabled_Injected(ref state, index);
  }

  public static bool IsKeywordEnabled(
    ShaderKeywordSet state,
    LocalKeywordSpace keywordSpace,
    uint index)
  {
    return ShaderKeywordSet.IsKeywordEnabled_Injected(ref state, ref keywordSpace, index);
  }

  public static void EnableGlobalKeyword(ShaderKeywordSet state, uint index)
  {
    ShaderKeywordSet.EnableGlobalKeyword_Injected(ref state, index);
  }

  public static unsafe void EnableKeywordName(ShaderKeywordSet state, string name)
  {
    try
    {
      ref ShaderKeywordSet local1 = ref state;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper;
      ShaderKeywordSet.EnableKeywordName_Injected(ref local1, ref local2);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void DisableGlobalKeyword(ShaderKeywordSet state, uint index)
  {
    ShaderKeywordSet.DisableGlobalKeyword_Injected(ref state, index);
  }

  public static unsafe void DisableKeywordName(ShaderKeywordSet state, string name)
  {
    try
    {
      ref ShaderKeywordSet local1 = ref state;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper;
      ShaderKeywordSet.DisableKeywordName_Injected(ref local1, ref local2);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords(ShaderKeywordSet state)
  {
    return ShaderKeywordSet.GetEnabledKeywords_Injected(ref state);
  }

  public bool IsEnabled(GlobalKeyword keyword)
  {
    return ShaderKeywordSet.IsGlobalKeywordEnabled(this, keyword.m_Index);
  }

  public bool IsEnabled(LocalKeyword keyword)
  {
    return ShaderKeywordSet.IsKeywordEnabled(this, keyword.m_SpaceInfo, keyword.m_Index);
  }

  public void Enable(ShaderKeyword keyword)
  {
    this.CheckKeywordCompatible(keyword);
    if (keyword.m_IsLocal || !((ShaderKeyword) ref keyword).IsValid())
      ShaderKeywordSet.EnableKeywordName(this, keyword.m_Name);
    else
      ShaderKeywordSet.EnableGlobalKeyword(this, keyword.m_Index);
  }

  public void Disable(ShaderKeyword keyword)
  {
    if (keyword.m_IsLocal || !((ShaderKeyword) ref keyword).IsValid())
      ShaderKeywordSet.DisableKeywordName(this, keyword.m_Name);
    else
      ShaderKeywordSet.DisableGlobalKeyword(this, keyword.m_Index);
  }

  public Il2CppReferenceArray<ShaderKeyword> GetShaderKeywords()
  {
    return ShaderKeywordSet.GetEnabledKeywords(this);
  }

  public static bool IsGlobalKeywordEnabled_Injected([In] ref ShaderKeywordSet state, uint index)
  {
    return ShaderKeywordSet.IsGlobalKeywordEnabled_InjectedDelegateField((System.IntPtr) ref state, index);
  }

  public static bool IsKeywordEnabled_Injected(
    [In] ref ShaderKeywordSet state,
    [In] ref LocalKeywordSpace keywordSpace,
    uint index)
  {
    return ShaderKeywordSet.IsKeywordEnabled_InjectedDelegateField((System.IntPtr) ref state, (System.IntPtr) ref keywordSpace, index);
  }

  public static void EnableGlobalKeyword_Injected([In] ref ShaderKeywordSet state, uint index)
  {
    ShaderKeywordSet.EnableGlobalKeyword_InjectedDelegateField((System.IntPtr) ref state, index);
  }

  public static void EnableKeywordName_Injected(
    [In] ref ShaderKeywordSet state,
    ref ManagedSpanWrapper name)
  {
    ShaderKeywordSet.EnableKeywordName_InjectedDelegateField((System.IntPtr) ref state, (System.IntPtr) ref name);
  }

  public static void DisableGlobalKeyword_Injected([In] ref ShaderKeywordSet state, uint index)
  {
    ShaderKeywordSet.DisableGlobalKeyword_InjectedDelegateField((System.IntPtr) ref state, index);
  }

  public static void DisableKeywordName_Injected(
    [In] ref ShaderKeywordSet state,
    ref ManagedSpanWrapper name)
  {
    ShaderKeywordSet.DisableKeywordName_InjectedDelegateField((System.IntPtr) ref state, (System.IntPtr) ref name);
  }

  public static Il2CppReferenceArray<ShaderKeyword> GetEnabledKeywords_Injected(
    [In] ref ShaderKeywordSet state)
  {
    System.IntPtr num = ShaderKeywordSet.GetEnabledKeywords_InjectedDelegateField((System.IntPtr) ref state);
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ShaderKeyword>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ShaderKeyword>>(num);
  }

  private delegate bool IsGlobalKeywordEnabled_InjectedDelegate([In] System.IntPtr state, uint index);

  private delegate bool IsKeywordEnabled_InjectedDelegate(
    [In] System.IntPtr state,
    [In] System.IntPtr keywordSpace,
    uint index);

  private delegate void EnableGlobalKeyword_InjectedDelegate([In] System.IntPtr state, uint index);

  private delegate void EnableKeywordName_InjectedDelegate([In] System.IntPtr state, System.IntPtr name);

  private delegate void DisableGlobalKeyword_InjectedDelegate([In] System.IntPtr state, uint index);

  private delegate void DisableKeywordName_InjectedDelegate([In] System.IntPtr state, System.IntPtr name);

  private delegate System.IntPtr GetEnabledKeywords_InjectedDelegate([In] System.IntPtr state);
}
