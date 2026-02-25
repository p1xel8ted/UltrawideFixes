// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.Lightmapping
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

public static class Lightmapping : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultDelegate;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_RequestLightsDelegate;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0;

  static Lightmapping()
  {
    Il2CppClassPointerStore<Lightmapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (Lightmapping));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr);
    Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, nameof (s_DefaultDelegate));
    Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, nameof (s_RequestLightsDelegate));
    Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100670718);
    Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100670719);
    Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100670720 /*0x06001D00*/);
    Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100670721);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489626, XrefRangeEnd = 489632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetDelegate(Lightmapping.RequestLightsDelegate del)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) del)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489632, XrefRangeEnd = 489636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Lightmapping.RequestLightsDelegate GetDelegate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Lightmapping.RequestLightsDelegate) null : Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489636, XrefRangeEnd = 489640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetDelegate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489640, XrefRangeEnd = 489648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RequestLights(
    Il2CppReferenceArray<Light> lights,
    System.IntPtr outLightsPtr,
    int outLightsCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lights);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outLightsPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &outLightsCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Lightmapping(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Lightmapping.RequestLightsDelegate s_DefaultDelegate
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Lightmapping.RequestLightsDelegate) null : Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Lightmapping.RequestLightsDelegate s_RequestLightsDelegate
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Lightmapping.RequestLightsDelegate) null : Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class RequestLightsDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;

    static RequestLightsDelegate()
    {
      Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, nameof (RequestLightsDelegate));
      Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100670723);
      Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100670724);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489605, XrefRangeEnd = 489608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RequestLightsDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(
      Il2CppReferenceArray<Light> requests,
      NativeArray<LightDataGI> lightsOutput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requests);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) lightsOutput));
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator Lightmapping.RequestLightsDelegate(
      [In] System.Action<Il2CppReferenceArray<Light>, NativeArray<LightDataGI>> obj0)
    {
      return DelegateSupport.ConvertDelegate<Lightmapping.RequestLightsDelegate>((System.Delegate) obj0);
    }

    public static Lightmapping.RequestLightsDelegate operator +(
      [In] Lightmapping.RequestLightsDelegate obj0,
      [In] Lightmapping.RequestLightsDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Lightmapping.RequestLightsDelegate>();
    }

    public static Lightmapping.RequestLightsDelegate operator -(
      [In] Lightmapping.RequestLightsDelegate obj0,
      [In] Lightmapping.RequestLightsDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (Lightmapping.RequestLightsDelegate) @delegate : @delegate.Cast<Lightmapping.RequestLightsDelegate>();
    }
  }

  [ObfuscatedName("UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;

    static __c()
    {
      Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr);
      Lightmapping.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, "<>9");
      Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100670726);
      Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100670727);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489608, XrefRangeEnd = 489626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __cctor_b__7_0(
      Il2CppReferenceArray<Light> requests,
      NativeArray<LightDataGI> lightsOutput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requests);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) lightsOutput));
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe Lightmapping.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Lightmapping.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Lightmapping.__c) null : Il2CppObjectPool.Get<Lightmapping.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Lightmapping.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }
}
