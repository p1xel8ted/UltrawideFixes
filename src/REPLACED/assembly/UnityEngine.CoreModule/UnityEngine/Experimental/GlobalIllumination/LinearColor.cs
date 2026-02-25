// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.LinearColor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct LinearColor
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_red;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_green;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_blue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_intensity;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_red_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_red_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_green_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_green_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_blue_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Black_Public_Static_LinearColor_0;
  [FieldOffset(0)]
  public float m_red;
  [FieldOffset(4)]
  public float m_green;
  [FieldOffset(8)]
  public float m_blue;
  [FieldOffset(12)]
  public float m_intensity;

  static LinearColor()
  {
    Il2CppClassPointerStore<LinearColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (LinearColor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearColor>.NativeClassPtr);
    LinearColor.NativeFieldInfoPtr_m_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, nameof (m_red));
    LinearColor.NativeFieldInfoPtr_m_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, nameof (m_green));
    LinearColor.NativeFieldInfoPtr_m_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, nameof (m_blue));
    LinearColor.NativeFieldInfoPtr_m_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, nameof (m_intensity));
    LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670693);
    LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670694);
    LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670695);
    LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670696);
    LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670697);
    LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670698);
    LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670699);
    LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100670700);
  }

  public unsafe float red
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 415878, RefRangeEnd = 415991, XrefRangeStart = 415878, XrefRangeEnd = 415991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_red_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 489361, RefRangeEnd = 489372, XrefRangeStart = 489361, XrefRangeEnd = 489361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_red_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float green
  {
    [CallerCount(95), CachedScanResults(RefRangeStart = 415991, RefRangeEnd = 416086, XrefRangeStart = 415991, XrefRangeEnd = 416086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_green_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 489372, RefRangeEnd = 489383, XrefRangeStart = 489372, XrefRangeEnd = 489372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_green_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float blue
  {
    [CallerCount(45), CachedScanResults(RefRangeStart = 416086, RefRangeEnd = 416131, XrefRangeStart = 416086, XrefRangeEnd = 416131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_get_blue_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 489383, RefRangeEnd = 489394, XrefRangeStart = 489383, XrefRangeEnd = 489383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 489408, RefRangeEnd = 489419, XrefRangeStart = 489394, XrefRangeEnd = 489408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LinearColor Convert(Color color, float intensity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &intensity;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LinearColor*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe LinearColor Black()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinearColor.NativeMethodInfoPtr_Black_Public_Static_LinearColor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LinearColor*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public float intensity
  {
    get => this.m_intensity;
    set
    {
      this.m_intensity = (double) value >= 0.0 ? value : throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Concat("Intensity (", value.ToString(), ") must be positive."));
    }
  }
}
