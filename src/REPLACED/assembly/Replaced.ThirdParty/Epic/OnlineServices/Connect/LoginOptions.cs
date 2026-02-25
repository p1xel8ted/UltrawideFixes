// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.LoginOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

public class LoginOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Credentials_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UserLoginInfo_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Credentials_Public_get_Credentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Credentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserLoginInfo_Public_get_UserLoginInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_UserLoginInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LoginOptions()
  {
    Il2CppClassPointerStore<LoginOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (LoginOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr);
    LoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, "<Credentials>k__BackingField");
    LoginOptions.NativeFieldInfoPtr__UserLoginInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, "<UserLoginInfo>k__BackingField");
    LoginOptions.NativeMethodInfoPtr_get_Credentials_Public_get_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100671715);
    LoginOptions.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100671716);
    LoginOptions.NativeMethodInfoPtr_get_UserLoginInfo_Public_get_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100671717);
    LoginOptions.NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100671718);
    LoginOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr, 100671719);
  }

  public unsafe Credentials Credentials
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_get_Credentials_Public_get_Credentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Credentials) null : Il2CppObjectPool.Get<Credentials>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Credentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe UserLoginInfo UserLoginInfo
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_get_UserLoginInfo_Public_get_UserLoginInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UserLoginInfo) null : Il2CppObjectPool.Get<UserLoginInfo>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_UserLoginInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LoginOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoginOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Credentials _Credentials_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField));
      return num == System.IntPtr.Zero ? (Credentials) null : Il2CppObjectPool.Get<Credentials>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__Credentials_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UserLoginInfo _UserLoginInfo_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__UserLoginInfo_k__BackingField));
      return num == System.IntPtr.Zero ? (UserLoginInfo) null : Il2CppObjectPool.Get<UserLoginInfo>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoginOptions.NativeFieldInfoPtr__UserLoginInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
