// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowMapCacheSlot
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ShadowMapCacheSlot(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_index;
  private static readonly System.IntPtr NativeFieldInfoPtr_isNew;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static ShadowMapCacheSlot()
  {
    Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowMapCacheSlot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr);
    ShadowMapCacheSlot.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr, nameof (index));
    ShadowMapCacheSlot.NativeFieldInfoPtr_isNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr, nameof (isNew));
    ShadowMapCacheSlot.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr, 100664058);
    ShadowMapCacheSlot.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr, 100664059);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 656511, RefRangeEnd = 656512, XrefRangeStart = 656511, XrefRangeEnd = 656512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowMapCacheSlot(int index, bool isNew)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowMapCacheSlot>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isNew;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMapCacheSlot.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932283, XrefRangeEnd = 932290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowMapCacheSlot.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public unsafe int index
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCacheSlot.NativeFieldInfoPtr_index));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCacheSlot.NativeFieldInfoPtr_index)) = value;
    }
  }

  public unsafe bool isNew
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCacheSlot.NativeFieldInfoPtr_isNew));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCacheSlot.NativeFieldInfoPtr_isNew)) = value;
    }
  }
}
