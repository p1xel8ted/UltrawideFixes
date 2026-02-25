// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerCategoryDescription
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_Flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color;
  private static readonly System.IntPtr NativeFieldInfoPtr_reserved0;
  private static readonly System.IntPtr NativeFieldInfoPtr_NameUtf8Len;
  private static readonly System.IntPtr NativeFieldInfoPtr_NameUtf8;
  [FieldOffset(0)]
  public readonly ushort Id;
  [FieldOffset(2)]
  public readonly ushort Flags;
  [FieldOffset(4)]
  public readonly Color32 Color;
  [FieldOffset(8)]
  public readonly int reserved0;
  [FieldOffset(12)]
  public readonly int NameUtf8Len;
  [FieldOffset(16 /*0x10*/)]
  public readonly System.IntPtr NameUtf8;

  static ProfilerCategoryDescription()
  {
    Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", nameof (ProfilerCategoryDescription));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr);
    ProfilerCategoryDescription.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, nameof (Id));
    ProfilerCategoryDescription.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, nameof (Flags));
    ProfilerCategoryDescription.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, nameof (Color));
    ProfilerCategoryDescription.NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, nameof (reserved0));
    ProfilerCategoryDescription.NativeFieldInfoPtr_NameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, nameof (NameUtf8Len));
    ProfilerCategoryDescription.NativeFieldInfoPtr_NameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, nameof (NameUtf8));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public unsafe string Name
  {
    get => ProfilerUnsafeUtility.Utf8ToString((byte*) this.NameUtf8, this.NameUtf8Len);
  }
}
