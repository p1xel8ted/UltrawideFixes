// Decompiled with JetBrains decompiler
// Type: UnityEngine.Resolution
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Resolution
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Height;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshRate;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_refreshRateRatio_Public_get_RefreshRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_refreshRate_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  [FieldOffset(0)]
  public int m_Width;
  [FieldOffset(4)]
  public int m_Height;
  [FieldOffset(8)]
  public RefreshRate m_RefreshRate;

  static Resolution()
  {
    Il2CppClassPointerStore<Resolution>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Resolution));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resolution>.NativeClassPtr);
    Resolution.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, nameof (m_Width));
    Resolution.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, nameof (m_Height));
    Resolution.NativeFieldInfoPtr_m_RefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, nameof (m_RefreshRate));
    Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664805);
    Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664806);
    Resolution.NativeMethodInfoPtr_get_refreshRateRatio_Public_get_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664807);
    Resolution.NativeMethodInfoPtr_get_refreshRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664808);
    Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664809);
  }

  public unsafe int width
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Width = value;
  }

  public unsafe int height
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Height = value;
  }

  public unsafe RefreshRate refreshRateRatio
  {
    [CallerCount(29), CachedScanResults(RefRangeStart = 265578, RefRangeEnd = 265607, XrefRangeStart = 265578, XrefRangeEnd = 265607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_refreshRateRatio_Public_get_RefreshRate_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RefreshRate*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_RefreshRate = value;
  }

  public unsafe int refreshRate
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 423836, RefRangeEnd = 423838, XrefRangeStart = 423832, XrefRangeEnd = 423836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_refreshRate_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      this.m_RefreshRate.numerator = (uint) value;
      this.m_RefreshRate.denominator = 1U;
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423838, XrefRangeEnd = 423854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Resolution>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
