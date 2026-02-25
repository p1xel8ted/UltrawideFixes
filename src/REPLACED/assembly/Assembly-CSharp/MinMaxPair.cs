// Decompiled with JetBrains decompiler
// Type: MinMaxPair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MinMaxPair
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Min;
  private static readonly System.IntPtr NativeFieldInfoPtr_Max;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RandomValue_Public_get_Single_0;
  [FieldOffset(0)]
  public float Min;
  [FieldOffset(4)]
  public float Max;

  static MinMaxPair()
  {
    Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MinMaxPair));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr);
    MinMaxPair.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr, nameof (Min));
    MinMaxPair.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr, nameof (Max));
    MinMaxPair.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr, 100663616 /*0x06000140*/);
    MinMaxPair.NativeMethodInfoPtr_Clamp_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr, 100663617);
    MinMaxPair.NativeMethodInfoPtr_get_RandomValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr, 100663618);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 21792, RefRangeEnd = 21797, XrefRangeStart = 21792, XrefRangeEnd = 21792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MinMaxPair(float min, float max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MinMaxPair.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe float Clamp(float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MinMaxPair.NativeMethodInfoPtr_Clamp_Public_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float RandomValue
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21797, XrefRangeEnd = 21798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MinMaxPair.NativeMethodInfoPtr_get_RandomValue_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinMaxPair>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
