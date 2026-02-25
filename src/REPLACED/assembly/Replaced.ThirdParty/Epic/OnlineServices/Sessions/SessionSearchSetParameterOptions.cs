// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionSearchSetParameterOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public class SessionSearchSetParameterOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Parameter_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ComparisonOp_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Parameter_Public_get_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ComparisonOp_Public_get_ComparisonOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SessionSearchSetParameterOptions()
  {
    Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionSearchSetParameterOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr);
    SessionSearchSetParameterOptions.NativeFieldInfoPtr__Parameter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, "<Parameter>k__BackingField");
    SessionSearchSetParameterOptions.NativeFieldInfoPtr__ComparisonOp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, "<ComparisonOp>k__BackingField");
    SessionSearchSetParameterOptions.NativeMethodInfoPtr_get_Parameter_Public_get_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, 100665998);
    SessionSearchSetParameterOptions.NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, 100665999);
    SessionSearchSetParameterOptions.NativeMethodInfoPtr_get_ComparisonOp_Public_get_ComparisonOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, 100666000 /*0x06000A90*/);
    SessionSearchSetParameterOptions.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, 100666001);
    SessionSearchSetParameterOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr, 100666002);
  }

  public unsafe AttributeData Parameter
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptions.NativeMethodInfoPtr_get_Parameter_Public_get_AttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptions.NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ComparisonOp ComparisonOp
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptions.NativeMethodInfoPtr_get_ComparisonOp_Public_get_ComparisonOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ComparisonOp*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptions.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SessionSearchSetParameterOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearchSetParameterOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AttributeData _Parameter_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchSetParameterOptions.NativeFieldInfoPtr__Parameter_k__BackingField));
      return num == System.IntPtr.Zero ? (AttributeData) null : Il2CppObjectPool.Get<AttributeData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchSetParameterOptions.NativeFieldInfoPtr__Parameter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComparisonOp _ComparisonOp_k__BackingField
  {
    get
    {
      return *(ComparisonOp*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchSetParameterOptions.NativeFieldInfoPtr__ComparisonOp_k__BackingField));
    }
    [param: In] set
    {
      *(ComparisonOp*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchSetParameterOptions.NativeFieldInfoPtr__ComparisonOp_k__BackingField)) = value;
    }
  }
}
