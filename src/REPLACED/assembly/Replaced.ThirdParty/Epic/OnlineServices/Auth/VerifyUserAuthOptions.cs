// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyUserAuthOptions
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

public class VerifyUserAuthOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AuthToken_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AuthToken_Public_get_Token_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Token_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VerifyUserAuthOptions()
  {
    Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (VerifyUserAuthOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr);
    VerifyUserAuthOptions.NativeFieldInfoPtr__AuthToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, "<AuthToken>k__BackingField");
    VerifyUserAuthOptions.NativeMethodInfoPtr_get_AuthToken_Public_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, 100672436);
    VerifyUserAuthOptions.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, 100672437);
    VerifyUserAuthOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr, 100672438);
  }

  public unsafe Token AuthToken
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptions.NativeMethodInfoPtr_get_AuthToken_Public_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Token) null : Il2CppObjectPool.Get<Token>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptions.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VerifyUserAuthOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerifyUserAuthOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Token _AuthToken_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyUserAuthOptions.NativeFieldInfoPtr__AuthToken_k__BackingField));
      return num == System.IntPtr.Zero ? (Token) null : Il2CppObjectPool.Get<Token>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyUserAuthOptions.NativeFieldInfoPtr__AuthToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
