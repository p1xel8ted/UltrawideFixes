// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyIdTokenOptions
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

public class VerifyIdTokenOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__IdToken_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IdToken_Public_get_IdToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IdToken_Public_set_Void_IdToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VerifyIdTokenOptions()
  {
    Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (VerifyIdTokenOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr);
    VerifyIdTokenOptions.NativeFieldInfoPtr__IdToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr, "<IdToken>k__BackingField");
    VerifyIdTokenOptions.NativeMethodInfoPtr_get_IdToken_Public_get_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr, 100672418);
    VerifyIdTokenOptions.NativeMethodInfoPtr_set_IdToken_Public_set_Void_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr, 100672419);
    VerifyIdTokenOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr, 100672420);
  }

  public unsafe IdToken IdToken
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptions.NativeMethodInfoPtr_get_IdToken_Public_get_IdToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IdToken) null : Il2CppObjectPool.Get<IdToken>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptions.NativeMethodInfoPtr_set_IdToken_Public_set_Void_IdToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VerifyIdTokenOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerifyIdTokenOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe IdToken _IdToken_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenOptions.NativeFieldInfoPtr__IdToken_k__BackingField));
      return num == System.IntPtr.Zero ? (IdToken) null : Il2CppObjectPool.Get<IdToken>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenOptions.NativeFieldInfoPtr__IdToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
