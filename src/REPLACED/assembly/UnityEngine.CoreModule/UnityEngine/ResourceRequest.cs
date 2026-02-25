// Decompiled with JetBrains decompiler
// Type: UnityEngine.ResourceRequest
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class ResourceRequest(System.IntPtr pointer) : AsyncOperation(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Path;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_asset_Public_get_Object_0;

  static ResourceRequest()
  {
    Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ResourceRequest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr);
    ResourceRequest.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, nameof (m_Path));
    ResourceRequest.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, nameof (m_Type));
    ResourceRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100667778);
    ResourceRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100667779);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442113, XrefRangeEnd = 442114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Object GetResult()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResourceRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  public unsafe Object asset
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 362026, RefRangeEnd = 362037, XrefRangeStart = 362026, XrefRangeEnd = 362037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourceRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
    }
  }

  public unsafe string m_Path
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppSystem.Type m_Type
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public new static class BindingsMarshaller
  {
  }
}
