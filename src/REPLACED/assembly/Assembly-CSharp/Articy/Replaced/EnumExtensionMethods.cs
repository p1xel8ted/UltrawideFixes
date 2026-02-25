// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.EnumExtensionMethods
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace Articy.Replaced;

public static class EnumExtensionMethods : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_Sex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_StatType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_AbilityType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_lore_item_type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_ShapeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_SelectabilityModes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_VisibilityModes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_OutlineStyle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_PathCaps_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_LocationAnchorSize_0;

  static EnumExtensionMethods()
  {
    Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (EnumExtensionMethods));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_Sex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678237);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_StatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678238);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_AbilityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678239);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_lore_item_type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678240);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_ShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678241);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_SelectabilityModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678242);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_VisibilityModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678243);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_OutlineStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678244);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_PathCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678245);
    EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_LocationAnchorSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumExtensionMethods>.NativeClassPtr, 100678246);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135373, XrefRangeEnd = 135382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this Sex aSex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aSex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_Sex_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135382, XrefRangeEnd = 135391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this StatType aStatType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aStatType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_StatType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135391, XrefRangeEnd = 135400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this AbilityType aAbilityType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aAbilityType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_AbilityType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135400, XrefRangeEnd = 135409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this lore_item_type alore_item_type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &alore_item_type
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_lore_item_type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135409, XrefRangeEnd = 135418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this ShapeType aShapeType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aShapeType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_ShapeType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135418, XrefRangeEnd = 135427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this SelectabilityModes aSelectabilityModes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aSelectabilityModes
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_SelectabilityModes_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135427, XrefRangeEnd = 135436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this VisibilityModes aVisibilityModes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aVisibilityModes
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_VisibilityModes_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135436, XrefRangeEnd = 135445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this OutlineStyle aOutlineStyle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aOutlineStyle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_OutlineStyle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135445, XrefRangeEnd = 135454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this PathCaps aPathCaps)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aPathCaps
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_PathCaps_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135454, XrefRangeEnd = 135463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDisplayName(this LocationAnchorSize aLocationAnchorSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aLocationAnchorSize
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumExtensionMethods.NativeMethodInfoPtr_GetDisplayName_Public_Static_String_LocationAnchorSize_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public EnumExtensionMethods(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
