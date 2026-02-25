// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.LightDataGI
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct LightDataGI
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_cookieID;
  private static readonly System.IntPtr NativeFieldInfoPtr_cookieScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientation;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_range;
  private static readonly System.IntPtr NativeFieldInfoPtr_coneAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_innerConeAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_shape0;
  private static readonly System.IntPtr NativeFieldInfoPtr_shape1;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_mode;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadow;
  private static readonly System.IntPtr NativeFieldInfoPtr_falloff;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0;
  [FieldOffset(0)]
  public int instanceID;
  [FieldOffset(4)]
  public int cookieID;
  [FieldOffset(8)]
  public float cookieScale;
  [FieldOffset(12)]
  public LinearColor color;
  [FieldOffset(28)]
  public LinearColor indirectColor;
  [FieldOffset(44)]
  public Quaternion orientation;
  [FieldOffset(60)]
  public Vector3 position;
  [FieldOffset(72)]
  public float range;
  [FieldOffset(76)]
  public float coneAngle;
  [FieldOffset(80 /*0x50*/)]
  public float innerConeAngle;
  [FieldOffset(84)]
  public float shape0;
  [FieldOffset(88)]
  public float shape1;
  [FieldOffset(92)]
  public LightType type;
  [FieldOffset(93)]
  public LightMode mode;
  [FieldOffset(94)]
  public byte shadow;
  [FieldOffset(95)]
  public FalloffType falloff;

  static LightDataGI()
  {
    Il2CppClassPointerStore<LightDataGI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (LightDataGI));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr);
    LightDataGI.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (instanceID));
    LightDataGI.NativeFieldInfoPtr_cookieID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (cookieID));
    LightDataGI.NativeFieldInfoPtr_cookieScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (cookieScale));
    LightDataGI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (color));
    LightDataGI.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (indirectColor));
    LightDataGI.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (orientation));
    LightDataGI.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (position));
    LightDataGI.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (range));
    LightDataGI.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (coneAngle));
    LightDataGI.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (innerConeAngle));
    LightDataGI.NativeFieldInfoPtr_shape0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (shape0));
    LightDataGI.NativeFieldInfoPtr_shape1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (shape1));
    LightDataGI.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (type));
    LightDataGI.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (mode));
    LightDataGI.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (shadow));
    LightDataGI.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, nameof (falloff));
    LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100670701);
    LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100670702);
    LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100670703);
    LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100670704);
    LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100670705);
    LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100670706);
  }

  [CallerCount(0)]
  public unsafe void Init(ref DirectionalLight light, ref Cookie cookie)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref light;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cookie;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Init(ref PointLight light, ref Cookie cookie)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref light;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cookie;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Init(ref SpotLight light, ref Cookie cookie)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref light;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cookie;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Init(ref RectangleLight light, ref Cookie cookie)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref light;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cookie;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Init(ref DiscLight light, ref Cookie cookie)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref light;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cookie;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void InitNoBake(int lightInstanceID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &lightInstanceID
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void Init(ref DirectionalLight light)
  {
    Cookie cookie = Cookie.Defaults();
    this.Init(ref light, ref cookie);
  }

  public void Init(ref PointLight light)
  {
    Cookie cookie = Cookie.Defaults();
    this.Init(ref light, ref cookie);
  }

  public void Init(ref SpotLight light)
  {
    Cookie cookie = Cookie.Defaults();
    this.Init(ref light, ref cookie);
  }

  public void Init(ref RectangleLight light)
  {
    Cookie cookie = Cookie.Defaults();
    this.Init(ref light, ref cookie);
  }

  public void Init(ref DiscLight light)
  {
    Cookie cookie = Cookie.Defaults();
    this.Init(ref light, ref cookie);
  }
}
