// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.LocalKeywordSpace
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
public struct LocalKeywordSpace
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_KeywordSpace;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public readonly System.IntPtr m_KeywordSpace;
  private static readonly LocalKeywordSpace.GetKeywordsDelegate GetKeywordsDelegateField;
  private static readonly LocalKeywordSpace.GetKeywordNamesDelegate GetKeywordNamesDelegateField;
  private static readonly LocalKeywordSpace.GetKeywordCountDelegate GetKeywordCountDelegateField;
  private static readonly LocalKeywordSpace.GetKeyword_InjectedDelegate GetKeyword_InjectedDelegateField;

  static LocalKeywordSpace()
  {
    Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (LocalKeywordSpace));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr);
    LocalKeywordSpace.NativeFieldInfoPtr_m_KeywordSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, nameof (m_KeywordSpace));
    LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100670660);
    LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100670661);
    LocalKeywordSpace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100670662);
    LocalKeywordSpace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100670663);
    LocalKeywordSpace.GetKeywordsDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordsDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywords");
    LocalKeywordSpace.GetKeywordNamesDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordNamesDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordNames");
    LocalKeywordSpace.GetKeywordCountDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordCountDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordCount");
    LocalKeywordSpace.GetKeyword_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeyword_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeyword_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489138, XrefRangeEnd = 489141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object o)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 328469, RefRangeEnd = 328475, XrefRangeStart = 328469, XrefRangeEnd = 328475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(LocalKeywordSpace rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rhs
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Il2CppReferenceArray<LocalKeyword> GetKeywords()
  {
    System.IntPtr num = LocalKeywordSpace.GetKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<LocalKeyword>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(num);
  }

  public Il2CppStringArray GetKeywordNames()
  {
    System.IntPtr num = LocalKeywordSpace.GetKeywordNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
    return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
  }

  public uint GetKeywordCount()
  {
    return LocalKeywordSpace.GetKeywordCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public unsafe LocalKeyword GetKeyword(string name)
  {
    LocalKeyword ret;
    LocalKeyword keyword;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      LocalKeywordSpace.GetKeyword_Injected(ref this, ref managedSpanWrapper, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      keyword = ret;
    }
    return keyword;
  }

  public Il2CppReferenceArray<LocalKeyword> keywords => this.GetKeywords();

  public Il2CppStringArray keywordNames => this.GetKeywordNames();

  public uint keywordCount => this.GetKeywordCount();

  public LocalKeyword FindKeyword(string name) => this.GetKeyword(name);

  public static bool operator !=(LocalKeywordSpace lhs, LocalKeywordSpace rhs) => !(lhs == rhs);

  public static unsafe void GetKeyword_Injected(
    ref LocalKeywordSpace _unity_self,
    ref ManagedSpanWrapper name,
    out LocalKeyword ret)
  {
    LocalKeywordSpace.GetKeyword_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref name, (System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ret));
  }

  private delegate System.IntPtr GetKeywordsDelegate(System.IntPtr _param1);

  private delegate System.IntPtr GetKeywordNamesDelegate(System.IntPtr _param1);

  private delegate uint GetKeywordCountDelegate(System.IntPtr _param1);

  private delegate void GetKeyword_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, [Out] System.IntPtr ret);
}
