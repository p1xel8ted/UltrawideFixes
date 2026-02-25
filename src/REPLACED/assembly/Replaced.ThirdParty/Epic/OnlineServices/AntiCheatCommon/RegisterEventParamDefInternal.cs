// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.RegisterEventParamDefInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterEventParamDefInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamType;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamType_Public_get_AntiCheatCommonEventParamType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamType_Public_set_Void_AntiCheatCommonEventParamType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RegisterEventParamDef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public System.IntPtr m_ParamName;
  [FieldOffset(8)]
  public AntiCheatCommonEventParamType m_ParamType;

  static RegisterEventParamDefInternal()
  {
    Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (RegisterEventParamDefInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr);
    RegisterEventParamDefInternal.NativeFieldInfoPtr_m_ParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, nameof (m_ParamName));
    RegisterEventParamDefInternal.NativeFieldInfoPtr_m_ParamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, nameof (m_ParamType));
    RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672961);
    RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672962);
    RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamType_Public_get_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672963);
    RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamType_Public_set_Void_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672964);
    RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672965);
    RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672966);
    RegisterEventParamDefInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100672967);
  }

  public unsafe string ParamName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401006, XrefRangeEnd = 401010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401010, XrefRangeEnd = 401014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonEventParamType ParamType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamType_Public_get_AntiCheatCommonEventParamType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonEventParamType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147413, RefRangeEnd = 147418, XrefRangeStart = 147413, XrefRangeEnd = 147418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamType_Public_set_Void_AntiCheatCommonEventParamType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401014, XrefRangeEnd = 401018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RegisterEventParamDef other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterEventParamDef_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401018, XrefRangeEnd = 401024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401024, XrefRangeEnd = 401028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
