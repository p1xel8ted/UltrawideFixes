// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIDefaultGlyphOrTextTMProPrefabProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUIDefaultGlyphOrTextTMProPrefabProvider(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultGlyphOrTextPrefab_Private_Static_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnityUIDefaultGlyphOrTextTMProPrefabProvider()
  {
    Il2CppClassPointerStore<UnityUIDefaultGlyphOrTextTMProPrefabProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUIDefaultGlyphOrTextTMProPrefabProvider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUIDefaultGlyphOrTextTMProPrefabProvider>.NativeClassPtr);
    UnityUIDefaultGlyphOrTextTMProPrefabProvider.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIDefaultGlyphOrTextTMProPrefabProvider>.NativeClassPtr, 100668644);
    UnityUIDefaultGlyphOrTextTMProPrefabProvider.NativeMethodInfoPtr_CreateDefaultGlyphOrTextPrefab_Private_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIDefaultGlyphOrTextTMProPrefabProvider>.NativeClassPtr, 100668645);
    UnityUIDefaultGlyphOrTextTMProPrefabProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIDefaultGlyphOrTextTMProPrefabProvider>.NativeClassPtr, 100668646);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69808, XrefRangeEnd = 69816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Initialize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIDefaultGlyphOrTextTMProPrefabProvider.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69816, XrefRangeEnd = 69869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject CreateDefaultGlyphOrTextPrefab()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUIDefaultGlyphOrTextTMProPrefabProvider.NativeMethodInfoPtr_CreateDefaultGlyphOrTextPrefab_Private_Static_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUIDefaultGlyphOrTextTMProPrefabProvider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUIDefaultGlyphOrTextTMProPrefabProvider>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIDefaultGlyphOrTextTMProPrefabProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
