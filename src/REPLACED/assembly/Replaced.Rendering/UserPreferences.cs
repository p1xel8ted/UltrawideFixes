// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UserPreferences
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct UserPreferences
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kBrightnessMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_kBrightnessMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_Brightness;
  private static readonly System.IntPtr NativeFieldInfoPtr_brightnessOffset;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeUserPreferences_Public_Static_UserPreferences_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Single_0;
  [FieldOffset(0)]
  public readonly float brightnessOffset;

  static UserPreferences()
  {
    Il2CppClassPointerStore<UserPreferences>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UserPreferences));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr);
    UserPreferences.NativeFieldInfoPtr_kBrightnessMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, nameof (kBrightnessMin));
    UserPreferences.NativeFieldInfoPtr_kBrightnessMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, nameof (kBrightnessMax));
    UserPreferences.NativeFieldInfoPtr_Brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, nameof (Brightness));
    UserPreferences.NativeFieldInfoPtr_brightnessOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, nameof (brightnessOffset));
    UserPreferences.NativeMethodInfoPtr_MakeUserPreferences_Public_Static_UserPreferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, 100663661);
    UserPreferences.NativeMethodInfoPtr__ctor_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, 100663662);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927368, RefRangeEnd = 927369, XrefRangeStart = 927366, XrefRangeEnd = 927368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UserPreferences MakeUserPreferences()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserPreferences.NativeMethodInfoPtr_MakeUserPreferences_Public_Static_UserPreferences_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UserPreferences*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UserPreferences(float brightnessOffset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &brightnessOffset
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserPreferences.NativeMethodInfoPtr__ctor_Private_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserPreferences>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe float kBrightnessMin
  {
    get
    {
      float kBrightnessMin;
      IL2CPP.il2cpp_field_static_get_value(UserPreferences.NativeFieldInfoPtr_kBrightnessMin, (void*) &kBrightnessMin);
      return kBrightnessMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserPreferences.NativeFieldInfoPtr_kBrightnessMin, (void*) &value);
    }
  }

  public static unsafe float kBrightnessMax
  {
    get
    {
      float kBrightnessMax;
      IL2CPP.il2cpp_field_static_get_value(UserPreferences.NativeFieldInfoPtr_kBrightnessMax, (void*) &kBrightnessMax);
      return kBrightnessMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserPreferences.NativeFieldInfoPtr_kBrightnessMax, (void*) &value);
    }
  }

  public static unsafe float Brightness
  {
    get
    {
      float brightness;
      IL2CPP.il2cpp_field_static_get_value(UserPreferences.NativeFieldInfoPtr_Brightness, (void*) &brightness);
      return brightness;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UserPreferences.NativeFieldInfoPtr_Brightness, (void*) &value);
    }
  }
}
