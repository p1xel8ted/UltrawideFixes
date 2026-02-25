// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.LightmapperUtils
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

public static class LightmapperUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0;

  static LightmapperUtils()
  {
    Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (LightmapperUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670707);
    LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670708);
    LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670709);
    LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670710);
    LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670711);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670712);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670713);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670714);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670715);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670716);
    LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100670717);
  }

  [CallerCount(0)]
  public static unsafe LightMode Extract(LightmapBakeType baketype)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &baketype
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LightMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489419, XrefRangeEnd = 489423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LinearColor ExtractIndirect(Light l)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LinearColor*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489423, XrefRangeEnd = 489426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ExtractInnerCone(Light l)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489426, XrefRangeEnd = 489433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color ExtractColorTemperature(Light l)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489433, XrefRangeEnd = 489436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cct;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lightColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489463, RefRangeEnd = 489464, XrefRangeStart = 489436, XrefRangeEnd = 489463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Extract(Light l, ref DirectionalLight dir)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dir;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489492, RefRangeEnd = 489493, XrefRangeStart = 489464, XrefRangeEnd = 489492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Extract(Light l, ref PointLight point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref point;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489525, RefRangeEnd = 489526, XrefRangeStart = 489493, XrefRangeEnd = 489525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Extract(Light l, ref SpotLight spot)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489554, RefRangeEnd = 489555, XrefRangeStart = 489526, XrefRangeEnd = 489554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Extract(Light l, ref RectangleLight rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rect;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489583, RefRangeEnd = 489584, XrefRangeStart = 489555, XrefRangeEnd = 489583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Extract(Light l, ref DiscLight disc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref disc;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 489600, RefRangeEnd = 489605, XrefRangeStart = 489584, XrefRangeEnd = 489600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Extract(Light l, out Cookie cookie)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) l);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cookie;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public LightmapperUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
