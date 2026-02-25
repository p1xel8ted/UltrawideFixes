// Decompiled with JetBrains decompiler
// Type: UnityEngine.SortingLayer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct SortingLayer
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0;
  [FieldOffset(0)]
  public int m_Id;
  private static readonly SortingLayer.IsValidDelegate IsValidDelegateField;
  private static readonly SortingLayer.GetSortingLayerIDsInternal_InjectedDelegate GetSortingLayerIDsInternal_InjectedDelegateField;
  private static readonly SortingLayer.GetLayerValueFromName_InjectedDelegate GetLayerValueFromName_InjectedDelegateField;
  private static readonly SortingLayer.NameToID_InjectedDelegate NameToID_InjectedDelegateField;
  private static readonly SortingLayer.IDToName_InjectedDelegate IDToName_InjectedDelegateField;

  static SortingLayer()
  {
    Il2CppClassPointerStore<SortingLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SortingLayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr);
    SortingLayer.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, nameof (m_Id));
    SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663779);
    SortingLayer.IsValidDelegateField = IL2CPP.ResolveICall<SortingLayer.IsValidDelegate>("UnityEngine.SortingLayer::IsValid");
    SortingLayer.GetSortingLayerIDsInternal_InjectedDelegateField = IL2CPP.ResolveICall<SortingLayer.GetSortingLayerIDsInternal_InjectedDelegate>("UnityEngine.SortingLayer::GetSortingLayerIDsInternal_Injected");
    SortingLayer.GetLayerValueFromName_InjectedDelegateField = IL2CPP.ResolveICall<SortingLayer.GetLayerValueFromName_InjectedDelegate>("UnityEngine.SortingLayer::GetLayerValueFromName_Injected");
    SortingLayer.NameToID_InjectedDelegateField = IL2CPP.ResolveICall<SortingLayer.NameToID_InjectedDelegate>("UnityEngine.SortingLayer::NameToID_Injected");
    SortingLayer.IDToName_InjectedDelegateField = IL2CPP.ResolveICall<SortingLayer.IDToName_InjectedDelegate>("UnityEngine.SortingLayer::IDToName_Injected");
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 415829, RefRangeEnd = 415831, XrefRangeStart = 415827, XrefRangeEnd = 415829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetLayerValueFromID(int id)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public int id => this.m_Id;

  public string name => SortingLayer.IDToName(this.m_Id);

  public int value => SortingLayer.GetLayerValueFromID(this.m_Id);

  public static Il2CppStructArray<SortingLayer> layers
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppStructArray<int> GetSortingLayerIDsInternal()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<int> layerIdsInternal;
    try
    {
      SortingLayer.GetSortingLayerIDsInternal_Injected(out ret);
    }
    finally
    {
      Il2CppStructArray<int> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<int>((Il2CppArrayBase<int>&) ref il2CppStructArray);
      layerIdsInternal = il2CppStructArray;
    }
    return layerIdsInternal;
  }

  public static unsafe int GetLayerValueFromName(string name)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return SortingLayer.GetLayerValueFromName_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe int NameToID(string name)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return SortingLayer.NameToID_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static string IDToName(int id)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      SortingLayer.IDToName_Injected(id, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static bool IsValid(int id) => SortingLayer.IsValidDelegateField(id);

  public static void GetSortingLayerIDsInternal_Injected(out BlittableArrayWrapper ret)
  {
    SortingLayer.GetSortingLayerIDsInternal_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static int GetLayerValueFromName_Injected(ref ManagedSpanWrapper name)
  {
    return SortingLayer.GetLayerValueFromName_InjectedDelegateField((System.IntPtr) ref name);
  }

  public static int NameToID_Injected(ref ManagedSpanWrapper name)
  {
    return SortingLayer.NameToID_InjectedDelegateField((System.IntPtr) ref name);
  }

  public static void IDToName_Injected(int id, out ManagedSpanWrapper ret)
  {
    SortingLayer.IDToName_InjectedDelegateField(id, (System.IntPtr) ref ret);
  }

  private delegate bool IsValidDelegate(int id);

  private delegate void GetSortingLayerIDsInternal_InjectedDelegate([Out] System.IntPtr ret);

  private delegate int GetLayerValueFromName_InjectedDelegate(System.IntPtr name);

  private delegate int NameToID_InjectedDelegate(System.IntPtr name);

  private delegate void IDToName_InjectedDelegate(int id, [Out] System.IntPtr ret);
}
