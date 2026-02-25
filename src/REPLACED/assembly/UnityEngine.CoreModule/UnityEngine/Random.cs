// Decompiled with JetBrains decompiler
// Type: UnityEngine.Random
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class Random : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_Static_get_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0;
  private static readonly Random.GetRandomUnitCircleDelegate GetRandomUnitCircleDelegateField;
  private static readonly Random.get_seedDelegate get_seedDelegateField;
  private static readonly Random.set_seedDelegate set_seedDelegateField;
  private static readonly Random.get_insideUnitSphere_InjectedDelegate get_insideUnitSphere_InjectedDelegateField;
  private static readonly Random.get_onUnitSphere_InjectedDelegate get_onUnitSphere_InjectedDelegateField;
  private static readonly Random.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField;
  private static readonly Random.get_rotationUniform_InjectedDelegate get_rotationUniform_InjectedDelegateField;

  static Random()
  {
    Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Random));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
    Random.NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667761);
    Random.NativeMethodInfoPtr_get_state_Public_Static_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667762);
    Random.NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667763);
    Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667764);
    Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667765);
    Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667766);
    Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667767);
    Random.NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667768);
    Random.NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100667769);
    Random.GetRandomUnitCircleDelegateField = IL2CPP.ResolveICall<Random.GetRandomUnitCircleDelegate>("UnityEngine.Random::GetRandomUnitCircle");
    Random.get_seedDelegateField = IL2CPP.ResolveICall<Random.get_seedDelegate>("UnityEngine.Random::get_seed");
    Random.set_seedDelegateField = IL2CPP.ResolveICall<Random.set_seedDelegate>("UnityEngine.Random::set_seed");
    Random.get_insideUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_insideUnitSphere_InjectedDelegate>("UnityEngine.Random::get_insideUnitSphere_Injected");
    Random.get_onUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_onUnitSphere_InjectedDelegate>("UnityEngine.Random::get_onUnitSphere_Injected");
    Random.get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotation_InjectedDelegate>("UnityEngine.Random::get_rotation_Injected");
    Random.get_rotationUniform_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotationUniform_InjectedDelegate>("UnityEngine.Random::get_rotationUniform_Injected");
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 441946, RefRangeEnd = 441949, XrefRangeStart = 441944, XrefRangeEnd = 441946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitState(int seed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &seed
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Random.State state
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441949, XrefRangeEnd = 441951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_state_Public_Static_get_State_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Random.State*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441951, XrefRangeEnd = 441953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(63 /*0x3F*/)]
  [CachedScanResults(RefRangeStart = 441955, RefRangeEnd = 442018, XrefRangeStart = 441953, XrefRangeEnd = 441955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Range(float minInclusive, float maxInclusive)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &minInclusive;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxInclusive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(55)]
  [CachedScanResults(RefRangeStart = 442020, RefRangeEnd = 442075, XrefRangeStart = 442018, XrefRangeEnd = 442020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Range(int minInclusive, int maxExclusive)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &minInclusive;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxExclusive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(55)]
  [CachedScanResults(RefRangeStart = 442020, RefRangeEnd = 442075, XrefRangeStart = 442020, XrefRangeEnd = 442075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int RandomRangeInt(int minInclusive, int maxExclusive)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &minInclusive;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxExclusive;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe float value
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 442077, RefRangeEnd = 442086, XrefRangeStart = 442075, XrefRangeEnd = 442077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442086, XrefRangeEnd = 442088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_state_Injected(out Random.State ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442088, XrefRangeEnd = 442090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_state_Injected([In] ref Random.State value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Random(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static Vector3 insideUnitSphere
  {
    get
    {
      Vector3 ret;
      Random.get_insideUnitSphere_Injected(out ret);
      return ret;
    }
  }

  public static void GetRandomUnitCircle(out Vector2 output)
  {
    Random.GetRandomUnitCircleDelegateField((System.IntPtr) ref output);
  }

  public static Vector2 insideUnitCircle
  {
    get
    {
      Vector2 output;
      Random.GetRandomUnitCircle(out output);
      return output;
    }
  }

  public static Vector3 onUnitSphere
  {
    get
    {
      Vector3 ret;
      Random.get_onUnitSphere_Injected(out ret);
      return ret;
    }
  }

  public static Quaternion rotation
  {
    get
    {
      Quaternion ret;
      Random.get_rotation_Injected(out ret);
      return ret;
    }
  }

  public static Quaternion rotationUniform
  {
    get
    {
      Quaternion ret;
      Random.get_rotationUniform_Injected(out ret);
      return ret;
    }
  }

  public static int seed
  {
    get => Random.get_seedDelegateField();
    set => Random.set_seedDelegateField(value);
  }

  public static float RandomRange(float min, float max) => Random.Range(min, max);

  public static int RandomRange(int min, int max) => Random.Range(min, max);

  public static Color ColorHSV() => Random.ColorHSV(0.0f, 1f, 0.0f, 1f, 0.0f, 1f, 1f, 1f);

  public static Color ColorHSV(float hueMin, float hueMax)
  {
    return Random.ColorHSV(hueMin, hueMax, 0.0f, 1f, 0.0f, 1f, 1f, 1f);
  }

  public static Color ColorHSV(
    float hueMin,
    float hueMax,
    float saturationMin,
    float saturationMax)
  {
    return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0.0f, 1f, 1f, 1f);
  }

  public static Color ColorHSV(
    float hueMin,
    float hueMax,
    float saturationMin,
    float saturationMax,
    float valueMin,
    float valueMax)
  {
    return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
  }

  public static Color ColorHSV(
    float hueMin,
    float hueMax,
    float saturationMin,
    float saturationMax,
    float valueMin,
    float valueMax,
    float alphaMin,
    float alphaMax)
  {
    return Color.HSVToRGB(Mathf.Lerp(hueMin, hueMax, Random.value), Mathf.Lerp(saturationMin, saturationMax, Random.value), Mathf.Lerp(valueMin, valueMax, Random.value), true) with
    {
      a = Mathf.Lerp(alphaMin, alphaMax, Random.value)
    };
  }

  public static void get_insideUnitSphere_Injected(out Vector3 ret)
  {
    Random.get_insideUnitSphere_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_onUnitSphere_Injected(out Vector3 ret)
  {
    Random.get_onUnitSphere_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_rotation_Injected(out Quaternion ret)
  {
    Random.get_rotation_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void get_rotationUniform_Injected(out Quaternion ret)
  {
    Random.get_rotationUniform_InjectedDelegateField((System.IntPtr) ref ret);
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct State
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_s0;
    private static readonly System.IntPtr NativeFieldInfoPtr_s1;
    private static readonly System.IntPtr NativeFieldInfoPtr_s2;
    private static readonly System.IntPtr NativeFieldInfoPtr_s3;
    [FieldOffset(0)]
    public int s0;
    [FieldOffset(4)]
    public int s1;
    [FieldOffset(8)]
    public int s2;
    [FieldOffset(12)]
    public int s3;

    static State()
    {
      Il2CppClassPointerStore<Random.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Random>.NativeClassPtr, nameof (State));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random.State>.NativeClassPtr);
      Random.State.NativeFieldInfoPtr_s0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, nameof (s0));
      Random.State.NativeFieldInfoPtr_s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, nameof (s1));
      Random.State.NativeFieldInfoPtr_s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, nameof (s2));
      Random.State.NativeFieldInfoPtr_s3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, nameof (s3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Random.State>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  private delegate void GetRandomUnitCircleDelegate([Out] System.IntPtr output);

  private delegate int get_seedDelegate();

  private delegate void set_seedDelegate(int value);

  private delegate void get_insideUnitSphere_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_onUnitSphere_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_rotation_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void get_rotationUniform_InjectedDelegate([Out] System.IntPtr ret);
}
