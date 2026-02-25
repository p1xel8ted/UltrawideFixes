// Decompiled with JetBrains decompiler
// Type: UnityEngine.GradientAlphaKey
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct GradientAlphaKey
{
  private static readonly System.IntPtr NativeFieldInfoPtr_alpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_time;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  [FieldOffset(0)]
  public float alpha;
  [FieldOffset(4)]
  public float time;

  static GradientAlphaKey()
  {
    Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (GradientAlphaKey));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr);
    GradientAlphaKey.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, nameof (alpha));
    GradientAlphaKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, nameof (time));
    GradientAlphaKey.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, 100667288);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 21792, RefRangeEnd = 21797, XrefRangeStart = 21792, XrefRangeEnd = 21797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GradientAlphaKey(float alpha, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &alpha;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GradientAlphaKey.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
