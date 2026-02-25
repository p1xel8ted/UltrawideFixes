// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerCategory
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

#nullable disable
namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerCategory
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CategoryId;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Loading_Public_Static_get_ProfilerCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0;
  [FieldOffset(0)]
  public readonly ushort m_CategoryId;

  static ProfilerCategory()
  {
    Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", nameof (ProfilerCategory));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr);
    ProfilerCategory.NativeFieldInfoPtr_m_CategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, nameof (m_CategoryId));
    ProfilerCategory.NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663378 /*0x06000052*/);
    ProfilerCategory.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663379 /*0x06000053*/);
    ProfilerCategory.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663380 /*0x06000054*/);
    ProfilerCategory.NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663381 /*0x06000055*/);
    ProfilerCategory.NativeMethodInfoPtr_get_Loading_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663382 /*0x06000056*/);
    ProfilerCategory.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663383 /*0x06000057*/);
  }

  [CallerCount(0)]
  public unsafe ProfilerCategory(ushort category)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &category
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string Name
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 413686, RefRangeEnd = 413687, XrefRangeStart = 413675, XrefRangeEnd = 413686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Name_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413687, XrefRangeEnd = 413688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static unsafe ProfilerCategory Scripts
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ProfilerCategory*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe ProfilerCategory Loading
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Loading_Public_Static_get_ProfilerCategory_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ProfilerCategory*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe implicit operator ushort(ProfilerCategory category)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &category
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Color32 Color => ProfilerUnsafeUtility.GetCategoryDescription(this.m_CategoryId).Color;

  public static ProfilerCategory Render => new ProfilerCategory((ushort) 0);

  public static ProfilerCategory Gui => new ProfilerCategory((ushort) 4);

  public static ProfilerCategory Physics => new ProfilerCategory((ushort) 5);

  public static ProfilerCategory Physics2D => new ProfilerCategory((ushort) 33);

  public static ProfilerCategory Animation => new ProfilerCategory((ushort) 6);

  public static ProfilerCategory Ai => new ProfilerCategory((ushort) 7);

  public static ProfilerCategory Audio => new ProfilerCategory((ushort) 8);

  public static ProfilerCategory Video => new ProfilerCategory((ushort) 11);

  public static ProfilerCategory Particles => new ProfilerCategory((ushort) 12);

  public static ProfilerCategory Lighting => new ProfilerCategory((ushort) 13);

  public static ProfilerCategory Network => new ProfilerCategory((ushort) 14);

  public static ProfilerCategory Vr => new ProfilerCategory((ushort) 22);

  public static ProfilerCategory Input => new ProfilerCategory((ushort) 30);

  public static ProfilerCategory Memory => new ProfilerCategory((ushort) 23);

  public static ProfilerCategory VirtualTexturing => new ProfilerCategory((ushort) 31 /*0x1F*/);

  public static ProfilerCategory FileIO => new ProfilerCategory((ushort) 25);

  public static ProfilerCategory Internal => new ProfilerCategory((ushort) 24);

  public static ProfilerCategory Any => new ProfilerCategory(ushort.MaxValue);

  public static ProfilerCategory GPU => new ProfilerCategory((ushort) 32 /*0x20*/);
}
