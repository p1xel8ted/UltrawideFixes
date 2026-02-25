// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIControllerElementGlyphBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUIControllerElementGlyphBase(System.IntPtr pointer) : ControllerElementGlyphBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultGlyphOrTextPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultGlyphOrTextPrefabProvider;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultGlyphOrTextPrefab_Protected_Virtual_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultGlyphOrTextPrefab_Public_Static_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultGlyphOrTextPrefab_Public_Static_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultGlyphOrTextPrefabProvider_Public_Static_get_Func_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultGlyphOrTextPrefabProvider_Public_Static_set_Void_Func_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultGlyphOrTextPrefab_Private_Static_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static UnityUIControllerElementGlyphBase()
  {
    Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUIControllerElementGlyphBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr);
    UnityUIControllerElementGlyphBase.NativeFieldInfoPtr_s_defaultGlyphOrTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, nameof (s_defaultGlyphOrTextPrefab));
    UnityUIControllerElementGlyphBase.NativeFieldInfoPtr_s_defaultGlyphOrTextPrefabProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, nameof (s_defaultGlyphOrTextPrefabProvider));
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_GetDefaultGlyphOrTextPrefab_Protected_Virtual_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668635);
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_get_defaultGlyphOrTextPrefab_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668636);
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_set_defaultGlyphOrTextPrefab_Public_Static_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668637);
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_get_defaultGlyphOrTextPrefabProvider_Public_Static_get_Func_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668638);
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_set_defaultGlyphOrTextPrefabProvider_Public_Static_set_Void_Func_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668639);
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_CreateDefaultGlyphOrTextPrefab_Private_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668640);
    UnityUIControllerElementGlyphBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr, 100668641);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe GameObject GetDefaultGlyphOrTextPrefab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_GetDefaultGlyphOrTextPrefab_Protected_Virtual_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  public static unsafe GameObject defaultGlyphOrTextPrefab
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 69737, RefRangeEnd = 69739, XrefRangeStart = 69730, XrefRangeEnd = 69737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_get_defaultGlyphOrTextPrefab_Public_Static_get_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69739, XrefRangeEnd = 69741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_set_defaultGlyphOrTextPrefab_Public_Static_set_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Il2CppSystem.Func<GameObject> defaultGlyphOrTextPrefabProvider
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69741, XrefRangeEnd = 69743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_get_defaultGlyphOrTextPrefabProvider_Public_Static_get_Func_1_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<GameObject>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69743, XrefRangeEnd = 69745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_set_defaultGlyphOrTextPrefabProvider_Public_Static_set_Void_Func_1_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69745, XrefRangeEnd = 69806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject CreateDefaultGlyphOrTextPrefab()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUIControllerElementGlyphBase.NativeMethodInfoPtr_CreateDefaultGlyphOrTextPrefab_Private_Static_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUIControllerElementGlyphBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUIControllerElementGlyphBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIControllerElementGlyphBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe GameObject s_defaultGlyphOrTextPrefab
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityUIControllerElementGlyphBase.NativeFieldInfoPtr_s_defaultGlyphOrTextPrefab, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityUIControllerElementGlyphBase.NativeFieldInfoPtr_s_defaultGlyphOrTextPrefab, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Func<GameObject> s_defaultGlyphOrTextPrefabProvider
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityUIControllerElementGlyphBase.NativeFieldInfoPtr_s_defaultGlyphOrTextPrefabProvider, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<GameObject>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityUIControllerElementGlyphBase.NativeFieldInfoPtr_s_defaultGlyphOrTextPrefabProvider, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
