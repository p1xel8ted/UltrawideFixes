// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.SpriteAtlasManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.U2D;

public class SpriteAtlasManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_atlasRequested;
  private static readonly System.IntPtr NativeFieldInfoPtr_atlasRegistered;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Register_Injected_Private_Static_Void_IntPtr_0;

  static SpriteAtlasManager()
  {
    Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", nameof (SpriteAtlasManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr);
    SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, nameof (atlasRequested));
    SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, nameof (atlasRegistered));
    SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100670786);
    SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100670787);
    SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100670788);
    SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100670789);
    SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100670790);
    SpriteAtlasManager.NativeMethodInfoPtr_Register_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100670791);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489935, XrefRangeEnd = 489939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool RequestAtlas(string tag)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(tag)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 489948, RefRangeEnd = 489951, XrefRangeStart = 489939, XrefRangeEnd = 489948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void add_atlasRegistered(Il2CppSystem.Action<SpriteAtlas> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489960, RefRangeEnd = 489961, XrefRangeStart = 489951, XrefRangeEnd = 489960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void remove_atlasRegistered(Il2CppSystem.Action<SpriteAtlas> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489961, XrefRangeEnd = 489963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spriteAtlas)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489963, XrefRangeEnd = 489968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Register(SpriteAtlas spriteAtlas)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spriteAtlas)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489968, XrefRangeEnd = 489970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Register_Injected(System.IntPtr spriteAtlas)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &spriteAtlas
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_Register_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>> atlasRequested
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<SpriteAtlas> atlasRegistered
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<SpriteAtlas>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<SpriteAtlas>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [SpecialName]
  public static void add_atlasRequested(Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_atlasRequested(Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
