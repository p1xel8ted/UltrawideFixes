// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.LinkAccountOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

public class LinkAccountOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LinkAccountFlags_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ContinuanceToken_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LinkAccountFlags_Public_get_LinkAccountFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LinkAccountFlags_Public_set_Void_LinkAccountFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ContinuanceToken_Public_get_ContinuanceToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LinkAccountOptions()
  {
    Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (LinkAccountOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr);
    LinkAccountOptions.NativeFieldInfoPtr__LinkAccountFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, "<LinkAccountFlags>k__BackingField");
    LinkAccountOptions.NativeFieldInfoPtr__ContinuanceToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, "<ContinuanceToken>k__BackingField");
    LinkAccountOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
    LinkAccountOptions.NativeMethodInfoPtr_get_LinkAccountFlags_Public_get_LinkAccountFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672128);
    LinkAccountOptions.NativeMethodInfoPtr_set_LinkAccountFlags_Public_set_Void_LinkAccountFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672129);
    LinkAccountOptions.NativeMethodInfoPtr_get_ContinuanceToken_Public_get_ContinuanceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672130);
    LinkAccountOptions.NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672131);
    LinkAccountOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672132);
    LinkAccountOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672133);
    LinkAccountOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr, 100672134);
  }

  public unsafe LinkAccountFlags LinkAccountFlags
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr_get_LinkAccountFlags_Public_get_LinkAccountFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LinkAccountFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr_set_LinkAccountFlags_Public_set_Void_LinkAccountFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ContinuanceToken ContinuanceToken
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr_get_ContinuanceToken_Public_get_ContinuanceToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ContinuanceToken) null : Il2CppObjectPool.Get<ContinuanceToken>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LinkAccountOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkAccountOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LinkAccountOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LinkAccountFlags _LinkAccountFlags_k__BackingField
  {
    get
    {
      return *(LinkAccountFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkAccountOptions.NativeFieldInfoPtr__LinkAccountFlags_k__BackingField));
    }
    [param: In] set
    {
      *(LinkAccountFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkAccountOptions.NativeFieldInfoPtr__LinkAccountFlags_k__BackingField)) = value;
    }
  }

  public unsafe ContinuanceToken _ContinuanceToken_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkAccountOptions.NativeFieldInfoPtr__ContinuanceToken_k__BackingField));
      return num == System.IntPtr.Zero ? (ContinuanceToken) null : Il2CppObjectPool.Get<ContinuanceToken>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkAccountOptions.NativeFieldInfoPtr__ContinuanceToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EpicAccountId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkAccountOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkAccountOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
