// Decompiled with JetBrains decompiler
// Type: UnityEngine.TagHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct TagHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr__tagIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TagToString_Private_Static_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TagToString_Injected_Private_Static_Void_UInt32_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public uint _tagIndex;
  private static readonly TagHandle.ExtractTagThrowing_InjectedDelegate ExtractTagThrowing_InjectedDelegateField;

  static TagHandle()
  {
    Il2CppClassPointerStore<TagHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TagHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagHandle>.NativeClassPtr);
    TagHandle.NativeFieldInfoPtr__tagIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagHandle>.NativeClassPtr, nameof (_tagIndex));
    TagHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagHandle>.NativeClassPtr, 100668270);
    TagHandle.NativeMethodInfoPtr_TagToString_Private_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagHandle>.NativeClassPtr, 100668271);
    TagHandle.NativeMethodInfoPtr_TagToString_Injected_Private_Static_Void_UInt32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagHandle>.NativeClassPtr, 100668272);
    TagHandle.ExtractTagThrowing_InjectedDelegateField = IL2CPP.ResolveICall<TagHandle.ExtractTagThrowing_InjectedDelegate>("UnityEngine.TagHandle::ExtractTagThrowing_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453374, XrefRangeEnd = 453375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TagHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 453380, RefRangeEnd = 453381, XrefRangeStart = 453375, XrefRangeEnd = 453380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string TagToString(uint tagIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &tagIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TagHandle.NativeMethodInfoPtr_TagToString_Private_Static_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453381, XrefRangeEnd = 453383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TagToString_Injected(uint tagIndex, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &tagIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TagHandle.NativeMethodInfoPtr_TagToString_Injected_Private_Static_Void_UInt32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TagHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static TagHandle GetExistingTag(string tagName)
  {
    return new TagHandle()
    {
      _tagIndex = TagHandle.ExtractTagThrowing(tagName)
    };
  }

  public static unsafe uint ExtractTagThrowing(string tagName)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(tagName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = tagName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return TagHandle.ExtractTagThrowing_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static uint ExtractTagThrowing_Injected(ref ManagedSpanWrapper tagName)
  {
    return TagHandle.ExtractTagThrowing_InjectedDelegateField((System.IntPtr) ref tagName);
  }

  private delegate uint ExtractTagThrowing_InjectedDelegate(System.IntPtr tagName);
}
