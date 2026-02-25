// Decompiled with JetBrains decompiler
// Type: UnityEngine.RangeInt
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RangeInt
{
  private static readonly System.IntPtr NativeFieldInfoPtr_start;
  private static readonly System.IntPtr NativeFieldInfoPtr_length;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_end_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  [FieldOffset(0)]
  public int start;
  [FieldOffset(4)]
  public int length;

  static RangeInt()
  {
    Il2CppClassPointerStore<RangeInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RangeInt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeInt>.NativeClassPtr);
    RangeInt.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, nameof (start));
    RangeInt.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, nameof (length));
    RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100668244);
    RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100668245);
  }

  public unsafe int end
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 452971, RefRangeEnd = 452974, XrefRangeStart = 452971, XrefRangeEnd = 452971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(54)]
  [CachedScanResults(RefRangeStart = 94193, RefRangeEnd = 94247, XrefRangeStart = 94193, XrefRangeEnd = 94247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RangeInt(int start, int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
