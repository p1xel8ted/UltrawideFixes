// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.Attribute
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class Attribute(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Visibility_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_AttributeInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Attribute()
  {
    Il2CppClassPointerStore<Attribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (Attribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Attribute>.NativeClassPtr);
    Attribute.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attribute>.NativeClassPtr, "<Data>k__BackingField");
    Attribute.NativeFieldInfoPtr__Visibility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attribute>.NativeClassPtr, "<Visibility>k__BackingField");
    Attribute.NativeMethodInfoPtr_get_Data_Public_get_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668872);
    Attribute.NativeMethodInfoPtr_set_Data_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668873);
    Attribute.NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668874);
    Attribute.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668875);
    Attribute.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_AttributeInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668876);
    Attribute.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668877);
    Attribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100668878);
  }

  public unsafe AttributeData Data
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_get_Data_Public_get_AttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AttributeData) null : Il2CppObjectPool.Get<AttributeData>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_set_Data_Public_set_Void_AttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LobbyAttributeVisibility Visibility
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LobbyAttributeVisibility*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388415, XrefRangeEnd = 388427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<AttributeInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_AttributeInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388427, XrefRangeEnd = 388443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Attribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Attribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AttributeData _Data_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Data_k__BackingField));
      return num == System.IntPtr.Zero ? (AttributeData) null : Il2CppObjectPool.Get<AttributeData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LobbyAttributeVisibility _Visibility_k__BackingField
  {
    get
    {
      return *(LobbyAttributeVisibility*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Visibility_k__BackingField));
    }
    [param: In] set
    {
      *(LobbyAttributeVisibility*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Visibility_k__BackingField)) = value;
    }
  }
}
