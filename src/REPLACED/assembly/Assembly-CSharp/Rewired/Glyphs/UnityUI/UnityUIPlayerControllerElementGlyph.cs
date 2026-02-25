// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIPlayerControllerElementGlyph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUIPlayerControllerElementGlyph(IntPtr pointer) : 
  UnityUIPlayerControllerElementGlyphBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__playerId;
  private static readonly IntPtr NativeFieldInfoPtr__actionName;
  private static readonly IntPtr NativeFieldInfoPtr__actionId;
  private static readonly IntPtr NativeFieldInfoPtr__actionIdCached;
  private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_Virtual_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_Virtual_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_Virtual_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_Virtual_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_CacheActionId_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnityUIPlayerControllerElementGlyph()
  {
    Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUIPlayerControllerElementGlyph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr);
    UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, nameof (_playerId));
    UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, nameof (_actionName));
    UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, nameof (_actionId));
    UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionIdCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, nameof (_actionIdCached));
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_get_playerId_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668657);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_set_playerId_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668658);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_get_actionId_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668659);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_set_actionId_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668660);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668661);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668662);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_CacheActionId_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668663);
    UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr, 100668664);
  }

  public override unsafe int playerId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_get_playerId_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_set_playerId_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe int actionId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69919, XrefRangeEnd = 69920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_get_actionId_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69920, XrefRangeEnd = 69934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_set_actionId_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string actionName
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69934, XrefRangeEnd = 69935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 69946, RefRangeEnd = 69949, XrefRangeStart = 69935, XrefRangeEnd = 69946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CacheActionId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr_CacheActionId_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69949, XrefRangeEnd = 69970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUIPlayerControllerElementGlyph()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyph>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIPlayerControllerElementGlyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__playerId)) = value;
    }
  }

  public unsafe string _actionName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int _actionId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionId)) = value;
    }
  }

  public unsafe bool _actionIdCached
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionIdCached));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyph.NativeFieldInfoPtr__actionIdCached)) = value;
    }
  }
}
