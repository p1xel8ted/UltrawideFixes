// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CharacterParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CharacterParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rimColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightIntensity;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_0;
  [FieldOffset(0)]
  public readonly Vector3 rimColor;
  [FieldOffset(12)]
  public readonly Vector3 highlightColor;
  [FieldOffset(24)]
  public readonly float highlightIntensity;

  static CharacterParams()
  {
    Il2CppClassPointerStore<CharacterParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CharacterParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterParams>.NativeClassPtr);
    CharacterParams.NativeFieldInfoPtr_rimColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterParams>.NativeClassPtr, nameof (rimColor));
    CharacterParams.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterParams>.NativeClassPtr, nameof (highlightColor));
    CharacterParams.NativeFieldInfoPtr_highlightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterParams>.NativeClassPtr, nameof (highlightIntensity));
    CharacterParams.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterParams>.NativeClassPtr, 100663603);
  }

  [CallerCount(0)]
  public unsafe CharacterParams(Vector3 rimColor, Vector3 highlightColor, float highlightIntensity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &rimColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &highlightColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &highlightIntensity;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterParams.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
