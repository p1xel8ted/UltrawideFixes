// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ShadowState
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ShadowState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mStorage;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

  static ShadowState()
  {
    Il2CppClassPointerStore<ShadowState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ShadowState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowState>.NativeClassPtr);
    ShadowState.NativeFieldInfoPtr_mStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowState>.NativeClassPtr, nameof (mStorage));
    ShadowState.NativeMethodInfoPtr__ctor_Public_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowState>.NativeClassPtr, 100664061);
    ShadowState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowState>.NativeClassPtr, 100664062);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994669, XrefRangeEnd = 994672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowState(BaseGlobalVariables aStorage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowState>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStorage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowState.NativeMethodInfoPtr__ctor_Public_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994672, XrefRangeEnd = 994674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BaseGlobalVariables mStorage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowState.NativeFieldInfoPtr_mStorage));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowState.NativeFieldInfoPtr_mStorage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
