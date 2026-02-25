// Decompiled with JetBrains decompiler
// Type: UnityEngineInternal.MathfInternal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngineInternal;

[StructLayout(LayoutKind.Explicit)]
public struct MathfInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_FloatMinNormal;
  private static readonly System.IntPtr NativeFieldInfoPtr_FloatMinDenormal;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsFlushToZeroEnabled;

  static MathfInternal()
  {
    Il2CppClassPointerStore<MathfInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", nameof (MathfInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr);
    MathfInternal.NativeFieldInfoPtr_FloatMinNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, nameof (FloatMinNormal));
    MathfInternal.NativeFieldInfoPtr_FloatMinDenormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, nameof (FloatMinDenormal));
    MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, nameof (IsFlushToZeroEnabled));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe float FloatMinNormal
  {
    get
    {
      float floatMinNormal;
      IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_FloatMinNormal, (void*) &floatMinNormal);
      return floatMinNormal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_FloatMinNormal, (void*) &value);
    }
  }

  public static unsafe float FloatMinDenormal
  {
    get
    {
      float floatMinDenormal;
      IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_FloatMinDenormal, (void*) &floatMinDenormal);
      return floatMinDenormal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_FloatMinDenormal, (void*) &value);
    }
  }

  public static unsafe bool IsFlushToZeroEnabled
  {
    get
    {
      bool flushToZeroEnabled;
      IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*) &flushToZeroEnabled);
      return flushToZeroEnabled;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*) &value);
    }
  }
}
