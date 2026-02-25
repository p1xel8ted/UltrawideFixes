// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.RegisterPlayersOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public class RegisterPlayersOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__SessionName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayersToRegister_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayersToRegister_Public_get_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RegisterPlayersOptions()
  {
    Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (RegisterPlayersOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr);
    RegisterPlayersOptions.NativeFieldInfoPtr__SessionName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, "<SessionName>k__BackingField");
    RegisterPlayersOptions.NativeFieldInfoPtr__PlayersToRegister_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, "<PlayersToRegister>k__BackingField");
    RegisterPlayersOptions.NativeMethodInfoPtr_get_SessionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, 100665675);
    RegisterPlayersOptions.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, 100665676);
    RegisterPlayersOptions.NativeMethodInfoPtr_get_PlayersToRegister_Public_get_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, 100665677);
    RegisterPlayersOptions.NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, 100665678);
    RegisterPlayersOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr, 100665679);
  }

  public unsafe string SessionName
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptions.NativeMethodInfoPtr_get_SessionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptions.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> PlayersToRegister
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptions.NativeMethodInfoPtr_get_PlayersToRegister_Public_get_Il2CppReferenceArray_1_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<ProductUserId>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ProductUserId>>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptions.NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RegisterPlayersOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterPlayersOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _SessionName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPlayersOptions.NativeFieldInfoPtr__SessionName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterPlayersOptions.NativeFieldInfoPtr__SessionName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> _PlayersToRegister_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterPlayersOptions.NativeFieldInfoPtr__PlayersToRegister_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ProductUserId>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ProductUserId>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterPlayersOptions.NativeFieldInfoPtr__PlayersToRegister_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
